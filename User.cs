using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    internal class User
    {
        private User(string _username)
        {
            this._username = _username;
        }
        private string _username;
        private string _password;

        public string UserName
        {
            get { return this._username; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 5 && value.Length < 26)
                    this._username = value;
            }
        }
         public string Password
        {
            get { return this._password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 8 && value.Length < 26)
                    this._username = value;
            }
        }

            static bool CheckString(string str)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    hasUpper = true;
                else if (char.IsLower(str[i]))
                    hasLower = true;
                else if (char.IsDigit(str[i]))
                    hasDigit = true;

                if (hasDigit && hasUpper && hasLower)
                    return true;
            }
            return false;
                    

             




            }
    }
}
        
            
            
            
        

    


