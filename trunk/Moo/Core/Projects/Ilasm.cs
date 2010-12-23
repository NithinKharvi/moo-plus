﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Ilasm: Project
    {
        public Ilasm() : base()
        {
            this.type = PType.Ilasm;
        }
        public Ilasm(string filepath) : base(filepath)
        {
            this.type = PType.Ilasm;
        }


        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Ilasm");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Ilasm");
        }
        public override List<string> GetKeywords()
        {
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
