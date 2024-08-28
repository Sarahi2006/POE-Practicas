using StudenSystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3Poe.Forms
{
    public partial class StudenSystem : Form
    {
        public StudenSystem()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Caeer caeer = new Caeer();
            Student student = new Student();

            caeer.Name = txtCarrera.Text;
            student.FirsName = txtNombre.Text;
            student.LastName = txtApellido.Text;
            student.PhoneNumber = txtPhone.Text;
            student.Caeer = caeer;

            RegistroAlumno.Items.Add(student);

        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            if (RegistroAlumno.SelectedItem is Student selectedStudent)
            {
                RegistroAlumno.Items.Remove(selectedStudent);
                MessageBox.Show("Estudiante Eliminado con Exito");
                limpiarCampo();
            }
            else
            {
                MessageBox.Show("No se ah soleccionado un estudiante");
            }
        }

        public void limpiarCampo()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtPhone.Clear();
            txtCarrera.Clear();
            txtNombre.Focus();
        }
    }
}
