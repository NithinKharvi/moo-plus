﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Moo.Helpers
{
    class FileHelper
    {
        public static string GetContent(string filepath)
        {
            try 
            {
               return File.ReadAllText(filepath);     
            }
            catch(Exception e)
            {
                //Log exception MooExceptioner.Log(e, dateTime)
                e.ToString();
            }
            return string.Empty;   
        }
        public static string GetContent(string filter, out string filepath, out string filename)
        {         
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "Open ...";
            openfiledialog.Filter = filter;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openfiledialog.FileName;
                filename = Path.GetFileName(filepath);
                return GetContent(filepath);
            }
            else
            {
                filepath = "";
                filename = "";
                return string.Empty;
            }
            
        }     
        public static bool Save(string filepath, string content)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.Write(content);
                    return true;
                }
            }
            catch (Exception e)
            {
                //Log exception MooExceptioner.Log(e, dateTime)
                e.ToString();
            }
            return false;
        }
        public static bool SaveAs(string content, string filter,out string filepath, out string filename)
        {
           SaveFileDialog savefiledialog = new SaveFileDialog();
           savefiledialog.Title = "Save As ...";
           savefiledialog.Filter = filter;
           if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                filepath = savefiledialog.FileName;
                filename = Path.GetFileName(filepath);
                return Save(filepath, content);
            }
           else
           {
               filepath ="";
               filename ="";
               return false;
           }
        }

        public static List<string> GetFolderFileList(string folder,string filter,SearchOption so)
        {
           List<string> FileList = new List<string>();
           try
           {
                DirectoryInfo di = new DirectoryInfo(folder);
                FileInfo[] files = di.GetFiles(filter, so);
                foreach (FileInfo fi in files)
                {
                    FileList.Add(fi.FullName);
                }
            }
            catch (Exception e)
            {
                //Log exception MooExceptioner.Log(e, dateTime)
                e.ToString();
            }
            return FileList;
        }
        public static void CopyFolder(string from , string to)
        {
            try
            {
                DirectoryInfo source = new DirectoryInfo(from);
                DirectoryInfo destination = new DirectoryInfo(to);
                if (!destination.Exists) 
                    destination.Create();
                FileInfo[] Files = source.GetFiles();
                foreach(FileInfo fi in Files)
                {
                   fi.CopyTo(Path.Combine(destination.FullName,fi.Name),false);
                }
                // for subfolders
                DirectoryInfo[] folders = source.GetDirectories();
                foreach (DirectoryInfo folder in folders)
                {
                    //construct new destination 
                    string newdestination = Path.Combine(destination.FullName, folder.Name);
                    //recursive CopyFolder()
                    CopyFolder(folder.FullName,newdestination);
                }
            }
            catch (Exception e)
            {
                //Log exception MooExceptioner.Log(e, dateTime)
                e.ToString();
            }
        }
        
    }
}
