using SE490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class PermisoDAL490WC
    {
        private static PermisoDAL490WC Instancia490WC;
        public static PermisoDAL490WC GestorPermisoORM490WC
        {
            get
            {
                if (Instancia490WC == null)
                {
                    Instancia490WC = new PermisoDAL490WC();
                }
                return Instancia490WC;
            }
        }
        //Para No Marearnos la forma para refactorizar es la siguiente:
        //Funcion NO comentada de arriba es la reemplazante de la comentada que tiene abajo William Cardenas 22-6-25

        public List<PermisoCompuesto490WC> LeerFamiliasConEstructuraRecursiva490WC()
        {
            Dictionary<string, PermisoCompuesto490WC> familiasDiccionario = new Dictionary<string,PermisoCompuesto490WC>();
            Dictionary<string, PermisoSimple490WC> permisosSimplesDiccionario = new Dictionary<string, PermisoSimple490WC>();

            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string querySimples = "SELECT Nombre490WC FROM PermisoSimple490WC";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        permisosSimplesDiccionario[nombre] = new PermisoSimple490WC(nombre);
                    }
                }

                
                string queryFamilias = "SELECT Nombre490WC FROM Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        familiasDiccionario[nombre] = new PermisoCompuesto490WC(nombre);
                    }
                }

                
                string queryRelPS = "SELECT NombreFamilia490WC, NombrePermisoSimple490WC FROM PermisoSimple_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelPS, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                        string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia) &&
                            permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                        {
                            familia.Agregar490WC(permisoSimple);
                        }
                    }
                }

                
                string queryRelFF = "SELECT NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC FROM Familia_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelFF, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string padre = lector["NombreFamiliaIncluye490WC"].ToString();
                        string hija = lector["NombreFamiliaIncluida490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(padre, out var familiaPadre) && familiasDiccionario.TryGetValue(hija, out var familiaHija))
                        {
                            familiaPadre.Agregar490WC(familiaHija);
                        }
                    }
                }
            }

            return familiasDiccionario.Values.ToList();
        }




        public PermisoCompuesto490WC LeerPermisoCompuesto490WC(string nombreCompuesto490WC)
        {
            Dictionary<string, PermisoCompuesto490WC> familiasDiccionario = new Dictionary<string, PermisoCompuesto490WC>();
            Dictionary<string, PermisoSimple490WC> permisosSimplesDiccionario = new Dictionary<string, PermisoSimple490WC>();
            PermisoCompuesto490WC perfilTemporal = null;

            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                // 1. Cargar todos los permisos simples
                string querySimples = "SELECT Nombre490WC FROM PermisoSimple490WC";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        permisosSimplesDiccionario[nombre] = new PermisoSimple490WC(nombre);
                    }
                }

                // 2. Cargar todas las familias
                string queryFamilias = "SELECT Nombre490WC FROM Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        familiasDiccionario[nombre] = new PermisoCompuesto490WC(nombre);
                    }
                }

                // 3. Cargar relaciones PermisoSimple - Familia
                string queryRelPS = "SELECT NombreFamilia490WC, NombrePermisoSimple490WC FROM PermisoSimple_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelPS, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                        string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia) &&
                            permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                        {
                            familia.Agregar490WC(permisoSimple);
                        }
                    }
                }

                // 4. Cargar relaciones Familia - Familia
                string queryRelFF = "SELECT NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC FROM Familia_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelFF, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombrePadre = lector["NombreFamiliaIncluye490WC"].ToString();
                        string nombreHija = lector["NombreFamiliaIncluida490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombrePadre, out var padre) &&
                            familiasDiccionario.TryGetValue(nombreHija, out var hija))
                        {
                            padre.Agregar490WC(hija);
                        }
                    }
                }

                // 5. Verificar si es un Perfil
                string queryPerfil = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(queryPerfil, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreCompuesto490WC);
                    int esPerfil = (int)cmd.ExecuteScalar();

                    if (esPerfil > 0)
                    {
                        perfilTemporal = new PermisoCompuesto490WC(nombreCompuesto490WC);

                        // 5.a Agregar permisos simples al perfil
                        string querySimplesPerfil = "SELECT NombrePermisoSimple490WC FROM PermisoSimple_Perfil490WC WHERE NombrePerfil490WC = @nombre";
                        using (SqlCommand cmdSimples = new SqlCommand(querySimplesPerfil, conexion))
                        {
                            cmdSimples.Parameters.AddWithValue("@nombre", nombreCompuesto490WC);
                            using (SqlDataReader lector = cmdSimples.ExecuteReader())
                            {
                                while (lector.Read())
                                {
                                    string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();
                                    if (permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                                    {
                                        perfilTemporal.Agregar490WC(permisoSimple);
                                    }
                                }
                            }
                        }

                        // 5.b Agregar familias al perfil
                        string queryFamiliasPerfil = "SELECT NombreFamilia490WC FROM Perfil_Familia490WC WHERE NombrePerfil490WC = @nombre";
                        using (SqlCommand cmdFamilias = new SqlCommand(queryFamiliasPerfil, conexion))
                        {
                            cmdFamilias.Parameters.AddWithValue("@nombre", nombreCompuesto490WC);
                            using (SqlDataReader lector = cmdFamilias.ExecuteReader())
                            {
                                while (lector.Read())
                                {
                                    string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                                    if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia))
                                    {
                                        perfilTemporal.Agregar490WC(familia);
                                    }
                                }
                            }
                        }

                        return perfilTemporal;
                    }
                }
            }

            // Si no es un perfil, devolver la familia si existe
            if (familiasDiccionario.TryGetValue(nombreCompuesto490WC, out var familiaRaiz))
            {
                return familiaRaiz;
            }

            return null;
        }






        public bool InsertarPermiso490WC(Permiso490WC permisoNuevo490WC)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    if (permisoNuevo490WC is PermisoSimple490WC)
                    {
                        string insertSimple = "INSERT INTO PermisoSimple490WC (Nombre490WC) VALUES (@nombre)";
                        using (SqlCommand cmd = new SqlCommand(insertSimple, conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", permisoNuevo490WC.obtenerPermisoNombre490WC());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (permisoNuevo490WC is PermisoCompuesto490WC permisoCompuesto)
                    {
                        // Verificar si es un rol (está también en Perfil490WC)
                        bool esRol = PerfilExiste490WC(permisoCompuesto.obtenerPermisoNombre490WC());

                        if (esRol)
                        {
                            // Insertar en PermisoCompuesto como ROL
                            string insertRol = "INSERT INTO Permiso490WC (nombrePermiso490WC, tipoPermiso490WC, esRolPermiso490WC) " +
                                               "VALUES (@nombre, 'Compuesto', 'True')";
                            using (SqlCommand cmd = new SqlCommand(insertRol, conexion))
                            {
                                cmd.Parameters.AddWithValue("@nombre", permisoCompuesto.obtenerPermisoNombre490WC());
                                cmd.ExecuteNonQuery();
                            }

                            // Insertar en Perfil490WC
                            string insertPerfil = "INSERT INTO Perfil490WC (Nombre490WC) VALUES (@nombre)";
                            using (SqlCommand cmdPerfil = new SqlCommand(insertPerfil, conexion))
                            {
                                cmdPerfil.Parameters.AddWithValue("@nombre", permisoCompuesto.obtenerPermisoNombre490WC());
                                cmdPerfil.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insertar como Familia
                            string insertFamilia = "INSERT INTO Familia490WC (Nombre490WC) VALUES (@nombre)";
                            using (SqlCommand cmd = new SqlCommand(insertFamilia, conexion))
                            {
                                cmd.Parameters.AddWithValue("@nombre", permisoCompuesto.obtenerPermisoNombre490WC());
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }



     

        public bool InsertarRelacion490WC(string nombrePermisoCompuesto490WC, string nombreIncluido490WC)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    // 1. Verificar si el incluido es PermisoSimple
                    string queryVerificarSimple = "SELECT COUNT(*) FROM PermisoSimple490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmdVerificarSimple = new SqlCommand(queryVerificarSimple, conexion))
                    {
                        cmdVerificarSimple.Parameters.AddWithValue("@nombreIncluido", nombreIncluido490WC);
                        int countSimple = (int)cmdVerificarSimple.ExecuteScalar();

                        if (countSimple > 0)
                        {
                            // ¿La entidad que incluye es una Familia?
                            string queryEsFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombreCompuesto";
                            using (SqlCommand cmdEsFamilia = new SqlCommand(queryEsFamilia, conexion))
                            {
                                cmdEsFamilia.Parameters.AddWithValue("@nombreCompuesto", nombrePermisoCompuesto490WC);
                                int esFamilia = (int)cmdEsFamilia.ExecuteScalar();

                                if (esFamilia > 0)
                                {
                                    string insertRel = "INSERT INTO PermisoSimple_Familia490WC (NombreFamilia490WC, NombrePermisoSimple490WC) VALUES (@familia, @simple)";
                                    using (SqlCommand cmdInsert = new SqlCommand(insertRel, conexion))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@familia", nombrePermisoCompuesto490WC);
                                        cmdInsert.Parameters.AddWithValue("@simple", nombreIncluido490WC);
                                        cmdInsert.ExecuteNonQuery();
                                    }
                                    return true;
                                }
                            }

                            // ¿La entidad que incluye es un Perfil?
                            string queryEsPerfil = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombreCompuesto";
                            using (SqlCommand cmdEsPerfil = new SqlCommand(queryEsPerfil, conexion))
                            {
                                cmdEsPerfil.Parameters.AddWithValue("@nombreCompuesto", nombrePermisoCompuesto490WC);
                                int esPerfil = (int)cmdEsPerfil.ExecuteScalar();

                                if (esPerfil > 0)
                                {
                                    string insertRel = "INSERT INTO PermisoSimple_Perfil490WC (NombrePerfil490WC, NombrePermisoSimple490WC) VALUES (@perfil, @simple)";
                                    using (SqlCommand cmdInsert = new SqlCommand(insertRel, conexion))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@perfil", nombrePermisoCompuesto490WC);
                                        cmdInsert.Parameters.AddWithValue("@simple", nombreIncluido490WC);
                                        cmdInsert.ExecuteNonQuery();
                                    }
                                    return true;
                                }
                            }
                        }
                    }

                    // 2. Verificar si el incluido es una Familia
                    string queryVerificarFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmdVerificarFamilia = new SqlCommand(queryVerificarFamilia, conexion))
                    {
                        cmdVerificarFamilia.Parameters.AddWithValue("@nombreIncluido", nombreIncluido490WC);
                        int countFamilia = (int)cmdVerificarFamilia.ExecuteScalar();

                        if (countFamilia > 0)
                        {
                            // ¿La entidad que incluye es otra Familia?
                            string queryEsFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombreCompuesto";
                            using (SqlCommand cmdEsFamilia = new SqlCommand(queryEsFamilia, conexion))
                            {
                                cmdEsFamilia.Parameters.AddWithValue("@nombreCompuesto", nombrePermisoCompuesto490WC);
                                int esFamilia = (int)cmdEsFamilia.ExecuteScalar();

                                if (esFamilia > 0)
                                {
                                    string insertRel = "INSERT INTO Familia_Familia490WC (NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC) VALUES (@padre, @hija)";
                                    using (SqlCommand cmdInsert = new SqlCommand(insertRel, conexion))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@padre", nombrePermisoCompuesto490WC);
                                        cmdInsert.Parameters.AddWithValue("@hija", nombreIncluido490WC);
                                        cmdInsert.ExecuteNonQuery();
                                    }
                                    return true;
                                }
                            }

                            // ¿La entidad que incluye es un Perfil?
                            string queryEsPerfil = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombreCompuesto";
                            using (SqlCommand cmdEsPerfil = new SqlCommand(queryEsPerfil, conexion))
                            {
                                cmdEsPerfil.Parameters.AddWithValue("@nombreCompuesto", nombrePermisoCompuesto490WC);
                                int esPerfil = (int)cmdEsPerfil.ExecuteScalar();

                                if (esPerfil > 0)
                                {
                                    string insertRel = "INSERT INTO Perfil_Familia490WC (NombrePerfil490WC, NombreFamilia490WC) VALUES (@perfil, @familia)";
                                    using (SqlCommand cmdInsert = new SqlCommand(insertRel, conexion))
                                    {
                                        cmdInsert.Parameters.AddWithValue("@perfil", nombrePermisoCompuesto490WC);
                                        cmdInsert.Parameters.AddWithValue("@familia", nombreIncluido490WC);
                                        cmdInsert.ExecuteNonQuery();
                                    }
                                    return true;
                                }
                            }
                        }
                    }
                }

                // No se pudo insertar la relación porque alguno no existe o no es válido
                return false;
            }
            catch
            {
                return false;
            }
        }





        public bool BorrarPermiso490WC(string NombrePermiso490WC)
        {
            try
            {
                // 1. Verificar si el permiso está asignado como Rol a algún usuario
                Usuario490WC usuarioConRol = UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.DevolverTodosLosUsuarios490WC().Find(x => x.Rol490WC == NombrePermiso490WC);

                if (usuarioConRol != null)
                {
                    return false; // No se puede borrar si está asignado
                }

                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    // 2. Verificar si es Permiso Simple
                    string queryEsSimple = "SELECT COUNT(*) FROM PermisoSimple490WC WHERE Nombre490WC = @nombre";
                    using (SqlCommand cmdVerificarSimple = new SqlCommand(queryEsSimple, conexion))
                    {
                        cmdVerificarSimple.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                        int countSimple = (int)cmdVerificarSimple.ExecuteScalar();

                        if (countSimple > 0)
                        {
                            // 2.a Eliminar relaciones PermisoSimple-Familia
                            string deleteRel = "DELETE FROM PermisoSimple_Familia490WC WHERE NombrePermisoSimple490WC = @nombre";
                            using (SqlCommand cmdDelRel = new SqlCommand(deleteRel, conexion))
                            {
                                cmdDelRel.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelRel.ExecuteNonQuery();
                            }

                            // 2.b Eliminar relaciones con perfiles si las hay
                            string deletePerfilRel = "DELETE FROM PermisoSimple_Perfil490WC WHERE NombrePermisoSimple490WC = @nombre";
                            using (SqlCommand cmdDelPerfil = new SqlCommand(deletePerfilRel, conexion))
                            {
                                cmdDelPerfil.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelPerfil.ExecuteNonQuery();
                            }

                            // 2.c Eliminar el permiso simple
                            string deleteSimple = "DELETE FROM PermisoSimple490WC WHERE Nombre490WC = @nombre";
                            using (SqlCommand cmdDel = new SqlCommand(deleteSimple, conexion))
                            {
                                cmdDel.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDel.ExecuteNonQuery();
                            }

                            return true;
                        }
                    }

                    // 3. Verificar si es una Familia
                    string queryEsFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombre";
                    using (SqlCommand cmdVerificarFamilia = new SqlCommand(queryEsFamilia, conexion))
                    {
                        cmdVerificarFamilia.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                        int countFamilia = (int)cmdVerificarFamilia.ExecuteScalar();

                        if (countFamilia > 0)
                        {
                            // 3.a Eliminar relaciones Familia-Familia
                            string deleteRelFF = "DELETE FROM Familia_Familia490WC WHERE NombreFamiliaIncluye490WC = @nombre OR NombreFamiliaIncluida490WC = @nombre";
                            using (SqlCommand cmdDelFF = new SqlCommand(deleteRelFF, conexion))
                            {
                                cmdDelFF.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelFF.ExecuteNonQuery();
                            }

                            // 3.b Eliminar relaciones Familia - PermisoSimple
                            string deleteRelPS = "DELETE FROM PermisoSimple_Familia490WC WHERE NombreFamilia490WC = @nombre";
                            using (SqlCommand cmdDelPS = new SqlCommand(deleteRelPS, conexion))
                            {
                                cmdDelPS.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelPS.ExecuteNonQuery();
                            }

                            // 3.c Eliminar relaciones con perfiles si las hay
                            string deletePerfilRel = "DELETE FROM Perfil_Familia490WC WHERE NombreFamilia490WC = @nombre";
                            using (SqlCommand cmdDelPerfil = new SqlCommand(deletePerfilRel, conexion))
                            {
                                cmdDelPerfil.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelPerfil.ExecuteNonQuery();
                            }

                            // 3.d Eliminar la familia
                            string deleteFamilia = "DELETE FROM Familia490WC WHERE Nombre490WC = @nombre";
                            using (SqlCommand cmdDel = new SqlCommand(deleteFamilia, conexion))
                            {
                                cmdDel.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDel.ExecuteNonQuery();
                            }

                            return true;
                        }
                    }

                    // 4. Verificar si es un Perfil (Rol)
                    string queryEsPerfil = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombre";
                    using (SqlCommand cmdVerificarPerfil = new SqlCommand(queryEsPerfil, conexion))
                    {
                        cmdVerificarPerfil.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                        int countPerfil = (int)cmdVerificarPerfil.ExecuteScalar();

                        if (countPerfil > 0)
                        {
                            // 4.a Eliminar relaciones Perfil - PermisoSimple
                            string deleteRelPS = "DELETE FROM PermisoSimple_Perfil490WC WHERE NombrePerfil490WC = @nombre";
                            using (SqlCommand cmdDelPS = new SqlCommand(deleteRelPS, conexion))
                            {
                                cmdDelPS.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelPS.ExecuteNonQuery();
                            }

                            // 4.b Eliminar relaciones Perfil - Familia
                            string deleteRelFam = "DELETE FROM Perfil_Familia490WC WHERE NombrePerfil490WC = @nombre";
                            using (SqlCommand cmdDelFam = new SqlCommand(deleteRelFam, conexion))
                            {
                                cmdDelFam.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelFam.ExecuteNonQuery();
                            }

                            // 4.c Eliminar el perfil
                            string deletePerfil = "DELETE FROM Perfil490WC WHERE Nombre490WC = @nombre";
                            using (SqlCommand cmdDel = new SqlCommand(deletePerfil, conexion))
                            {
                                cmdDel.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDel.ExecuteNonQuery();
                            }

                            return true;
                        }
                    }
                }

                // No se encontró como simple, familia ni rol
                return false;
            }
            catch
            {
                return false;
            }
        }


        public bool AlgunaFamiliaQuedariaVaciaAlEliminarElemento(string nombreElemento)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                // Obtener todas las familias que incluyen al elemento
                List<string> familiasPadre = new List<string>();

                // 1. Familias que tienen al permiso simple
                string query1 = "SELECT NombreFamilia490WC FROM PermisoSimple_Familia490WC WHERE NombrePermisoSimple490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(query1, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreElemento);
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                            familiasPadre.Add(lector["NombreFamilia490WC"].ToString());
                    }
                }

                // 2. Familias que tienen a otra familia como hija
                string query2 = "SELECT NombreFamiliaIncluye490WC FROM Familia_Familia490WC WHERE NombreFamiliaIncluida490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(query2, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreElemento);
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["NombreFamiliaIncluye490WC"].ToString();
                            if (!familiasPadre.Contains(nombre))
                                familiasPadre.Add(nombre);
                        }
                    }
                }

                // Ahora por cada familia padre, verificar si quedaría vacía al eliminar el elemento
                foreach (string familia in familiasPadre)
                {
                    // Verificar si tiene más permisos simples distintos del que se quiere eliminar
                    string querySimples = "SELECT COUNT(*) FROM PermisoSimple_Familia490WC WHERE NombreFamilia490WC = @familia AND NombrePermisoSimple490WC <> @elemento";

                    using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                    {
                        cmd.Parameters.AddWithValue("@familia", familia);
                        cmd.Parameters.AddWithValue("@elemento", nombreElemento);
                        int countSimples = (int)cmd.ExecuteScalar();
                        if (countSimples > 0) continue; // No queda vacía
                    }

                    // Verificar si tiene más familias hijas distintas de la que se quiere eliminar
                    string queryFamilias = @"SELECT COUNT(*) FROM Familia_Familia490WC WHERE NombreFamiliaIncluye490WC = @familia AND NombreFamiliaIncluida490WC <> @elemento";

                    using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                    {
                        cmd.Parameters.AddWithValue("@familia", familia);
                        cmd.Parameters.AddWithValue("@elemento", nombreElemento);
                        int countFamilias = (int)cmd.ExecuteScalar();
                        if (countFamilias > 0) continue; // No queda vacía
                    }

                    // Si no tiene ni permisos simples ni otras familias hijas -> quedaría vacía
                    return true;
                }

                return false;
            }
        }


        public bool PerfilQuedariaVacioAlEliminarElemento(string nombreElemento)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                // Obtener todos los perfiles que tienen asignado el elemento como familia
                List<string> perfiles = new List<string>();

                string queryFamilia = "SELECT NombrePerfil490WC FROM Perfil_Familia490WC WHERE NombreFamilia490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(queryFamilia, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreElemento);
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                            perfiles.Add(lector["NombrePerfil490WC"].ToString());
                    }
                }

                // Obtener todos los perfiles que tienen asignado el elemento como permiso simple
                string queryPermisoSimple = "SELECT NombrePerfil490WC FROM Perfil_PermisoSimple490WC WHERE NombrePermisoSimple490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(queryPermisoSimple, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreElemento);
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string perfil = lector["NombrePerfil490WC"].ToString();
                            if (!perfiles.Contains(perfil))
                                perfiles.Add(perfil);
                        }
                    }
                }

                // Ahora verificamos para cada perfil si quedaría vacío
                foreach (string perfil in perfiles)
                {
                    // ¿Tiene otras familias distintas del elemento?
                    string queryOtrasFamilias = "SELECT COUNT(*) FROM Perfil_Familia490WC WHERE NombrePerfil490WC = @perfil AND NombreFamilia490WC <> @elemento";
                    using (SqlCommand cmd = new SqlCommand(queryOtrasFamilias, conexion))
                    {
                        cmd.Parameters.AddWithValue("@perfil", perfil);
                        cmd.Parameters.AddWithValue("@elemento", nombreElemento);
                        int otrasFamilias = (int)cmd.ExecuteScalar();
                        if (otrasFamilias > 0) continue;
                    }

                    // ¿Tiene otros permisos simples distintos del elemento?
                    string queryOtrosSimples = "SELECT COUNT(*) FROM Perfil_PermisoSimple490WC WHERE NombrePerfil490WC = @perfil AND NombrePermisoSimple490WC <> @elemento";
                    using (SqlCommand cmd = new SqlCommand(queryOtrosSimples, conexion))
                    {
                        cmd.Parameters.AddWithValue("@perfil", perfil);
                        cmd.Parameters.AddWithValue("@elemento", nombreElemento);
                        int otrosSimples = (int)cmd.ExecuteScalar();
                        if (otrosSimples > 0) continue;
                    }

                    // Si no tiene nada más → quedaría vacío
                    return true;
                }

                return false;
            }
        }

    

        public bool EliminarRelacionPermisoSimple_Perfil(string nombrePerfil, string nombrePermisoSimple)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM Perfil_PermisoSimple490WC WHERE nombrePerfil490WC = @perfil AND nombrePermisoSimple490WC = @permiso";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                        cmd.Parameters.AddWithValue("@permiso", nombrePermisoSimple);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarRelacionPermisoSimple_Familia(string nombreFamilia, string nombrePermisoSimple)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM PermisoSimple_Familia490WC WHERE nombreFamilia490WC = @familia AND nombrePermisoSimple490WC = @permiso";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@familia", nombreFamilia);
                        cmd.Parameters.AddWithValue("@permiso", nombrePermisoSimple);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarRelacionFamilia_Familia(string familiaPadre, string familiaHija)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM Familia_Familia490WC WHERE NombreFamiliaIncluye490WC = @padre AND NombreFamiliaIncluida490WC = @hija";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@padre", familiaPadre);
                        cmd.Parameters.AddWithValue("@hija", familiaHija);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarRelacionPerfil_Familia(string nombrePerfil, string nombreFamilia)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM Perfil_Familia490WC WHERE nombrePerfil490WC = @perfil AND nombreFamilia490WC = @familia";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                        cmd.Parameters.AddWithValue("@familia", nombreFamilia);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


     

        public bool FamiliaExiste490WC(string nombreFamilia)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreFamilia);
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        return cantidad > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool PerfilExiste490WC(string nombrePerfil)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombrePerfil);
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        return cantidad > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


     
        public List<Permiso490WC> ObtenerPermisos490WC()
        {
            List<Permiso490WC> permisosTotales = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    
                    string querySimples = "SELECT Nombre490WC FROM PermisoSimple490WC";
                    using (SqlCommand cmdSimples = new SqlCommand(querySimples, conexion))
                    using (SqlDataReader lector = cmdSimples.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            permisosTotales.Add(new PermisoSimple490WC(nombre));
                        }
                    }

                    // 2. Leer familias
                    string queryFamilias = "SELECT Nombre490WC FROM Familia490WC";
                    using (SqlCommand cmdFamilias = new SqlCommand(queryFamilias, conexion))
                    using (SqlDataReader lector = cmdFamilias.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            permisosTotales.Add(new PermisoCompuesto490WC(nombre));
                        }
                    }
                }
            }
            catch
            {
                permisosTotales.Clear(); 
            }

            return permisosTotales;
        }


     
        public List<Permiso490WC> ObtenerPermisosSimples490WC()
        {
            List<Permiso490WC> ListaPermisos490WC = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    // Leer de la tabla actual según el DER aprobado
                    string query = "SELECT Nombre490WC FROM PermisoSimple490WC";

                    using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            ListaPermisos490WC.Add(new PermisoSimple490WC(nombre));
                        }
                    }
                }

                return ListaPermisos490WC;
            }
            catch
            {
                ListaPermisos490WC.Clear();
                return ListaPermisos490WC;
            }
        }


        

        public List<Permiso490WC> ObtenerPermisosCompuestos490WC()
        {
            List<Permiso490WC> ListaPermisosCompuestos490WC = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    
                    string query = "SELECT Nombre490WC FROM Familia490WC";

                    using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            ListaPermisosCompuestos490WC.Add(new PermisoCompuesto490WC(nombre));
                        }
                    }
                }

                return ListaPermisosCompuestos490WC;
            }
            catch
            {
                ListaPermisosCompuestos490WC.Clear();
                return ListaPermisosCompuestos490WC;
            }
        }



        public List<Permiso490WC> ObtenerRoles490WC()
        {
            List<Permiso490WC> ListaRoles490WC = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    string query = "SELECT Nombre490WC FROM Perfil490WC";

                    using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            ListaRoles490WC.Add(new PermisoCompuesto490WC(nombre));
                        }
                    }
                }

                return ListaRoles490WC;
            }
            catch
            {
                ListaRoles490WC.Clear();
                return ListaRoles490WC;
            }
        }


    }
}
