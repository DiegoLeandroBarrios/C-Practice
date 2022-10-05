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

namespace TpLab2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (SqlConnection conection = new SqlConnection()) 
            {
                conection.ConnectionString = getConnectionString();
                conection.Open();
                label3.Text = conection.State.ToString();
            }
        }

        private string getConnectionString() 
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\VisualStudio\repos\TpLab2022\TpLab2022\BasedeDatosUniversidad.mdf; Integrated Security = True;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int comprobarLegajo = Convert.ToInt32(textBox_Legajo.Text);
            int comprobarPassword = Convert.ToInt32(textBox_Password.Text);


            using (SqlConnection conection = new SqlConnection())
            {
                conection.ConnectionString = getConnectionString();
                conection.Open();


                string consultaSql = "SELECT Password FROM Profesor WHERE Legajo=" + comprobarLegajo + "";
                SqlCommand consulta = new SqlCommand(consultaSql,conection);

                using (SqlDataReader reader = consulta.ExecuteReader())
                {
                    while (reader.Read()) 
                    {

                        if(comprobarPassword == Convert.ToInt32(reader["Password"])) 
                        {
                            MessageBox.Show("Bienvenido profesor.");
                        }
                        else
                            MessageBox.Show("No se encontro el profesor");
                    }
                }
            }

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            OpenPersonasDialog();
        }

        private void OpenPersonasDialog() 
        {
            PersonasVer personas = new PersonasVer();
            personas.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
