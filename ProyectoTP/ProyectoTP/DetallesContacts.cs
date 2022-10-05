using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTP
{
    public partial class DetallesContacts : Form
    {
        private Capas _capas;
        private Contacts _contacts;
        public DetallesContacts()
        {
            InitializeComponent();
            _capas = new Capas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
            ((Main)this.Owner).PopulateContacts();
        }

        private void SaveContact() 
        {
            Contacts contact = new Contacts();
            contact.Apellido = textBox_Apellido.Text;
            contact.Nombre = textBox_Name.Text;
            contact.Legajo = textBox_Legajo.Text;

            contact.Id = _contacts != null ? _contacts.Id : 0;

            _capas.SaveContact(contact);


        }

        public void LoadContacts(Contacts contact) 
        {
            _contacts = contact;
            if (contact != null) 
            {
                ClearForm();
                textBox_Apellido.Text = contact.Apellido;
                textBox_Name.Text = contact.Nombre;
                textBox_Legajo.Text = contact.Legajo;
            }
        }
        private void ClearForm()
        {

            textBox_Apellido.Text = string.Empty;
            textBox_Name.Text = string.Empty; ;
            textBox_Legajo.Text = string.Empty; ;

        }

        private void textBox_Apellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
