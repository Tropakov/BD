using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KarpushinDZ
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            getinfo();
        }

        private void getinfo()
        {
            string query = "SELECT st_fio, dt_receipt, id_faculty, id_prof, id_group  FROM students";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                conn.Close();
            }
            catch(Exception ex){
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                 }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
