using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCH
{
    internal class Agent
    {
        #region Attributes

        private int agent_id = 0;
        private int assigned_software_id = 0;
        private string name = string.Empty;
        private string surname = string.Empty;
        private string username = string.Empty;
        private string password = string.Empty;
        private string email = string.Empty;

        #endregion

        #region Set/Get

        public int AgentID { get; set; }
        public int AssignedSoftwareID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }

        #endregion

        #region Builder

        public Agent(int agent_id,int assigned_software_id, string name, string surname, string username, string password, string email)
        {
            AgentID = agent_id;
            AssignedSoftwareID = assigned_software_id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Email = email;
        }
        #endregion
    }
}
