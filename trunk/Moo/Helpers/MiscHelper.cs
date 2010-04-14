﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moo.Core;

namespace Moo.Helpers
{
    class MiscHelper
    {
        public static ProjectCategory GetProjectType(string type)
        {
            ProjectCategory pcat = ProjectCategory.Unmanaged;
            switch (type)
            {       
                case "C Sharp":
                    pcat = ProjectCategory.Csharp;
                    break;
                case "Hydro":
                    pcat = ProjectCategory.Hydro;
                    break;
                case "Ilasm":
                    pcat = ProjectCategory.Ilasm;
                    break;
                case "Website":
                    pcat = ProjectCategory.Website;
                    break;
                case "Unmanaged":
                    pcat = ProjectCategory.Unmanaged;
                    break;
            }
            return pcat;
        }
        public static string GetFileExtention(string type)
        {
            string fileextention = ".txt";
            switch (type)
            {
                case "C#":
                    fileextention = ".cs";
                    break;
                case "C++":
                    fileextention = ".cpp";
                    break;
                case "Php":
                    fileextention = ".php";
                    break;
                case "Html":
                    fileextention = ".html";
                    break;
            }
            return fileextention;
        }
        public static string GetLanguage(string FileExtention)
        {
            string language = "none";
            switch (FileExtention)
            {
                case ".cs":
                    language = "cs";
                    break;
                case ".cpp":
                    language = "cpp";
                    break;
                case ".h":
                    language = "cpp";
                    break;
                case ".php":
                    language = "php";
                    break;
                case ".html":
                    language = "html";
                    break;
            }
            return language;
        }


    }
}