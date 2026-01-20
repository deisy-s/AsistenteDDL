using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLConnectLibrary;
using System.Text.RegularExpressions;

namespace ConnectExample
{
    public partial class SignUp : Form
    {
        // Crear la conexión a la librería
        SQLConexion sql = new SQLConexion();
        // Crear las variables de los datos ingresados por el usuario
        string sUser, sPassword, sCheckPassword, sLanguage, sBDsDefault;
        List<string> sBDs = new List<string>();
        List<string> sRoles = new List<string>();
        // Crear el regex que pide min 8 caracteres, una letra mayúscula, una letra minúscula, un número y un
        // caracter especial en la contraseña
        Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");

        public SignUp()
        {
            InitializeComponent();
            // Crear un DataTable para guardar los nombres de las BDs
            DataTable table = new DataTable();
            // Crear un DataTable para guardar los nombres de los roles
            DataTable roles = new DataTable();
            // LLamar al método en la librería y regresar los nombres de las BDs
            sql.BDServer(ref table);
            // LLamar al método en la librería y regresar los nombres de los roles
            sql.BDRoles(ref roles);
            // Recorrer el DataTable y poner sus valores en los ComboBox de las BDs
            foreach (DataRow row in table.Rows)
            {
                cbDatabases.Items.Add(row[0].ToString());
                cblDatabases.Items.Add(row[0].ToString());
            }
            // Recorrer el DataTable y poner sus valores en los ComboListBox de los roles
            foreach (DataRow row in roles.Rows)
            {
                clbRoles.Items.Add(row[0].ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Abrir el form de Login y ocultar este
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar los valores ingresados por el usuario
                sUser = tbUser.Text;
                sPassword = tbPassword.Text;
                sCheckPassword = tbConfirmPassword.Text;
                sLanguage = cbLanguage.Text;
                sBDsDefault = cbDatabases.Text;
                bool bOk = regex.IsMatch(sPassword); // Evaluar si la contraseña cumple con el regex creado
                // Contar las cantidades de campos seleccionados en el ComboListBox
                int bd = cblDatabases.CheckedItems.Count;
                int r = clbRoles.CheckedItems.Count;
                // Agregar las bds seleccionadas a una lista
                for (int i = 0; i < bd; i++)
                {
                    sBDs.Add(cblDatabases.CheckedItems[i].ToString());
                }
                // Agregar los roles seleccionados a una lista
                for (int i = 0; i < r; i++)
                {
                    sRoles.Add(clbRoles.CheckedItems[i].ToString());
                }
                // Evaluar si se encuentra un campo vacío
                if (string.IsNullOrEmpty(sUser) || string.IsNullOrEmpty(sPassword) || string.IsNullOrEmpty(sCheckPassword) || string.IsNullOrEmpty(sLanguage) || string.IsNullOrEmpty(sBDsDefault))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    // Evaluar que se seleccionó como mínimo una bds y un rol
                    if (cblDatabases.CheckedItems.Count < 1 || clbRoles.CheckedItems.Count < 1)
                    {
                        MessageBox.Show("Por favor seleccione mínimo una base de datos y un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        // Si la contraseña cumple con los requisitos de regex
                        if (bOk)
                        {
                            // Evaluar que las contraseñas coincidan
                            if (sPassword == sCheckPassword)
                            {
                                // Si el idioma se mantuvo como Default, cambiarlo a español
                                if(sLanguage == "Default")
                                {
                                    sLanguage = "Spanish";
                                }
                                // Llamar al método de crear usuario
                                if (sql.BDCrearUser(sUser, sPassword, sLanguage, sBDsDefault, sBDs, sRoles))
                                {
                                    MessageBox.Show("Usuario creado", "Finalizado", MessageBoxButtons.OK);
                                } else
                                {
                                    MessageBox.Show($"Usuario no creado: {sql.sError}", "Error", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else
                        {
                            MessageBox.Show("La contraseña debe contener mínimo 8 caracteres, una letra minúscula, una letra mayúscula, un número y un caracter especial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
