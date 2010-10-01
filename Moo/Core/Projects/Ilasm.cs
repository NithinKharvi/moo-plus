﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    class Ilasm: Project
    {
        public Ilasm() : base()
        {
            //nothing to do
        }
        public Ilasm(string filepath) : base(filepath)
        {
            //just initialise with the base constructor
        }


        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Ilasm");
            base.CopyTemplate();
        }
        public override List<string> GetFiles()
        {
            base.GetFiles();
            return base.GetFiles("Ilasm");
        }
        public override List<string> GetKeywords()
        {
            base.GetKeywords();
            return base.GetKeywords("Ilasm");
        }

        public override void Build()
        {

        }
        public override void Run()
        {

        }
        public override void GetBuildTool()
        {

        }
        public override void GetCmdArgs()
        {

        }

        #endregion

    }
}