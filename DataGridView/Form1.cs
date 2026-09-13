using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Roríguez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);
            listaPersonas.Add(miColaborador1);
            dgvEmpleados.DataSource = listaPersonas;
        }
        
        private void tsbBoton_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text == "")
            {
                errorProvider1.SetError(txtIdEmpleado, "Ingrese un ID");
                txtIdEmpleado.Focus();
                return;
            }
            else
            errorProvider1.SetError(txtIdEmpleado, "");
            

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese los nombres del Colaborador");
                txtNombre.Focus();
                return;
            }
            else
                errorProvider1.SetError(txtNombre, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese los apellidos del Colaborador");
                txtApellidos.Focus();
                return;
            }
            else
                errorProvider1.SetError(txtApellidos, "");

            if (Utilidades.EsCorreoValido(txtEmail.Text)== false)
            {
                errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                txtEmail.Focus();
                return;
            }
            else
                errorProvider1.SetError(txtEmail, "");

            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
                errorProvider1.SetError(txtSalario, "");

            Persona colaborador1 = new Persona();
            colaborador1.Id = int.Parse(txtIdEmpleado.Text);
            colaborador1.Nombres = txtNombre.Text;
            colaborador1.Apellidos = txtApellidos.Text;
            colaborador1.Correo = txtEmail.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNacim.Value;
            listaPersonas.Add(colaborador1);
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = listaPersonas;

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.Rows.Clear();
        }
    }
}
