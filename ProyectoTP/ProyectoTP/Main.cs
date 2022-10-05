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
    public partial class Main : Form
    {
        private Capas _capas;
        public Main()
        {
            InitializeComponent();
            _capas = new Capas();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            OpenDetallesContactsDialog();
        }
        private void OpenDetallesContactsDialog() 
        {

            DetallesContacts detallescontacts = new DetallesContacts();
            detallescontacts.ShowDialog(this);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        public void PopulateContacts(string searchText = null)//parametro opcional 
        {
            List<Contacts> contacts = _capas.GetContacts(searchText);
            gridConcts.DataSource = contacts;
        }

        private void gridConcts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridConcts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "EDITAR")
            {
                DetallesContacts detallescontacts = new DetallesContacts();
                detallescontacts.LoadContacts(new Contacts
                {
                    Id = int.Parse((gridConcts.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    Apellido = gridConcts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Nombre = gridConcts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Legajo = gridConcts.Rows[e.RowIndex].Cells[3].Value.ToString()
                });
                detallescontacts.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "ELIMINAR")
            {
                DeleteContact(int.Parse((gridConcts.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                PopulateContacts();
            }
        }
        private void DeleteContact(int id)
        {
            _capas.DeleteContacts(id);
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            PopulateContacts(txt_search.Text);
            txt_search.Text = string.Empty;
        }
    }
}
