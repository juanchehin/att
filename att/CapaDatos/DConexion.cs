using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace att.CapaDatos
{
    public class DConexion
    {
        MySqlConnection Con = new MySqlConnection("datasource =localhost;username = root;password = '';database=att");

        public DConexion()
        {
            // AbrirConexion();
        }
        public MySqlConnection AbrirConexion()
        {
            try
            {
                Con.Open();
                return Con;
            }
            catch
            {
                return Con;
            }
        }

        public MySqlConnection CerrarConexion()
        {
            try
            {
                Con.Close();
                return Con;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return Con;
            }
        }
    }
}
