using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;

namespace SQLConnectLibrary
{
    public class SQLConexion
    {
        public String sError;

        public SQLConexion()
        {

        }

        // No se usa
        public Boolean Conectado()
        {
            Boolean bOk = false;
            String sCadena = "Server=(local);Database=master;Trusted_Connection=True;";

            try
            {
                SqlConnection con = new SqlConnection(sCadena);
                con.Open();
                con.Close();

                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return bOk;
        }

        // Confirmar que sí se puede conectar a SQL Server
        public SqlConnection ConectadoBD()
        {
            SqlConnection con = null;
            String sCadena = $"Server=(local);Database=master;Trusted_Connection=True;";

            try
            {
                con = new SqlConnection(sCadena);
                con.Open();
                con.Close();

            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return con;
        }

        // Confirmar que sí se puede conectar a SQL Server
        public SqlConnection ConectadoUser(string sUser, string sPassword)
        {
            SqlConnection con = null;
            String sCadena = $@"Server=(local); Initial Catalog = Master; User ID = {sUser}; Password = {sPassword}";

            try
            {
                con = new SqlConnection(sCadena);
                con.Open();
                con.Close();

            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return con;
        }

        // Confirmar que sí se puede conectar a SQL Server
        // Conexión para el query ingresado por el usuario
        public SqlConnection ConectadoUser(string sUser, string sPassword, string sDB)
        {
            SqlConnection con = null;
            String sCadena = $@"Server=(local); Initial Catalog = {sDB}; User ID = {sUser}; Password = {sPassword}";

            try
            {
                con = new SqlConnection(sCadena);
                con.Open();
                con.Close();

            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return con;
        }

        // Encontrar todas las bds y regresar un datatable con los nombres
        public Boolean BDServer(ref DataTable table)
        {
            // Valor booleano para regresar un verdadero o falso si la operación fue realizada con éxito
            Boolean bOk = false;

            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoBD();
                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query para seleccionar los nombres de las bases de datos, pero excluir las bases de datos creadas por
                // SQL Server (master, model, tempdb, msdb)
                String sQry = "SELECT name FROM sys.databases where name not in ('master', 'model', 'tempdb', 'msdb')";
                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Llenar una DataTable con la información obtenida por el query
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }

                // Cerrar la conexión
                con.Close();

            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return bOk;
        }

        // Encontrar todas las bds y regresar un datatable con los nombres
        public Boolean BDServer(ref DataTable table, string sUser, string sPassword) 
        {
            // Valor booleano para regresar un verdadero o falso si la operación fue realizada con éxito
            Boolean bOk = false;

            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);
                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed) 
                {
                    con.Open();
                }

                // Query para seleccionar los nombres de las bases de datos, pero excluir las bases de datos creadas por
                // SQL Server (master, model, tempdb, msdb)
                String sQry = "SELECT name FROM sys.databases where name not in ('master', 'model', 'tempdb', 'msdb')";
                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Llenar una DataTable con la información obtenida por el query
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }

                // Cerrar la conexión
                con.Close();

            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return bOk;
        }

        // Regresar las tablas de la BD seleccionada
        public void BDTablas( ref DataTable dt, string sBD, string sUser, string sPassword) 
        {
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed) 
                {
                    con.Open();
                }

