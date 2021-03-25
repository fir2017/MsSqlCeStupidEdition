using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlServerCe;


namespace dbusers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsdf0DataSet.tabelutilizatori' table. You can move, or remove it, as needed.
           
        }
        public SqlCeConnection cnn;
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
           
            SqlCeEngine engine = new SqlCeEngine("Data Source=dbsdf0.sdf");
             
            
            SqlCeConnection cnn;
           connectionString = @"Data Source=dbsdf0.sdf";
           
               cnn = new SqlCeConnection(connectionString);
               cnn.Open();
               MessageBox.Show("Connection open!");
           
               SqlCeCommand cmd = new SqlCeCommand(" SELECT idutilizator, nume, prenume, datanasterii, datadecesului, numedeutilizator, parolautilizator  FROM tabelutilizatori", cnn);
               SqlCeDataReader reader = cmd.ExecuteReader();

              DataTable td = new DataTable("tabelutilizatori");
            td = reader.GetSchemaTable();
            MessageBox.Show(td.Columns[0].ToString());
                   
                   //this.Text = reader.GetValue(0).ToString();
            //rez = -1 error ?
                   //MessageBox.Show(this.Text = reader.GetValue(0).ToString());
                   MessageBox.Show(cmd.ExecuteNonQuery().ToString());

               cnn.Close();
               MessageBox.Show("Connection close!");

           
            
        }
        
        

       
    }
}
