namespace TotalExplorer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСПомощьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьПанельИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьВидИконокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.значкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.галереяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиВПолноэкранныйРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьОперациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьОперациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьФайлToolStripMenuItem,
            this.переименоватьФайлToolStripMenuItem,
            this.удалитьФайлToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.открытьСПомощьюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьФайлToolStripMenuItem
            // 
            this.создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            this.создатьФайлToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.создатьФайлToolStripMenuItem.Text = "Создать файл";
            this.создатьФайлToolStripMenuItem.Click += new System.EventHandler(this.создатьФайлToolStripMenuItem_Click);
            // 
            // переименоватьФайлToolStripMenuItem
            // 
            this.переименоватьФайлToolStripMenuItem.Name = "переименоватьФайлToolStripMenuItem";
            this.переименоватьФайлToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.переименоватьФайлToolStripMenuItem.Text = "Переименовать файл";
            this.переименоватьФайлToolStripMenuItem.Click += new System.EventHandler(this.переименоватьФайлToolStripMenuItem_Click);
            // 
            // удалитьФайлToolStripMenuItem
            // 
            this.удалитьФайлToolStripMenuItem.Name = "удалитьФайлToolStripMenuItem";
            this.удалитьФайлToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.удалитьФайлToolStripMenuItem.Text = "Удалить файл";
            this.удалитьФайлToolStripMenuItem.Click += new System.EventHandler(this.удалитьФайлToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // открытьСПомощьюToolStripMenuItem
            // 
            this.открытьСПомощьюToolStripMenuItem.Name = "открытьСПомощьюToolStripMenuItem";
            this.открытьСПомощьюToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.открытьСПомощьюToolStripMenuItem.Text = "Открыть с помощью...";
            this.открытьСПомощьюToolStripMenuItem.Click += new System.EventHandler(this.открытьСПомощьюToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортироватьToolStripMenuItem,
            this.настроитьПанельИнструментовToolStripMenuItem,
            this.изменитьВидИконокToolStripMenuItem,
            this.перейтиВПолноэкранныйРежимToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеToolStripMenuItem,
            this.поНазваниюToolStripMenuItem,
            this.поВозрастаниюToolStripMenuItem,
            this.поУбываниюToolStripMenuItem});
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.сортироватьToolStripMenuItem.Text = " ";
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поДатеToolStripMenuItem.Text = "По дате";
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поНазваниюToolStripMenuItem.Text = "По названию";
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            // 
            // настроитьПанельИнструментовToolStripMenuItem
            // 
            this.настроитьПанельИнструментовToolStripMenuItem.Name = "настроитьПанельИнструментовToolStripMenuItem";
            this.настроитьПанельИнструментовToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.настроитьПанельИнструментовToolStripMenuItem.Text = "Настроить панель инструментов...";
            this.настроитьПанельИнструментовToolStripMenuItem.Click += new System.EventHandler(this.настроитьПанельИнструментовToolStripMenuItem_Click);
            // 
            // изменитьВидИконокToolStripMenuItem
            // 
            this.изменитьВидИконокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.значкиToolStripMenuItem,
            this.списокToolStripMenuItem,
            this.колонкиToolStripMenuItem,
            this.галереяToolStripMenuItem});
            this.изменитьВидИконокToolStripMenuItem.Name = "изменитьВидИконокToolStripMenuItem";
            this.изменитьВидИконокToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.изменитьВидИконокToolStripMenuItem.Text = "Изменить вид иконок";
            // 
            // значкиToolStripMenuItem
            // 
            this.значкиToolStripMenuItem.Name = "значкиToolStripMenuItem";
            this.значкиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.значкиToolStripMenuItem.Text = "Значки";
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.списокToolStripMenuItem.Text = "Список";
            // 
            // колонкиToolStripMenuItem
            // 
            this.колонкиToolStripMenuItem.Name = "колонкиToolStripMenuItem";
            this.колонкиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.колонкиToolStripMenuItem.Text = "Колонки";
            // 
            // галереяToolStripMenuItem
            // 
            this.галереяToolStripMenuItem.Name = "галереяToolStripMenuItem";
            this.галереяToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.галереяToolStripMenuItem.Text = "Галерея";
            // 
            // перейтиВПолноэкранныйРежимToolStripMenuItem
            // 
            this.перейтиВПолноэкранныйРежимToolStripMenuItem.Name = "перейтиВПолноэкранныйРежимToolStripMenuItem";
            this.перейтиВПолноэкранныйРежимToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.перейтиВПолноэкранныйРежимToolStripMenuItem.Text = "Перейти в полноэкранный режим";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.отменитьОперациюToolStripMenuItem,
            this.повторитьОперациюToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // отменитьОперациюToolStripMenuItem
            // 
            this.отменитьОперациюToolStripMenuItem.Name = "отменитьОперациюToolStripMenuItem";
            this.отменитьОперациюToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.отменитьОперациюToolStripMenuItem.Text = "Отменить операцию";
            // 
            // повторитьОперациюToolStripMenuItem
            // 
            this.повторитьОперациюToolStripMenuItem.Name = "повторитьОперациюToolStripMenuItem";
            this.повторитьОперациюToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.повторитьОперациюToolStripMenuItem.Text = "Повторить операцию";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьСправкуToolStripMenuItem,
            this.открытьНастройкиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки и справка";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // открытьСправкуToolStripMenuItem
            // 
            this.открытьСправкуToolStripMenuItem.Name = "открытьСправкуToolStripMenuItem";
            this.открытьСправкуToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.открытьСправкуToolStripMenuItem.Text = "Открыть справку";
            // 
            // открытьНастройкиToolStripMenuItem
            // 
            this.открытьНастройкиToolStripMenuItem.Name = "открытьНастройкиToolStripMenuItem";
            this.открытьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.открытьНастройкиToolStripMenuItem.Text = "Открыть настройки";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-folder-128.png");
            this.imageList1.Images.SetKeyName(1, "icons8-file-128.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8-folder-150.png");
            this.imageList2.Images.SetKeyName(1, "icons8-file-150.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1105, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView2);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 573);
            this.splitContainer1.SplitterDistance = 568;
            this.splitContainer1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GroupImageList = this.imageList1;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 573);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.DoubleClick += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.MyListView_AfterLabelEdit);
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.LabelEdit = true;
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(533, 573);
            this.listView2.SmallImageList = this.imageList1;
            this.listView2.StateImageList = this.imageList1;
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.DoubleClick += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            this.listView2.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.MyListView_AfterLabelEdit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 622);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьФайлToolStripMenuItem;
        private ToolStripMenuItem переименоватьФайлToolStripMenuItem;
        private ToolStripMenuItem удалитьФайлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem открытьСПомощьюToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem сортироватьToolStripMenuItem;
        private ToolStripMenuItem настроитьПанельИнструментовToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem изменитьВидИконокToolStripMenuItem;
        private ToolStripMenuItem перейтиВПолноэкранныйРежимToolStripMenuItem;
        private ToolStripMenuItem поДатеToolStripMenuItem;
        private ToolStripMenuItem поНазваниюToolStripMenuItem;
        private ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private ToolStripMenuItem поУбываниюToolStripMenuItem;
        private ToolStripMenuItem значкиToolStripMenuItem;
        private ToolStripMenuItem списокToolStripMenuItem;
        private ToolStripMenuItem колонкиToolStripMenuItem;
        private ToolStripMenuItem галереяToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem отменитьОперациюToolStripMenuItem;
        private ToolStripMenuItem повторитьОперациюToolStripMenuItem;
        private ToolStripMenuItem открытьСправкуToolStripMenuItem;
        private ToolStripMenuItem открытьНастройкиToolStripMenuItem;
        private ImageList imageList1;
        private ImageList imageList2;
        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private ListView listView1;
        private ListView listView2;
    }
}