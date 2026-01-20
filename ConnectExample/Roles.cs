using SQLConnectLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectExample
{
    public partial class Roles : Form
    {
        SQLConexion sql = new SQLConexion();

        public Roles()
        {
            InitializeComponent();
            // Crear DataTables para los datos de roles y usuarios
            DataTable roles = new DataTable();
            DataTable users = new DataTable();
            // Guardar los roles y usuarios al llamar a su método correspondiente en la librería
            sql.BDRoles(ref roles);
            sql.BDUsers(ref users);
            // Mostrar los roles
            foreach (DataRow row in roles.Rows)
            {
                clbRoles.Items.Add(row[0].ToString());
                clbRolCrear.Items.Add(row[0].ToString());
            }
            // Mostrar los usuarios
            foreach (DataRow row in users.Rows)
            {
                cbUsers.Items.Add(row[0].ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Abrir el Login y ocultar este form
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            try
            { 
                // Guardar el nombre del rol ingresado por el usuario
                string roleName = tbRoleName.Text;
                // Crear una lista y contador de los roles seleccionados
                List<string> roles = new List<string>();
                int r = clbRolCrear.CheckedItems.Count;
                // Evaluar si se ingresó un nombre de rol y se seleccionaron roles
                if(string.IsNullOrEmpty(roleName) || r == 0)
                {
                    MessageBox.Show("Por favor llene los datos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    // Agregar los roles seleccionados a una lista
                    for (int i = 0; i < r; i++)
                    {
                        roles.Add(clbRolCrear.CheckedItems[i].ToString());
                    }
                    // Pasar los datos a la librería y marcar si se pudo ejecutar de manera correcta
                    if (sql.CrearRol(roleName, roles))
                    {
                        MessageBox.Show("Rol creado", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"El rol no pudo ser creado: {sql.sError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsignRol_Click(object sender, EventArgs e)
        {
            // Crear una lista y contador para los roles seleccionados
            List<string> roles = new List<string>();
            int r = clbRoles.CheckedItems.Count;
            // Guardar el nombre de usuario seleccionado
            string user = cbUsers.Text;

            // Evaliar que se hayan seleccionado los datos necesarios
            if (r == 0 || string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Por favor llene los datos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                // Guardar los roles seleccionados en una lista
                for (int i = 0; i < r; i++)
                {
                    roles.Add(clbRoles.CheckedItems[i].ToString());
                }
                // Llamar al método de asignación y mandar un mensaje sobre su estado
                if (sql.AsignarRol(user,roles))
                {
                    MessageBox.Show("El rol fue asignado al usuario", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show($"El rol no se pudo asignar al usuario: {sql.sError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
