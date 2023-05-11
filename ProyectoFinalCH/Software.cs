using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCH
{
    internal class Software
    {
        #region Attributes
        private string software_id = string.Empty;
        private string software_name = string.Empty;

        #endregion

        #region Set/Get

        public string SoftwareID { get; set; }
        public string SoftwareName { get; set; }

        #endregion

        #region Builder

        public Software (string software_id, string software_name)
        {
            SoftwareID = software_id;
            SoftwareName = software_name;
        }
        #endregion

    }
}
