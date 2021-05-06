using POSSawah;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSawah
{
    class Users
    {
        public static BindingList<Users> users;
        public static Int64 Available_ID;
        private string name;
        private string username;
        private string password;
        private string email;
        private bool admin;
        private string mobile;
        private string address;




        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Email
        {
           get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public bool Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;    
            }
        }
        public Users(string Name,string UserName,string Password,string Email,bool Admin,string Mobile,string Address)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
            this.Admin = Admin;
            this.Mobile = Mobile;
            this.Address = Address;
        }
        public Users(string Name ,string UserName,string Password,bool Admin , string Mobile)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.Password = Password;
            this.Admin = Admin;
            this.Mobile = Mobile;
        }
        public Users (string Name,string UserName,string Password ,bool Admin)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.Password = Password;
            this.Admin = Admin;
        }
        public static Int64 SelectID(string UserName)
        {
            string[] columnsName = { "ID" };
            string[] ConditionName = { "UserName" };
            string[] ConditionValue = { UserName };
            try
            {
                OracleDataReader oracleDataReader = DBConnection.selectRows("Users", columnsName, ConditionName, ConditionValue);
                if (oracleDataReader.Read())
                {
                    return Int64.Parse(oracleDataReader.GetOracleValue(0).ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return -1;
        }
        public static void Insert(string Name,string UserName,string Password,string Email,bool Admin,string Mobile,string Address)
        {
            Int64 ID = Users.SelectID(UserName);

            if (ID != -1)
            {
                throw new Exception("يوجد مستخدم بهذا الإسم");
            }
            if (char.IsNumber(UserName[0]) || char.IsSymbol(UserName[0]))
            {
                throw new Exception("يرجي كتابة الاسم بشكل صحيح");
            }

            Available_ID = DBConnection.getIDCounter("Users");
            string[] names = { "ID", "Name", "UserName", "Password", "Email", "Admin", "Mobile","Address" };
            string[] values = { Users.Available_ID.ToString(), Name, UserName,Password,Email,Admin.ToString(),Mobile,Address};
            try
            {
                DBConnection.insertRow("Users", names, values);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            DBConnection.setIDCounter("Users", Users.Available_ID + 1);
        }
        public static void Delete(string UserName)
        {
            string[] conditionName = { "UserName" };
            string[] conditionValue = { UserName };
            try
            {
                DBConnection.deleteRows("Users", conditionName, conditionValue);
            }
            catch (Exception)
            {
                throw new Exception("لا يوجد مستخدم بهذا الاسم");
            }
        }

    }
}
