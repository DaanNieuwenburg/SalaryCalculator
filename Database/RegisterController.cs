using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Salary_Calculator.Database
{
    
    class RegisterController
    {
        public bool validated { get; set; }
        protected MySqlConnection conn;
        public RegisterController()
        {
            conn = new MySqlConnection("Server=localhost;Database=dbsalariscalculator;Uid=Daan;Pwd=1234");
            validated = false;
        }
        public void Addaccount(Account account)
        {
            try
            {
                conn.Open();
                //trans = conn.BeginTransaction();
                string insertString = @"INSERT INTO dbsalariscalculator.register (`idRegister`,`Voornaam`, `achternaam`, `username`, `password`, `bedrijf`) VALUES ((select count(*) + 1), @Voornaam, @achternaam, @Username, @Password, @Bedrijf)";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);

                // MySqlParameter ID_Param = new MySqlParameter("@idReg", MySqlDbType.Int32);
                MySqlParameter VN_Param = new MySqlParameter("@Voornaam", MySqlDbType.VarChar);
                MySqlParameter AN_Param = new MySqlParameter("@achternaam", MySqlDbType.VarChar);
                MySqlParameter UN_Param = new MySqlParameter("@Username", MySqlDbType.VarChar);
                MySqlParameter PW_Param = new MySqlParameter("@Password", MySqlDbType.VarChar);
                MySqlParameter BD_Param = new MySqlParameter("@Bedrijf", MySqlDbType.VarChar);

                /*             MySqlCommand cmd2 = new MySqlCommand(insertString, conn);
                            ID_Param.Value = @"Select Count(idRegister) From register" + 1;
                             cmd2.Parameters.Add(ID_Param);
                             cmd2.Prepare();
                             cmd2.ExecuteNonQuery();*/

                VN_Param.Value = account.Voornaam;
                AN_Param.Value = account.Achternaam;
                UN_Param.Value = account.Username;
                PW_Param.Value = account.Password;
                BD_Param.Value = account.Bedrijf;


                //cmd.Parameters.Add(ID_Param);
                cmd.Parameters.Add(VN_Param);
                cmd.Parameters.Add(AN_Param);
                cmd.Parameters.Add(UN_Param);
                cmd.Parameters.Add(PW_Param);
                cmd.Parameters.Add(BD_Param);

                cmd.Prepare();

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //trans.Rollback();   //FIXME: This will be a problem!
                Console.WriteLine("Account niet aangemaakt in reg: " + ex);
            }
            try
            {
                
                
                string loginString = @"INSERT INTO dbsalariscalculator.login (`idlogin`,`Username` , `Password`) VALUES ((select count(*) + 1),@username, @password)";

                MySqlCommand cmdlogin = new MySqlCommand(loginString, conn);
                MySqlParameter UN_Param = new MySqlParameter("@username", MySqlDbType.VarChar);
                MySqlParameter PW_Param = new MySqlParameter("@password", MySqlDbType.VarChar);
                //MySqlParameter ID_Param = new MySqlParameter("@idlogin" , MySqlDbType.Int32);

                //ID_Param.Value = @"Select count(*) + 1 from login";
                UN_Param.Value = account.Username;
                PW_Param.Value = account.Password;

                //cmdlogin.Parameters.Add(ID_Param);
                cmdlogin.Parameters.Add(UN_Param);
                cmdlogin.Parameters.Add(PW_Param);

                cmdlogin.Prepare();

                cmdlogin.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //trans.Rollback();   //FIXME: This will be a problem!
                Console.WriteLine("Account niet aangemaakt in login: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void CheckAccount(string user, string pass)
        {
            try
            {
                conn.Open();
                //trans = conn.BeginTransaction();
                string insertString = @"Select * From login where @Username = username and @Password = password";

                MySqlCommand cmd = new MySqlCommand(insertString, conn);

                // MySqlParameter ID_Param = new MySqlParameter("@idReg", MySqlDbType.Int32);
                MySqlParameter UN_Param = new MySqlParameter("@Username", MySqlDbType.VarChar);
                MySqlParameter PW_Param = new MySqlParameter("@Password", MySqlDbType.VarChar);

                /*             MySqlCommand cmd2 = new MySqlCommand(insertString, conn);
                            ID_Param.Value = @"Select Count(idRegister) From register" + 1;
                             cmd2.Parameters.Add(ID_Param);
                             cmd2.Prepare();
                             cmd2.ExecuteNonQuery();*/

                UN_Param.Value = user;
                PW_Param.Value = pass;


                //cmd.Parameters.Add(ID_Param);
                cmd.Parameters.Add(UN_Param);
                cmd.Parameters.Add(PW_Param);

                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);

                //cmd.Prepare();

                //cmd.ExecuteNonQuery();

                if (dt.Rows.Count > 0)
                {
                    validated = true;
                }
                else
                {
                    validated = false;
                }
            }

            catch (Exception ex)
            {
                validated = false;
                //trans.Rollback();   //FIXME: This will be a problem!
                Console.WriteLine("login failed: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
