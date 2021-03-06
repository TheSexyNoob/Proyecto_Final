﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AdminLogic
    {
        /// <summary>
        /// This helps to check if all data is correct.
        /// </summary>
        /// <returns>Returns a new Admin.</returns>
        public void CreateAdmin(Admin adminData)
        {
            string AdminName;
            string AdminPassword;
            string AdminFLast;
            string AdminSLast;
            int AdminId = adminData.Id;
            int AdminPhone = adminData.Phone;
            string AdminMail;

            #region Set data.
            if (ValidateString(adminData.Password))
            {
                AdminPassword = adminData.Password;
            }
            else
            {
                throw new ArgumentException("Password cannot be empty.");
            }

            if (ValidateString(adminData.Name))
            {
                AdminName = adminData.Name;
            }
            else
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            if (ValidateString(adminData.LastName))
            {
                AdminFLast = adminData.LastName;
            }
            else
            {
                throw new ArgumentException("The first Lastname cannot be empty.");
            }

            if (ValidateString(adminData.SecondLastName))
            {
                AdminSLast = adminData.SecondLastName;
            }
            else
            {
                throw new ArgumentException("The second Lastname cannot be empty.");
            }

            if (ValidateString(adminData.SecondLastName))
            {
                AdminMail = adminData.Mail;
            }
            else
            {
                throw new ArgumentException("Mail cannot be empty.");
            }
            #endregion

            Admin NewAdmin = new Admin(0, AdminPassword, AdminName, AdminFLast, AdminSLast, AdminId, AdminPhone, AdminMail);

            //Crear metodo para insertarlo a la base de datos.

            NewAdmin = null;
        }

        #region Validators
        /// <summary>
        /// Check that the string is not null or just a white space.
        /// </summary>
        /// <param data="data">Receives an admin name.</param>
        /// <returns>Returns a boolean if Name is correct</returns>
        public bool ValidateString(string data)
        {
            bool result;
            if (string.IsNullOrEmpty(data) && string.IsNullOrWhiteSpace(data))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
        #endregion

    }//End Class
}
