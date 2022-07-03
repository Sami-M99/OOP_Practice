using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trying
{
    class Files_and_Folders
    {
        
        // Make one Folder
        public void CreatFolder(string path)
        {
            // if this folder already maked it doesn't work
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        // Make a folders at one time
        public void CreatFolders(string[] paths)
        {
            foreach (string item in paths)
            {
                CreatFolder(item);
            }
        }

        public void CreatFile(string nameFile)
        {
            // if this file already maked it doesn't work
            // if we don't write this it will make it agian
            // it means if we have data inside this file it will siled and make a new file of same name
            if (!File.Exists(nameFile))
                File.Create(nameFile).Close();
        }

        // Make a file with datalines
        public void CreatDataFile(string path, string[] lines)
        {
            // Write data inside file
            StreamWriter WriteData = new StreamWriter(path);

            foreach (string line in lines)
                WriteData.WriteLine(line);
            WriteData.Close();
        }

        // Make a files with a defrant datalines
        public void CreatDatasFiles(string[] paths, string[][] lines)
        {
            for (int i = 0; i < paths.Count(); i++)
            {
                CreatDataFile(paths[i], lines[i]);
            }

        }
    }
}
