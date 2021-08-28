using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaFormularios
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                validarDatos();
            }
        }

        private void tbMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                validarDatos();
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                validarDatos();
            }
        }

        private void validarDatos()
        {
            if (tbFirstName.Text == "" || tbMiddleName.Text == "" || tbLastName.Text == "")
            {
                MessageBox.Show("Ningún dato puede quedar vacío", "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                dgInformation.Rows.Add(tbFirstName.Text, tbMiddleName.Text, tbLastName.Text);
                tbFirstName.Text = "";
                tbMiddleName.Text = "";
                tbLastName.Text = "";

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgInformation.Rows.Clear();
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            foreach(DataGridViewRow row in dgInformation.Rows)
            {
                for (int counter = 0; counter < dgInformation.Rows.Count; counter++)
                {
                    if (tbSearch.Text == "") 
                    {
                        dgInformation.Rows[counter].Visible = true;

                    }
                    else if (dgInformation.Rows[counter].Cells[0].Value.ToString().Contains(search))
                    {
                        dgInformation.Rows[counter].Visible = true;
                    }
                    else if (dgInformation.Rows[counter].Cells[1].Value.ToString().Contains(search))
                    {
                        dgInformation.Rows[counter].Visible = true;
                    }
                    else if (dgInformation.Rows[counter].Cells[2].Value.ToString().Contains(search)) 
                    {
                        dgInformation.Rows[counter].Visible = true;
                    }
                    else 
                    {
                        dgInformation.Rows[counter].Visible = false;
                    }
                }
            }
            
        }



    }
}
