using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProcesadoresDeLenguaje
{
    internal class FileUtils
    {
        public static List<FileInfo> getFilesOnDir(DirectoryInfo rootDir)
        {
            List<FileInfo> files = new List<FileInfo>();
            List<DirectoryInfo> dirsToCheck = new List<DirectoryInfo>();
            DirectoryInfo[] childDirs = rootDir.GetDirectories();
            FileInfo[] childFiles = rootDir.GetFiles();
            foreach (DirectoryInfo dir in childDirs)
            {
                dirsToCheck.Add(dir);
            }
            foreach (FileInfo file in childFiles)
            {
                files.Add(file);
            }
            do
            {
                List<DirectoryInfo> toAdd = new List<DirectoryInfo>();
                foreach (DirectoryInfo dir in dirsToCheck)
                {
                    childDirs = dir.GetDirectories();
                    childFiles = dir.GetFiles();
                    foreach (DirectoryInfo subDir in childDirs)
                    {
                        toAdd.Add(subDir);
                    }
                    foreach (FileInfo subFile in childFiles)
                    {
                        files.Add(subFile);
                    }
                }
                dirsToCheck.Clear();
                dirsToCheck.AddRange(toAdd);
            } while (dirsToCheck.Count != 0);
            return files;
        }
    }
}
