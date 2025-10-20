using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PilaApp.Clases;

namespace PilaApp
{
    public partial class PilaApp : Form
    {
        private Stack<Empleado> pilaEmpleados = new Stack<Empleado>();
        public PilaApp()
        {
            InitializeComponent();
        }

        private void ActualizarListBox()
        {
            lstPila.Items.Clear();

           
            foreach (Empleado emp in pilaEmpleados.ToArray())
            {
                lstPila.Items.Add($"{emp.NombreCompleto}, Cargo: {emp.Cargo}, Salario: {emp.Salario:C}");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void PilaApp_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblError.Text = "Error:"; 

            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbApellido.Text) ||
                string.IsNullOrWhiteSpace(tbCargos.Text) ||
                string.IsNullOrWhiteSpace(tbSalario.Text))
            {
                lblError.Text = "Error: Todos los campos son obligatorios.";
                return;
            }

            if (!decimal.TryParse(tbSalario.Text, out decimal salario))
            {
                lblError.Text = "Error: El salario debe ser un nuemrro válido.";
                return;
            }

            Empleado nuevoEmpleado = new Empleado
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Cargo = tbCargos.Text,
                Salario = salario
            };

            pilaEmpleados.Push(nuevoEmpleado);

            ActualizarListBox();

            tbNombre.Clear();
            tbApellido.Clear();
            tbCargos.Clear();
            tbSalario.Clear();
            tbNombre.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblError.Text = "Error:"; 

            if (pilaEmpleados.Count == 0)
            {
                lblError.Text = "Error: La pila está vacía, no se puede eliminar.";
                return;
            }

            Empleado empleadoEliminado = pilaEmpleados.Pop();
            lblError.Text = $"Se eliminó a: {empleadoEliminado.NombreCompleto}";

            ActualizarListBox();
        }

        private void btnTope_Click(object sender, EventArgs e)
        {
            lblError.Text = "Error:"; 

            if (pilaEmpleados.Count == 0)
            {
                lblError.Text = "Error: La pila está vacía.";
                return;
            }

            Empleado empleadoEnTope = pilaEmpleados.Peek();

            lblError.Text = $"Elemento en el tope: {empleadoEnTope.NombreCompleto}";
        }
    }
}
