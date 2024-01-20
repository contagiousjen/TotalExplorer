using System.Diagnostics;
using System.IO;
using System.Text;

namespace TotalExplorer
{
    public partial class Form1 : Form
    {
        private FileSystem FileSystem1;
        private FileSystem FileSystem2;
        public Form1()
        {
            InitializeComponent();
            FileSystem1 = new FileSystem(Path.GetPathRoot(Environment.SystemDirectory));
            FileSystem2 = new FileSystem(Path.GetPathRoot(Environment.SystemDirectory));
            FillListView(listView1, FileSystem1.CurrentDirectory);
            FillListView(listView2, FileSystem2.CurrentDirectory);
        }

       

        

        public void FillListView(ListView listView, DirectoryInfo currentDirectory)
        {
            listView.Items.Clear();
            if (currentDirectory.Parent != null)
            {
                listView.Items.Add(new ListViewItem("...", 0));
            }

            foreach (DirectoryInfo directory in currentDirectory.GetDirectories())
            {
                listView.Items.Add(new ListViewItem(directory.Name, 0));
            }

            foreach (FileInfo file in currentDirectory.GetFiles())
            {
                listView.Items.Add(new ListViewItem(file.Name, 1));
            }
        }

        public (string[], int) GetSelectedPathsFromBothViews()
        {
            if (listView1.ContainsFocus)
            {
                return (GetSelectedPaths(listView1, FileSystem1.CurrentDirectory), 1);
            }
            else if (listView2.ContainsFocus)
            {
                return (GetSelectedPaths(listView2, FileSystem2.CurrentDirectory), 2);
            }
            else
            {
                return (Array.Empty<string>(), 0);
            }
        }

        public string[] GetSelectedPaths(ListView listView, DirectoryInfo currentDirectory)
        {
            var selectedItems = listView.SelectedItems;
            var result = new List<string>();
            foreach (ListViewItem item in selectedItems)
            {
                if (item.Text.Equals("..."))
                {
                    result.Add(currentDirectory.Parent.FullName);
                }
                else
                {
                    result.Add(Path.Combine(currentDirectory.FullName, item.Text));
                }
            }
            
            return result.ToArray();
        }

        private void ïåğåèìåíîâàòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var (paths, listViewNumber) = GetSelectedPathsFromBothViews();
            if (paths.Length != 1)
            {
                return;
            }
            var path = paths[0];
            var currentDirectory = FileSystem1;
            var listView = listView1;
            if (listViewNumber == 2)
            {
                currentDirectory = FileSystem2;
                listView = listView2;
            }

            if (currentDirectory.CurrentDirectory.Parent != null && path.Equals(currentDirectory.CurrentDirectory.Parent.FullName))
            {
                return;
            }

            listView.SelectedItems[0].BeginEdit();
        }

        private void ñîçäàòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView listView;
            FileSystem fileSystem;

            if (listView1.ContainsFocus)
            {
                listView = listView1;
                fileSystem = FileSystem1;
            }
            else if (listView2.ContainsFocus)
            {
                listView = listView2;
                fileSystem = FileSystem2;
            }
            else
            {
                return;
            }
            var newItem = new ListViewItem("", 1);
            listView.Items.Add(newItem);
            listView.SelectedItems.Clear();
            newItem.Selected = true;
            newItem.BeginEdit();

            fileSystem.CreateFile("temp");

            return;
        }



        private void MyListView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;


            if (string.IsNullOrEmpty(e.Label) &&
                e.Label.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                e.CancelEdit = true;
                MessageBox.Show("Íåêîğğåêòíîå èìÿ ôàéëà");
                return;
            }

            var fileSystem = FileSystem1;
            var listView = (ListView)sender;

            if (sender.Equals(listView2))
            {
                fileSystem = FileSystem2;
            }

            try
            {
                fileSystem.RenameFile(e.Label, listView.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Îïåğàöèÿ ñ ôàéëîì íå óäàëàñü: {ex.Message}");
                e.CancelEdit = true;
            }
            FillListView(listView, fileSystem.CurrentDirectory);
            return;
        }

        private void îòêğûòüÑÏîìîùüşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var (paths, listViewNumber) = GetSelectedPathsFromBothViews();
            if (paths.Length != 1)
            {
                return;
            }

            var path = paths[0];

            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
            {
                return;
            }
            
            var currentDirectory = FileSystem1.CurrentDirectory;

            if (listViewNumber == 2)
            {
                currentDirectory = FileSystem2.CurrentDirectory;
            }

            if (currentDirectory.Parent != null && path.Equals(currentDirectory.Parent.FullName))
            {
                return;
            }

            var args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
            args += ",OpenAs_RunDLL " + path;
            Process.Start("rundll32.exe", args);
        }

        private void íàñòğîèòüÏàíåëüÈíñòğóìåíòîâToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void íàñòğîéêèToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void îòêğûòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var (paths, listViewNumber) = GetSelectedPathsFromBothViews();
            if (paths.Length != 1)
            {
                return;
            }
            var path = paths[0];
            
            if (FileSystem.IsDirectory(path))
            {
                if (listViewNumber == 1)
                {
                    FileSystem1 = new FileSystem(path);
                    FillListView(listView1, FileSystem1.CurrentDirectory);
                }
                else
                {
                    FileSystem2 = new FileSystem(path);
                    FillListView(listView2, FileSystem2.CurrentDirectory);
                }
            }
            else
            {
                using Process fileopener = new Process();

                fileopener.StartInfo.FileName = "explorer";
                fileopener.StartInfo.Arguments = "\"" + path + "\"";
                fileopener.Start();
            }
        }

        private void óäàëèòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var (paths, listViewNumber) = GetSelectedPathsFromBothViews();

            var listView = listView1;
            var fileSystem = FileSystem1;

            if (listViewNumber == 2)
            {
                listView = listView2;
                fileSystem = FileSystem2;
            }
            
            foreach (var path in paths)
            {
                fileSystem.DeleteFile(path);
            }

            FillListView(listView, FileSystem1.CurrentDirectory);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}