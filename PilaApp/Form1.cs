﻿using System;
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
            
        }
    }
}
