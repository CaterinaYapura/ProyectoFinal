using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bibliotecadb.vista
{
    public partial class UsuarioNuevo : Form
    {
        private MySqlConnection conexion;

        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private string dni;
        private int activo = 1;

        private bool nband = false;
        private bool aband = false;
        private bool dband = false;
        private bool tband = false;
        private bool dniband = false;


        public UsuarioNuevo()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nband == true && aband == true && dband == true && tband == true && dniband == true)
            {
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                domicilio = txtDomicilio.Text;
                telefono = txtTelefono.Text;
                dni = txtDni.Text;
                string Cadenaconexion = "Server=localhost;Database=dbbiblioteca;User=root;Password=";
                using (MySqlConnection conexion = new MySqlConnection(Cadenaconexion))
                {
                    try
                    {
                        conexion.Open();
                        string consulta = "INSERT INTO lectores (nombre, apellido, domicilio, telefono, estado) VALUES (@nombre, @apellido, @domicilio, @telefono, @estado)";
                
                
                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@nombre", nombre);
                            comando.Parameters.AddWithValue("@apellido", apellido);
                            comando.Parameters.AddWithValue("@domicilio", domicilio);
                            comando.Parameters.AddWithValue("@telefono", telefono);
                            comando.Parameters.AddWithValue("@estado", activo);
                            comando.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar conectar con la base de datos" + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                nband = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.TextLength > 0)
            {
                aband = true;
            }
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            if (txtDomicilio.TextLength > 0)
            {
                dband = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.TextLength > 0)
            {
                tband = true;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                dniband = true;
            }
        }

        private void UsuarioNuevo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
