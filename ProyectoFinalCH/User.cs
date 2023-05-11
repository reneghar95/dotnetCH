using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalCH
{
    internal class User
    {
        #region Attributes

        private int user_id = 0;
        private string name = string.Empty;
        private string surname = string.Empty;
        private string username = string.Empty;
        private string password = string.Empty;
        private string email = string.Empty;

        #endregion

        #region Set/Get

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set;}
        public string Username { get; set;}

        public string Password { get; set;}
        public string Email { get; set;}

        #endregion

        #region Builder

        public User (int user_id, string name, string surname, string  username, string password, string email)
        {
            UserID = user_id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Email = email;
        }
        #endregion

    }
}
