using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpLab2022
{

    public partial class PersonasVer : Form
    {
        private CaptarPersonas _captarpersonas;

        public PersonasVer()
        {
            InitializeComponent();
            _captarpersonas = new CaptarPersonas();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save1_Click(object sender, EventArgs e)
        {
            Personas persona = new Personas();
            persona.Apellido = textBox_apellido.Text;
            persona.Nombre = textBox_name.Text;
            persona.Legajo = Convert.ToInt32(textBox_legajo.Text);
            persona.Password = Convert.ToInt32(textBox_password.Text);


        }
    }
}
