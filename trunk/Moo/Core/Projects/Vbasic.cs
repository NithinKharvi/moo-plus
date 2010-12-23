﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Vbasic : Project
    {
        public Vbasic() : base()
        {
            this.type = PType.Vbasic;
        }
        public Vbasic(string filepath) : base(filepath)
        {
            this.type = PType.Vbasic;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Vbasic");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Vbasic");
        }
        public override List<string> GetKeywords()
        {
            return base.GetKeywords("Vbasic");
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
