using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SDP_Project
{
    class LoginController
    {
        public static bool verifyLogin(String staffid, String password, out Staff staff)
        {
            // SQL 
            string SQL;
            MySqlDataReader myData;
            MySqlCommand cmd;
            Boolean isLoginSuccess = false;
            try
            {
                SQL = "select * from staff where staffID= '" + staffid + "';";
                cmd = new MySqlCommand(SQL, FormContainer.conn);
                myData = cmd.ExecuteReader();
                if (!myData.HasRows)
                {
                    myData.Close();
                    staff = null;
                    return false;
                }
                else
                {
                    while (myData.Read())
                    {
                        using (MD5 md5Hash = MD5.Create())
                        {
                            isLoginSuccess = VerifyMd5Hash(md5Hash, password, myData.GetString(1));
                        }
                    }
                    if (isLoginSuccess == true)
                    {
                        staff = new Staff(myData.GetString(0), myData.GetString(2), myData.GetString(3));
                        myData.Close();
                        return true;
                    }
                    else if (isLoginSuccess == false)
                    {
                        myData.Close();
                        staff = null;
                        return false;
                    }
                    myData.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " : " + ex.Message);
            }
            staff = null;
            return false;
        }




        #region Md5Method
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    #endregion
}
