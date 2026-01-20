using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;
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
    public partial class Form1 : Form
    {
        // Crear un objeto de SQLConexion
        SQLConexion sql = new SQLConexion();
        // Crear una variable de contador global para la cantidad de columnas de la tabla
        // Esta se usa para permitir crear n cantidad de campos
        public int iNumRows;
        // Crear una variable para el nombre del usuario que inició sesión
        string sName;
        // Crear una variable para la contraseña del usuario que inició sesión
        string sPassword;


        public Form1( string user, string password)
        {
            InitializeComponent();
            dgvTablaInfo.Columns[0].Width = 100;
            dgvTablaInfo.Columns[1].Width = 100;
            dgvTablaInfo.Columns[2].Width = 100;
            dgvTablaInfo.Columns[3].Width = 50;
            dgvTablaInfo.Columns[4].Width = 100;
            // Limpiar el ComboBox de las BDs
            cbBD.Items.Clear();
            // Crear un DataTable para guardar los nombres de las BDs
            DataTable table = new DataTable();
            // Guardar los datos de inicio de sesión
            sName = user; sPassword = password;
            // LLamar al método en la librería y regresar los nombres de las BDs
            sql.BDServer(ref table, sName, sPassword);
            // Recorrer el DataTable y poner sus valores en los ComboBox de las BDs
            foreach (DataRow row in table.Rows)
            {
                cbBD.Items.Add(row[0].ToString());
                cbDBQry.Items.Add(row[0].ToString());
            }
        }

        // Mostrar las tablas de la bd en el segundo combobox
        private void cbBD_SelectedIndexChanged(object sender, EventArgs e) 
        {
            try
            {
                // Crear una DataTable para almacenar los nombres de las tablas de la BD
                DataTable dt = new DataTable();
                // Crear una DataTable para almacenar los nombres de las vistas de la BD
                DataTable dtV = new DataTable();
                // Limpiar el ComboBox de las tablas
                cbTablas.Items.Clear();
                cbTablas.Text = "Tablas";
                // Limpiar el ComboBox de vistas
                cbViews.Items.Clear();
                cbViews.Text = "Vistas";
                // Llamar al método y guardar los nombres de las tablas
                sql.BDTablas(ref dt, cbBD.Text, sName, sPassword);
                // Llamar al método y guardar los nombres de las vistas
                sql.BDViews(ref dtV, cbBD.Text, sName, sPassword);
                // Recorrer el DataTable y pasar sus valores al ComboBox de las tablas
                foreach (DataRow row in dt.Rows)
                {
                    cbTablas.Items.Add(row[0].ToString());
                }
                // Recorrer el DataTable y pasar sus valores al ComboBox de las vistas
                foreach (DataRow row in dtV.Rows)
                {
                    cbViews.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Mostrar la información de la tabla en el datagridview
        private void cbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Reset de la variable que cuenta la cantidad de columnas de la tabla
                iNumRows = 0;
                // Crear una DataTable para guardar los datos de la tabla
                DataTable dtInfo = new DataTable();
                // Limpiar el DataGridView
                dgvTablaInfo.Rows.Clear();

                // Llamar a la librería
                sql.BDTablaInfo(ref dtInfo, cbBD.Text, cbTablas.Text, sName, sPassword);

                foreach (DataRow row in dtInfo.Rows)
                {
                    // Guardar el valor de IS_NULLABLE para poderlo comparar
                    string sCheckNull = row[3].ToString();
                    string sFK = row[4].ToString();
                    if (row[4].ToString() == "FOREIGN KEY")
                    {
                        sFK = "";
                    }
                    // Convertir el IS_NULLABLE de YES/NO a true/false
                    if (sCheckNull == "YES")
                    {
                        dgvTablaInfo.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), true, sFK);
                    }
                    else if (sCheckNull == "NO")
                    {
                        dgvTablaInfo.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), false, sFK);
                    }
                    // Agregar al contador global
                    iNumRows++;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegurarse que sí tiene un nombre la tabla
                string sTablas = cbTablas.Text;
                if (string.IsNullOrEmpty(sTablas))
                {
                    MessageBox.Show("Ingrese un nombre para la tabla");
                    return;
                }

                // Crear listas para guardar todos los datos de la tabla nueva
                // revisar notas de memoria dinámica
                List<string> lCampos = new List<string>();
                List<string> lTDatos = new List<string>();
                List<string> lLongitudes = new List<string>();
                List<bool> lNulls = new List<bool>();
                List<string> lConstraints = new List<string>();

                foreach(DataGridViewRow row in dgvTablaInfo.Rows)
                {
                    // No guardar los datos de la línea en blanco del datagridview
                    if(row.IsNewRow) continue;

                    // Guardar los valores del datagridview
                    // Value? evalúa si la celda tiene un valor o no, en caso de que no, lo guarda como null
                    string sNombre = row.Cells[0].Value?.ToString();
                    string sDato = row.Cells[1].Value?.ToString();
                    string sLongitud = row.Cells[2].Value?.ToString();
                    // Como es checkbox, siempre va a tener un valor true o false
                    bool bNull = Convert.ToBoolean(row.Cells[3].Value); 
                    string sConstraint = row.Cells[4].Value?.ToString();

                    // Asegurarse que los datos necesarios han sido ingresados
                    // Se requiere nombre del campo, tipo de dato y, en caso de ser varchar o char, longitud
                    if(string.IsNullOrEmpty(sNombre) || string.IsNullOrEmpty(sDato) || (sDato.ToUpper().Contains("CHAR") && string.IsNullOrEmpty(sLongitud)))
                    {
                        MessageBox.Show("No ha ingresado datos necesarios");
                        return;
                    }

                    // Asegurarse que los campos PK no sean nulos
                    if (!string.IsNullOrEmpty(sConstraint))
                    {
                        if(sConstraint == "PRIMARY KEY" && bNull)
                        {
                            MessageBox.Show("Los campos de PRIMARY KEY no pueden permitir nulos");
                            return;
                        }
                    }

                    // Guardar los datos en la lista
                    lCampos.Add(sNombre);
                    lTDatos.Add(sDato);
                    lLongitudes.Add(sLongitud);
                    lNulls.Add(bNull);
                    lConstraints.Add(sConstraint);
                }

                // Mandar la información a la librería
                // Mandar un mensaje si se creó la tabla con éxito o no
                if (sql.BDCrearTabla(cbBD.Text, cbTablas.Text, lCampos, lTDatos, lLongitudes, lNulls, lConstraints, sName, sPassword))
                {
                    MessageBox.Show($"Tabla {cbTablas.Text} creada");
                    // Cargar de nuevo el ComboBox de tablas
                    cbBD_SelectedIndexChanged(sender, e);
                } else
                {
                    MessageBox.Show(sql.sError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegurarse que sí tiene nombre la tabla
                string sTablas = cbTablas.Text;
                if (string.IsNullOrEmpty(sTablas))
                {
                    MessageBox.Show("Seleccione una tabla");
                    return;
                }

                // Guardar el nombre del campo que se busca eliminar
                // Se debe encontrar seleccionado la celda que contiene el nombre del campo
                string sCampo = dgvTablaInfo.CurrentCell.Value?.ToString();

                // Asegurar que el campo no vaya vacío
                if (string.IsNullOrEmpty(sCampo))
                {
                    MessageBox.Show("Seleccione el nombre de un campo");
                    return;
                }

                // Llamar al método en la librería
                // Mandar un mensaje si fue eliminado con éxito o no
                if (sql.BDEliminarCampo(cbBD.Text, cbTablas.Text, sCampo, sName, sPassword))
                {
                    MessageBox.Show($"Campo {sCampo} eliminado");
                } else
                {
                    MessageBox.Show(sql.sError);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateField_Click(object sender, EventArgs e)
        {
            // Es necesario cargar de nuevo la tabla antes de crear campos nuevos
            // para poder capturar la cantidad de filas que tiene la tabla inicialmente
            try
            {
                // Crear un contador para recorrer las filas
                int i = 1;

                // Crear listas para guardar todos los datos de los campos nuevos
                List<string> lCampos = new List<string>();
                List<string> lTDatos = new List<string>();
                List<string> lLongitudes = new List<string>();
                List<bool> lNulls = new List<bool>();
                List<string> lConstraints = new List<string>();

                foreach (DataGridViewRow row in dgvTablaInfo.Rows)
                {
                    // No guardar los datos de la línea en blanco del datagridview
                    if (row.IsNewRow) continue;

                    // Solamente guardar los valores de la última fila
                    if (i > iNumRows)
                    {
                        // Guardar los valores del datagridview
                        // Value? evalúa si la celda tiene un valor o no, en caso de que no, lo guarda como null
                        string sNombre = row.Cells[0].Value?.ToString();
                        string sDato = row.Cells[1].Value?.ToString();
                        string sLongitud = row.Cells[2].Value?.ToString();
                        // Como es checkbox, siempre va a tener un valor true o false
                        bool bNull = Convert.ToBoolean(row.Cells[3].Value);
                        string sConstraint = row.Cells[4].Value?.ToString();

                        // Asegurarse que los datos necesarios han sido ingresados
                        // Se requiere nombre del campo, tipo de dato y, en caso de ser varchar o char, longitud
                        if (string.IsNullOrEmpty(sNombre) || string.IsNullOrEmpty(sDato) || (sDato.ToUpper().Contains("CHAR") && string.IsNullOrEmpty(sLongitud)))
                        {
                            MessageBox.Show("No ha ingresado datos necesarios");
                            return;
                        }

                        // Asegurarse que los campos PK no puedan ser nulos
                        if (!string.IsNullOrEmpty(sConstraint))
                        {
                            if (sConstraint == "PRIMARY KEY" && bNull)
                            {
                                MessageBox.Show("Los campos de PRIMARY KEY no pueden permitir nulos");
                                return;
                            }
                        }

                        // Guardar los datos en la lista
                        lCampos.Add(sNombre);
                        lTDatos.Add(sDato);
                        lLongitudes.Add(sLongitud);
                        lNulls.Add(bNull);
                        lConstraints.Add(sConstraint);
                    }

                    // Agregar al contador
                    i++;
                }

                // Llamar al método de crear campo en la librería
                if (sql.CrearCampo(cbBD.Text, cbTablas.Text, lCampos, lTDatos, lLongitudes, lNulls, lConstraints, sName, sPassword))
                {
                    MessageBox.Show("Campo agregado");
                    // Agregar 1 al contador, para poder seguir agregar campos sin tener que hacer click
                    // en el botón reset
                    iNumRows++;
                }
                else
                {
                    MessageBox.Show(sql.sError);
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetDGV_Click(object sender, EventArgs e)
        {
            // Resetear el DGV
            cbTablas_SelectedIndexChanged(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Abrir el form de Login y ocultar este
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar los valores del query ingresado y la bd seleccionada
                string sQry = tbQuery.Text;
                string sDB = cbDBQry.Text;
                DataTable dtSelect = new DataTable();

                // Si el ComboBox de la bds o el TextBox del query se encuentran vacíos, mandar un error
                if (string.IsNullOrEmpty(sQry) || string.IsNullOrEmpty(sDB))
                {
                    MessageBox.Show("Por favor ingrese los datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    // Evaluar si el query contiene un create o un select
                    if(sQry.ToUpper().Contains("CREATE"))
                    {
                        // Llamar al método correspondiente
                        if(sql.DBQuery(sName, sPassword, sDB, sQry))
                        {
                            MessageBox.Show("Instrucción ejecutada", "Finalizado", MessageBoxButtons.OK);
                        } else
                        {
                            MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else if (sQry.ToUpper().Contains("SELECT"))
                    {
                        // Llamar al método correspondiente
                        if (sql.DBQuery(ref dtSelect, sName, sPassword, sDB, sQry))
                        {
                            // Llenar el DataGridView vacío con el DataTable retornado
                            dgvResults.DataSource = dtSelect;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
