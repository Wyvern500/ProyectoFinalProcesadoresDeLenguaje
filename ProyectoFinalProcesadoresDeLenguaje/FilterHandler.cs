using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProcesadoresDeLenguaje
{
    internal class FilterHandler
    {

        List<string> extensions;
        List<string> forbiddenStarts;
        List<string> onlyExtensions;

        public FilterHandler() 
        { 
            extensions = new List<string>();
            forbiddenStarts = new List<string>();
            onlyExtensions = new List<string>();
        }

        public void process(string data)
        {
            extensions.Clear();
            forbiddenStarts.Clear();
            onlyExtensions.Clear();
            string[] spData = data.Split("/");
            foreach (string commandData in spData)
            {
                if (commandData == String.Empty) continue;
                processCommand(commandData.Replace(System.Environment.NewLine, 
                    string.Empty));
            }
        }

        public void processCommand(string data)
        {
            Debug.WriteLine("Data: " + data);
            string[] spData = data.Split(":");
            string command = spData[0];
            string parameters = spData[1];
            string[] spParameters = parameters.Contains(",") ? parameters.Split(",")
                : new string[] { spData[1] };
            switch(command)
            {
                case "e":
                    foreach (string param in spParameters)
                    {
                        extensions.Add("." + param);
                    }
                    break;
                case "fs":
                    foreach (string param in spParameters)
                    {
                        forbiddenStarts.Add(param);
                    }
                    break;
                case "oe":
                    foreach (string param in spParameters)
                    {
                        onlyExtensions.Add("." + param);
                    }
                    break;
            }
        }

        public void printData()
        {
            String extensionsString = "";
            foreach (string ext in extensions)
            {
                extensionsString += ext + ", ";
            }
            String forbiddenStartString = "";
            foreach (string fs in forbiddenStarts)
            {
                forbiddenStartString += fs + ", ";
            }
            String onlyExtensionsString = "";
            foreach (string oe in onlyExtensions)
            {
                onlyExtensionsString += oe + ", ";
            }
            Debug.WriteLine("Extensions: " + extensionsString + " ForbiddenStarts: "
                + forbiddenStartString + " onlyExtensions: " + onlyExtensionsString);
        }

        public void addExtension(string ext)
        {
            extensions.Add(ext);
        }

        public void addforbiddenStart(string forbiddenStart)
        {
            forbiddenStarts.Add(forbiddenStart);
        }

        public void addOnlyExtension(string onlyExtension)
        {
            onlyExtensions.Add(onlyExtension);
        }

        public List<String> Extensions { get { return extensions; } }

        public List<String> ForbiddenStarts { get { return forbiddenStarts; } }

        public List<String> OnlyExtensions { get { return onlyExtensions; } }

    }
}
