using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalExplorer
{
    internal class SharedBuffer
    {
        private static SharedBuffer? instance;

        private SharedBuffer(string path, bool removeOriginal)
        {
            Path = path;
            RemoveOriginal = removeOriginal;
        }

        public string Path { get; set; }
        public bool RemoveOriginal { get; set; }

        public static SharedBuffer GetInstance()
        {
            if (instance == null)
                instance = new SharedBuffer(string.Empty, false);
            return instance;
        }
    }
}
