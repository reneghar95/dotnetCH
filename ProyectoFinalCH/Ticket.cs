using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCH
{
    internal class Ticket
    {
        #region Attributes

        private int ticket_id = 0;
        private string software_name = string.Empty;
        private float software_version = 0;
        private string ticket_title = string.Empty;
        private string ticket_description = string.Empty;
        private string ticket_severity = string.Empty;
        private string ticket_urgency = string.Empty;
        private int user_id = 0;
        private int assigned_agent_id = 0;

        #endregion

        #region Set/Get

        public int TicketId { get; set; }
        public string SoftwareName { get; set; }
        public float SoftwareVersion { get; set; }
        public string TicketTitle { get; set;}
        public string TicketDescription { get; set;}
        public string TicketSeverity { get; set;}
        public string TicketUrgency { get; set;}
        public int UserId { get; set;}
        public int AssignedAgentID { get; set;}


        #endregion

        #region Builder

        public Ticket (int ticket_id, string software_name, float software_version, string ticket_title, string ticket_description, string ticket_severity, string ticket_urgency, int user_id, int assigned_agent_id)
        {
            TicketId = ticket_id;
            SoftwareName = software_name;
            SoftwareVersion = software_version;
            TicketTitle = ticket_title;
            TicketDescription = ticket_description;
            TicketSeverity = ticket_severity;
            TicketUrgency = ticket_urgency;
            UserId = user_id;
            AssignedAgentID = assigned_agent_id;
        }
        #endregion


    }
}
