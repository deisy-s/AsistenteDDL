using DevExpress.Utils;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace ConnectExample
{
    public partial class Login : Form
    {
        // Crear un objeto del formulario Form1
        Roles roles = new Roles();
        SignUp signup = new SignUp();
        // Crear un objeto de la librería e instanciarlo
        SQLConexion sql = new SQLConexion();
        // Crear una lista para contener todas las imágenes de la animación
        List<Image> lImages = new List<Image>();

        public Login()
        {
            InitializeComponent();
           
            GuardarRutas();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que los campos de usuario y contraseña no se encuentren vacíos
                if (tbUser.Text != string.Empty && tbPassword.Text != string.Empty)
                {
                    // Evaluar los valores ingresados en la librería
                    if (sql.BDEvaluarSesion(tbUser.Text, tbPassword.Text))
                    {
                        Form1 form = new Form1(tbUser.Text, tbPassword.Text);
                        this.Hide();
                        // Abrir el formulario Form1
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show(sql.sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarRutas()
        {
            lImages.Clear();

            // Agregar las imágenes que se ecuentran en resources
            for (int i = 0; i < 24; i++)
            {
                string imagen = $"textbox_user_{i + 1}";
                
                var bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(imagen);

                if(bmp != null)
                {
                    lImages.Add(bmp);
                }
            }
            //lImages.Add(Properties.Resources.textbox_user_24);
            // Agregar las imagenes de la contraseña
            lImages.Add(Properties.Resources.textbox_passwordObserved);
            lImages.Add(Properties.Resources.textbox_password);

            // Mostrar la primera imagen
            Bitmap defImage = Properties.Resources.textbox_user_1;
            if(defImage != null)
            {
                lImages.Insert(0, defImage);
            }
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            try
            {
                // Mostrar la imagen correcta al entrar al textBox
                if (tbUser.Text.Length > 0)
                {
                    // Si la longitud es mayor a 0, mostrar la imagen de acerdo a la longitud
                    pbAnimation.Image = lImages[tbUser.Text.Length - 1];
                }
                else if (tbUser.Text.Length == 0)
                {
                    // Si la longitud es igual a 0, mostrar la primera imagen
                    pbAnimation.Image = lImages[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Si se está escribiendo en el textBox, cambiar la imagen
                if (tbUser.Text.Length > 0 && tbUser.Text.Length <= 15)
                {
                    // Mostrar la imagen correcta de acuerdo a la longitud del textBox
                    pbAnimation.Image = lImages[tbUser.Text.Length - 1];
                    pbAnimation.BackgroundImageLayout = ImageLayout.Stretch; // Modificar el layout para que la imagen que muestre de la manera correcta
                }
                else if (tbUser.Text.Length == 0) // En caso que la longitud sea 0
                {
                    // Mostrar la primer imagen de inicio
                    pbAnimation.Image = lImages[0];
                }
                else
                {
                    // En caso de tener una longitud mayor a 15 y que no sea 0, mostrar la última imagen
                    pbAnimation.Image = lImages[23];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            // Evaluar el estado del comboBox de 'Mostrar contraseña'
            if (cbPassword.Checked)
            {
                // Bitmap permite guardar, cargar y manipular las imágenes
                // Mostrar la imagen donde está peeking cuando se puede ver la contraseña
                pbAnimation.Image = lImages[25];
                // No reemplazar contraseña con caracter especial
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                // Mostrar la imagen con los ojos tapados cuando no se puede ver la contraseña
                pbAnimation.Image = lImages[26];
                // Reemplazar la contraseña con un caracter especial
                tbPassword.PasswordChar = '*';
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // Llamar al evento de btnLogin_Click para que realice lo mismo
                btnLogin_Click(sender, e);
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Evaluar el estado del comboBox de 'Mostrar contraseña'
            if (cbPassword.Checked)
            {
                // Mostrar la imagen donde está peeking cuando se puede ver la contraseña
                pbAnimation.Image = lImages[25];
                // Si se encuentra seleccionada la casilla, no reemplazar la contraseña con un caracter especial
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                // Mostrar la imagen con los ojos tapados cuando no se puede ver la contraseña
                pbAnimation.Image = lImages[26];
                // Si no se encuentra seleccionada la casilla, reemplazar la contraseña con un caracter especial
                tbPassword.PasswordChar = '*';
            }
        }

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Guardar los valores de usuario y contraseña ingresados por el usuario
            string sUser = tbUser.Text;
            string sPassword = tbPassword.Text;
            // Asegurar que el usuario haya ingresado usuario y contraseña antes de poder entrar al apartado de roles
            if (string.IsNullOrEmpty(sUser) || string.IsNullOrEmpty(sPassword))
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Evaluar que el usuario y contraseña sean correctos
                if (sql.BDEvaluarSesion(tbUser.Text, tbPassword.Text))
                {
                    // Crear una DataTable para guardar el resultado del siguiente query
                    DataTable dt = new DataTable();
                    int i = 0; // Variable para guardar el número retornado por el DataTable
                    string s = string.Empty; // Variable para guardar el string retornado por el DataTable
                    // Revisar si el usuario es el sa
                    sql.BDCheckSA(ref dt, tbUser.Text);
                    // Guardar el un (1) valor retornado en la DataTable
                    // Retorna 0 si no es el sa, 1 si sí lo es
                    foreach (DataRow row in dt.Rows)
                    {
                        s = row[0].ToString();
                    }
                    i = Convert.ToInt32(s);
                    // Si el int es igual a 1, es el sa
                    if (i == 1)
                    {
                        // Mostrar el form de SignUp y ocultar este
                        signup.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No tiene permiso de crear usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(sql.sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            // Guardar los valores de usuario y contraseña ingresados por el usuario
            string sUser = tbUser.Text;
            string sPassword = tbPassword.Text;
            // Asegurar que el usuario haya ingresado usuario y contraseña antes de poder entrar al apartado de roles
            if (string.IsNullOrEmpty(sUser) || string.IsNullOrEmpty(sPassword))
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Evaluar que el usuario y contraseña sean correctos
                if (sql.BDEvaluarSesion(tbUser.Text, tbPassword.Text))
                {
                    // Crear una DataTable para guardar el resultado del siguiente query
                    DataTable dt = new DataTable();
                    int i = 0; // Variable para guardar el número retornado por el DataTable
                    string s = string.Empty; // Variable para guardar el string retornado por el DataTable
                    // Revisar si el usuario es el sa
                    sql.BDCheckSA(ref dt, tbUser.Text);
                    // Guardar el un (1) valor retornado en la DataTable
                    // Retorna 0 si no es el sa, 1 si sí lo es
                    foreach (DataRow row in dt.Rows)
                    {
                        s = row[0].ToString();
                    }
                    i = Convert.ToInt32(s);
                    // Si el int es igual a 1, es el sa
                    if (i == 1)
                    {
                        // Mostrar el form de Roles y ocultar este
                        roles.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("No tiene permiso de modificar y crear roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show(sql.sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
