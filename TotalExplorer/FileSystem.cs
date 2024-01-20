using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TotalExplorer
{
    internal class FileSystem
    {
        public FileSystem(string currentDirectory)
        {
            CurrentDirectory = new DirectoryInfo(currentDirectory);
            Buffer = SharedBuffer.GetInstance();
        }

        public DirectoryInfo CurrentDirectory { get; }
        public SharedBuffer Buffer { get; }

        public void CopyPath(string name)
        {
            var path = Path.Combine(CurrentDirectory.FullName, name);
            PlacePathToBuffer(path, false);
        }

        public void CutPath(string name)
        {
            var path = Path.Combine(CurrentDirectory.FullName, name);
            PlacePathToBuffer(path, true);
        }

        public void PastePath()
        {
            var oldPath = Buffer.Path;
            if (IsDirectory(oldPath))
            {
                var dirInfo = new DirectoryInfo(oldPath);
                CopyAll(dirInfo, new DirectoryInfo(Path.Combine(CurrentDirectory.FullName, dirInfo.Name)));
            }
            else
            {
                var fileInfo = new FileInfo(oldPath);
                File.Copy(oldPath, Path.Combine(CurrentDirectory.FullName, fileInfo.Name));
            }

            if (Buffer.RemoveOriginal)
            {
                if (IsDirectory(oldPath))
                {
                    Directory.Delete(oldPath, true);
                }
                else
                {
                    File.Delete(oldPath);
                }
            }
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }


        public void PlacePathToBuffer(string path, bool removeOriginal)
        {
            Buffer.Path = path;
            Buffer.RemoveOriginal = removeOriginal;
        }


        public void DeleteFile(string path)
        {
            if (IsDirectory(path))
            {
                Directory.Delete(path, true);
            }
            else
            {
                File.Delete(path);
            }
        }

        public static bool IsDirectory(string path)
        {
            var attr = File.GetAttributes(path);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                return true;
            else
                MessageBox.Show("Its a file");
                return false;
        }

        public void CreateFile(string name)
        {
            var path = (Path.Combine(CurrentDirectory.FullName, name));
            if (File.Exists(path))
            {
                throw new Exception("Файл с таким названием уже существует)))");
            }
            File.Create(path);
        }


        public void RenameFile(string name, string oldName)
        {
            if (name.Equals(oldName))
            {
                return;
            }
            if (File.Exists(Path.Combine(CurrentDirectory.FullName, name)))
            {
                throw new Exception("Файл с таким названием уже существует)))");
            }

            var oldPath = Path.Combine(CurrentDirectory.FullName, oldName);
            var newPath = Path.Combine(CurrentDirectory.FullName, name);
            File.Move(oldPath, newPath);
        }
    }
}
