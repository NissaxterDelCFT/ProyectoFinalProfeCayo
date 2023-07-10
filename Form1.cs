using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace holasisi
{
    public partial class Form1 : Form
    {
        static string cadena = "Data Source=.;Initial Catalog=systemcft;Integrated Security=True";
        SqlConnection cn = new SqlConnection(cadena);
        SqlCommand com = new SqlCommand();
        SqlDataReader datos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            com.Connection = cn;
            com.CommandType = CommandType.Text;
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            com.CommandText = "select nombre from Estudiante where id='" + this.textBox1.Text + "'";
            datos=com.ExecuteReader();
            if (datos.HasRows == true) {
                while (datos.Read()){
                    this.listBox1.Items.Add(datos.GetString(0));
                }
            }
            else
            {
                this.listBox1.Items.Add("Sin resultados");

            }
            datos.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
