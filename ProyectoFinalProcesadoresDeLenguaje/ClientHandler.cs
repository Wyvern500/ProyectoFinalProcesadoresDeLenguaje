using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProcesadoresDeLenguaje
{
    internal class ClientHandler
    {

        Form1 form;
        FilterHandler filterHandler;
        DirectoryInfo selectedPath;
        int totalLines;
        int totalFiles;
        int acceptedFiles;
        int ignoredFiles;
        float currentFile;
        long totalSize;
        long totalFileSize;

        Label progressLabel;

        public ClientHandler(Label progressLabel, Form1 form) 
        {
            filterHandler = new FilterHandler();
            this.progressLabel = progressLabel;
            this.form = form;
        }

        private void cleanVariables()
        {
            totalLines = 0;
            totalFiles = 0;
            acceptedFiles = 0;
            ignoredFiles = 0;
            currentFile = 0;
            totalSize = 0;
            totalFileSize = 0;
        }

        public int getLines()
        {
            cleanVariables();
            List<string> fs = filterHandler.ForbiddenStarts;
            List<FileInfo> files = applyExtensionFilter();
            totalFiles = files.Count;
            foreach (FileInfo file in files)
            {
                // Me quede haciendo que se pasaran datos entre el thread background
                // y el thread cliente
                currentFile++;
                setText(progressLabel, "Progress: " + (100 * (currentFile + 0.0f) / 
                    totalFiles) + "%");
                totalSize += file.Length;
                string[] data = File.ReadAllLines(file.FullName);
                foreach (string line in data) 
                {
                    bool canAdd = true;
                    foreach (string fsfilter in fs)
                    {
                        if(line.StartsWith(fsfilter))
                        {
                            canAdd = false;
                            break;
                        }
                        if(fsfilter == "{empty}")
                        {
                            if(line == String.Empty)
                            {
                                canAdd = false;
                                break;
                            }
                        }
                    }
                    if (canAdd)
                    {
                        totalFileSize += line.Length * sizeof(Char);
                        totalLines++;
                    }
                }
            }
            return totalLines;
        }

        public List<FileInfo> applyExtensionFilter()
        {
            List<FileInfo> files = FileUtils.getFilesOnDir(selectedPath);
            List<FileInfo> newFiles = new List<FileInfo>();

            List<string> forbiddenExt = filterHandler.Extensions;
            List<string> onlyExtensions = filterHandler.OnlyExtensions;

            string text = "";
            foreach (string ext in onlyExtensions)
            {
                text += ext + ", ";
            }
            Debug.WriteLine(text);

            if (onlyExtensions.Count == 0)
            {
                foreach (FileInfo file in files)
                {
                    if (!forbiddenExt.Contains(file.Extension))
                    {
                        newFiles.Add(file);
                    }
                    else
                    {
                        ignoredFiles++;
                        continue;
                    }
                }
            } else
            {
                foreach (FileInfo file in files)
                {
                    if (file.Name.Contains("gd"))
                    {
                        Debug.WriteLine("Out Adding: " + file.Extension);
                    }
                    if (onlyExtensions.Contains(file.Extension))
                    {
                        newFiles.Add(file);
                        Debug.WriteLine("Adding: " + file.Extension);
                    }
                    else
                    {
                        ignoredFiles++;
                        continue;
                    }
                }
            }
            return newFiles;
        }

        public void startWork()
        {
            filterHandler.process(form.TextArea.Text);
            if (selectedPath != null)
            {
                setText(form.Label1, "Lines: " + getLines().ToString());
                setText(form.Label2, "Size: " + totalSize + " bytes");
                setText(form.Label5, "Files: " + totalFiles);
                setText(form.Label7, "Ignored Files: " + ignoredFiles);
            }
        }

        private void setText(Label label, string text)
        {
            label.Invoke(new Action(() => label.Text = text));
        }

        public FilterHandler FilterHandler { get { return filterHandler; } }

        public DirectoryInfo SelectedPath
        {
            get { return selectedPath; }
            set { selectedPath = value; }
        }

        public int TotalLines
        {
            get { return totalLines; }
        }

        public long TotalSize
        {
            get { return totalSize; }
        }

        public long TotalFileSize
        {
            get { return totalFileSize; }
        }

        public int TotalFiles
        {
            get { return totalFiles; }
        }

        public int IgnoredFiles
        {
            get { return ignoredFiles; }
        }
    }
}