                // Query para seleccionar los nombres de las tablas
                string sQry = $"USE {sBD}; SELECT name FROM sys.tables";
                // Command con la información del query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Llenar un DataTable con los valores obtenidos
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                // Cerrar la conexión
                con.Close();
            } catch(Exception ex)
            {
                sError = ex.Message;
            }
        }

        // Regresar las vistas de la BD seleccionada
        public void BDViews(ref DataTable dt, string sBD, string sUser, string sPassword)
        {
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query para seleccionar los nombres de las vistas
                string sQry = $"USE {sBD}; SELECT name FROM sys.views;";
                // Command con la información del query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Llenar un DataTable con los valores obtenidos
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                // Cerrar la conexión
                con.Close();
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
        }

        // Regresar las columnas de la tabla seleccionada
        public void BDTablaInfo( ref DataTable dtInfo, string sBD, string sTabla, string sUser, string sPassword) 
        {
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Unir los resultados del query de nombre, tipo de dato, longitud y nulos con el query de tipo
                // de constraint
                string sQry = $"USE {sBD}; SELECT i.COLUMN_NAME AS Nombre, i.DATA_TYPE AS TipoDato, i.CHARACTER_MAXIMUM_LENGTH AS LimiteMaximo, i.IS_NULLABLE AS Nulo, COALESCE(tc.CONSTRAINT_TYPE, '') AS ConstraintTipo FROM INFORMATION_SCHEMA.COLUMNS i LEFT JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE u ON i.TABLE_NAME = u.TABLE_NAME AND i.COLUMN_NAME = u.COLUMN_NAME LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc ON u.CONSTRAINT_NAME = tc.CONSTRAINT_NAME where i.TABLE_NAME = '{sTabla}';";
                // Pasaro la conexión y el query a un command de SQL
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Llenar una DataTable con los resultados del query
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dtInfo);
                }

                // Cerrar la conexión
                con.Close();
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
        }

        // No se usa
        // Solamente agrega 1 campo a la vez, no se pueden agregar varios
        // Si lo elimino deja de funcionar por alguna razón ?????
        public bool BDCrearCampo(string sBD, string sTabla, string sCampo, string sDato, string sLongitud, bool bNull, string sConstraint, string sUser, string sPassword)
        {
            // Bool para indicar si se realizó el método
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed) 
                {
                    con.Open();
                }
                // Comenzar a armar el query
                string sQry = $"USE {sBD}; ALTER TABLE {sTabla} ADD {sCampo} {sDato}";

                // En caso de ser varchar o char, agregar la longitud al query
                if (sDato.ToUpper().Contains("CHAR"))
                {
                    sQry += $"({sLongitud})";
                }

                // Agregar el valor Null/Not Null de acuerdo al bool
                if (bNull)
                {
                    sQry += " NOT NULL";
                }
                else
                {
                    sQry += " NULL";
                }

                // Si se pasó un valor para constraint, agregarlo al query
                if (!string.IsNullOrEmpty(sConstraint))
                {
                    sQry += $" {sConstraint}";
                }
                 // Cerrar el query
                sQry += ";";

                // Pasar el query y la conexión a un command de SQL
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Ejecutar el query sin regresar ningún valor
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();
                // Si no ocurrió ningún error, regresar el booleano verdadero
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Crear un campo en la BD y tabla seleccionada
        public bool CrearCampo(string sBD, string sTabla, List<string> campos, List<string> tDatos, List<string> longitudes, List<bool> noNulls, List<string> constraints, string sUser, string sPassword)
        {
            // Bool para indicar si se realizó el método
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                // Comenzar a armar el query
                string sQry = $"USE {sBD};";

                // Obtener los valores de todas las listas
                for (int i = 0; i < campos.Count; i++)
                {
                    string campo = campos[i];
                    string dato = tDatos[i];
                    string longitud = longitudes[i];
                    bool noNull = Convert.ToBoolean(noNulls[i]);
                    string constraint = constraints[i];

                    sQry += $"ALTER TABLE {sTabla} ADD {campo} {dato}";

                    // En caso de ser varchar o char, agregar la longitud al query
                    if (dato.ToUpper().Contains("CHAR"))
                    {
                        sQry += $"({longitud})";
                    }
                    // Agregar el valor Null/Not Null de acuerdo al bool
                    if (!noNull)
                    {
                        sQry += " NOT NULL";
                    }
                    else
                    {
                        sQry += " NULL";
                    }

                    // Si se pasó un valor para constraint, agregarlo al query
                    if (!string.IsNullOrEmpty(constraint))
                    {
                        sQry += $" {constraint}";
                    }

                    // Cerrar el query
                    sQry += ";";
                }

                // Pasar el query y la conexión a un command de SQL
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Ejecutar el query sin regresar ningún valor
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();
                // Si no ocurrió ningún error, regresar el booleano verdadero
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Eliminar el campo seleccionado
        public bool BDEliminarCampo(string sBD, string sTabla, string sCampo, string sUser, string sPassword)
        {
            // Booleano para indicar si se realizó la operación
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query para eliminar la columna seleccionada
                string sQry = $"USE {sBD}; ALTER TABLE {sTabla} DROP COLUMN {sCampo};"; 

                // Pasar el query a un command de SQL
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Ejecutar el query sin regresar ningún valor
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();
                // Si no ocurrió ningún error, regresar true en el bool
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Crear una tabla en la BD seleccionada y con el nombres y campos ingresados
        public bool BDCrearTabla(string sBD, string sTabla, List<string> campos, List<string> tDatos, List<string> longitudes, List<bool> noNulls, List<string> contraints, string sUser, string sPassword)
        {
            // Booleano para conocer si se realizó la operación
            bool bOk = false;
            try
            {
                // Crear lista para guardar las PK
                List<string> lPK = new List<string>();
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(sUser, sPassword);

                // Comenzar a armar el query para crear la tabla
                string sQry = $"USE {sBD}; CREATE TABLE {sTabla} (";

                // Obtener los valores de todas las listas
                for (int i = 0; i < campos.Count; i++)
                {
                    string campo = campos[i];
                    string tDato = tDatos[i];
                    string longitud = longitudes[i];
                    bool noNull = noNulls[i];
                    string constraint = contraints[i];

                    // Agregar campo y tipo de dato al string del query
                    sQry += $"{campo} {tDato}";

                    // En caso de ser varchar o char, agregar el valor de longitud
                    if (tDato.ToUpper().Contains("CHAR"))
                    {
                        sQry += $"({longitud})";
                    }

                    // Agregar el valor de Null/Not Null
                    if (!noNull)
                    {
                        sQry += " NOT NULL";
                    } else
                    {
                        sQry += " NULL";
                    }

                    // Agregar contraint al query, si es que existe guardar las PK en la lista, en caso que
                    // no sea PK agregarla al query
                    if (!string.IsNullOrEmpty(constraint))
                    {
                        if(constraint == "PRIMARY KEY")
                        {
                            lPK.Add(campo);
                        } else
                        {
                            sQry += $" {constraint}";
                        }
                    }

                    // Cada columna de una tabla se separan con una comma
                    // RECORDATORIO: se va a poner una ',' cuando se terminen de recorrer las listas, elimina la última
                    sQry += ",";
                }

                // Agregar varias PK al final del query, se tienen que agregar de esta manera
                // o sino, no permite agregar varias PK
                if (lPK.Count > 0)
                {
                    sQry += $"PRIMARY KEY ({string.Join(", ", lPK)}) ";
                }

                // Eliminar la última comma o el espacio que sale sobrando
                sQry = sQry.Substring(0, (sQry.Length - 1));

                // Cerrar el paréntesis de la tabla y finalizar el query
                sQry += ");";

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Pasar el query y la conexión a un command de SQL
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Ejecutar el query sin regresar resultados
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();

                // Si se realizó con éxito, el booleano será true
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Evaluar el inicio de sesión del Login
        public bool BDEvaluarSesion(string sUser, string sPassword)
        {
            bool bOk = false;
            string sConection;
            try
            {
                // Crear la conexión con los valores de usuario y contraseña ingresado por el usuario
                sConection = $@"Server=(local); Initial Catalog = Master; User ID = {sUser}; Password = {sPassword}";
                // Llamar al método que se conecta a la BD
                if (BDIniciarSesion(sConection))
                {
                    bOk = true;
                }
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Conectarse a la BD con la conexión nueva
        public bool BDIniciarSesion(string sConection)
        {
            bool bOk = false;
            try
            {
                // Crear la conexión
                SqlConnection conNewUser = new SqlConnection(sConection);
                conNewUser.Open(); // Abrir y cerrar la conexión
                conNewUser.Close();
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk; // Regresar al valor bool si se pudo abrir la conexión o no
        }

        // Crear un login
        public bool BDCrearUser(string user, string password, string language, string defaultBD, List<string> lBDs, List<string> lRoles)
        {
            bool bOk = false;
            try
            {
                // Conectarse a la base de datos
                SqlConnection con = ConectadoBD();

                // Iniciar a formar el query
                string sQry = $@"CREATE LOGIN [{user}] WITH PASSWORD = '{password}' MUST_CHANGE, CHECK_POLICY = ON, CHECK_EXPIRATION = ON, DEFAULT_LANGUAGE = [{language}], DEFAULT_DATABASE = [{defaultBD}];";

                // Agregar los permisos del usuario por cada bds seleccionada
                foreach(string bd in lBDs)
                {
                    sQry += $@"USE [{bd}]; CREATE USER [{user}] FOR LOGIN [{user}];";
                    // Agregar todos los roles seleccionados al usuario
                    foreach(string role in lRoles)
                    {
                        sQry += $@"ALTER SERVER ROLE [{role}] ADD MEMBER [{user}];";
                    }
                }

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Pasar el query y la conexión a un command de SQL
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Ejecutar el query sin regresar resultados
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();

                // Si se realizó con éxito, el booleano será true
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Regresar los nombres de los roles
        public Boolean BDRoles(ref DataTable table)
        {
            // Valor booleano para regresar un verdadero o falso si la operación fue realizada con éxito
            Boolean bOk = false;

            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoBD();
                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query para seleccionar los nombres de todos los roles
                String sQry = "Select name from sys.server_principals where type = 'R' order by name;";
                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Llenar una DataTable con la información obtenida por el query
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }

                // Cerrar la conexión
                con.Close();

            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return bOk;
        }

        // Regresar los nombres de los usuarios
        public Boolean BDUsers(ref DataTable table)
        {
            // Valor booleano para regresar un verdadero o falso si la operación fue realizada con éxito
            Boolean bOk = false;

            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoBD();
                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query para seleccionar los nombres de los usuarios
                String sQry = "USE master; SELECT * FROM master.sys.sql_logins;";
                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Llenar una DataTable con la información obtenida por el query
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }

                // Cerrar la conexión
                con.Close();

            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }

            return bOk;
        }

        // Crear un rol nuevo
        public bool CrearRol(string roleName, List<string> roles)
        {
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoBD();

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Iniciar el query para crear un rol
                string sQry = $@"CREATE SERVER ROLE [{roleName}] ALTER AUTHORIZATION ON SERVER ROLE:: [{roleName}] TO [sa]; ";

                // Agregar los permisos del rol seleccionado al rol nuevo
                foreach (string role in roles)
                {
                    sQry += $@"ALTER SERVER ROLE [{role}] ADD MEMBER [{roleName}]; ";
                }

                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Ejecutar el query sin regresar resultados
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();

                // Si se realizó con éxito, el booleano será true
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Revisar si el usuario que inicia sesión es el sa
        public bool BDCheckSA(ref DataTable table, string user)
        {
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoBD();

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query para revisar si el usuario es el sa
                string sQry = $"SELECT IS_SRVROLEMEMBER('sysadmin', '{user}')";

                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Regresar un valor 0 o 1 a una tabla de acuerdo a si es el sa
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }

                // Cerrar la conexión
                con.Close();

                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Asignar un rol a un usuario
        public bool AsignarRol(string user, List<string> roleName)
        {
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoBD();

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Query
                string sQry = "";

                // Agregar el rol al usuario
                foreach (string role in roleName)
                {
                    sQry += $@"ALTER SERVER ROLE [{role}] ADD MEMBER [{user}]; ";
                }

                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(sQry, con);

                // Ejecutar el query sin regresar resultados
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();

                // Si se realizó con éxito, el booleano será true
                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Ejecutar un query de tipo CREATE (no retorna una tabla)
        public bool DBQuery(string user, string password, string bd, string query)
        {
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(user, password, bd);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(query, con);

                // Ejecutar el query sin regresar resultados
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                con.Close();

                // Si se realizó con éxito, el booleano será true
                bOk = true;
            } catch(Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }

        // Ejecutar un query que sí retorna una tabla
        public bool DBQuery(ref DataTable table, string user, string password, string bd, string query)
        {
            bool bOk = false;
            try
            {
                // Conectarse a SQL Server
                SqlConnection con = ConectadoUser(user, password, bd);

                // Abrir la conexión si se encuentra cerrada
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                // Crear un command de SQL y pasarle el query y la conexión
                SqlCommand cmd = new SqlCommand(query, con);

                // Llenar una DataTable con la información obtenida por el query
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }

                // Cerrar la conexión
                con.Close();

                bOk = true;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            return bOk;
        }
    }
}
