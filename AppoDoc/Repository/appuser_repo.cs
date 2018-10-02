using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppoDoc.Models;
using MySql.Data.MySqlClient;

namespace AppoDoc.Repository
{
    public class appuser_repo
    {
        public  bool  New_registration(MobUser mob) {

            mySqlConnection db = new mySqlConnection();
            
            bool result = db.ExecuteQuery("INSERT INTO tbl_app_users(au_firstname) VALUES ('"+ mob.au_firstname +"')");
            return result;
        }

        public dynamic Get_All_Mob_Users() {

            mySqlConnection db = new mySqlConnection();
            var dt =  db.SelectQuery("SELECT * FROM tbl_app_users");
            return dt;
        }

    }
}