using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager.CLS
{
    public class Cache
    {
        // CONSULTA PARA INICIO DE SESION
        public static DataTable INICIAR_SESION(String pUsuario, String pClave)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Usuario, a.ID_Rol, a.ID_Empleado, a.Usuario, 
                                CONCAT(b.Nombres,' ',b.Apellidos) Empleado, c.Rol 
                                FROM usuarios a, empleados b, roles c 
                                WHERE a.Usuario='" + pUsuario + @"'
                                AND a.Clave = SHA1(MD5('" + pClave + @"'))
                                AND a.ID_Empleado = b.ID_Empleado
                                AND a.ID_Rol = c.ID_Rol; ";
            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }
            return Resultados;
        }

        // CONSULTA DE TODOS LOS CLIENTES DE TIPO EMPRESA
        public static DataTable TODOS_LOS_CLIENTES_EMPRESA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select ID_Cliente, Tipo_Cliente, Nombre_Empresa, NIT, Telefono, Direccion, Correo from Clientes where Tipo_Cliente ='Empresa' order by ID_Cliente;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // CONSULTA PARA TODOS LOS CLIENTES DE TIPO PERSONA NATURAL
        public static DataTable TODOS_LOS_CLIENTES_PERSONA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select ID_Cliente, Tipo_Cliente, Nombres_Cliente, Apellidos_Cliente, DUI, NIT, Telefono, Direccion, Correo from Clientes where Tipo_Cliente ='Persona Natural' order by ID_Cliente;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // CONSULTA DE TODOS LOS EMPLEADOS
        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select ID_Empleado, DUI, NIT, Nombres, Apellidos, FechaNacimiento, Genero, Telefono, Direccion, Correo from Empleados order by ID_Empleado;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // CONSULTA SELECCIONAR EMPLEADO
        public static DataTable SELECCIONAR_EMPLEADO(String pIDEmpleado)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Empleado, DUI, NIT, Nombres, Apellidos, FechaNacimiento, Genero, Telefono, Direccion, Correo FROM empleados 
                                WHERE ID_Empleado = "+pIDEmpleado+";";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // CONSULTA DE TODOS LOS USUARIOS
        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Empleado, ID_Usuario, Usuario, Clave, ID_Rol FROM usuarios order by ID_Empleado;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // CONSULTA SELECCIONAR UN USUARIO
        public static DataTable SELECCIONAR_USUARIO(String pIDUsuario)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Empleado, b.Nombres, a.ID_Usuario, a.Usuario, a.Clave, a.ID_Rol 
                                FROM usuarios a, empleados b 
                                WHERE a.ID_Usuario = "+pIDUsuario+" AND a.ID_Empleado = b.ID_Empleado;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // CONSULTA DE TODOS LOS ROLES
        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Rol, Rol FROM roles ORDER BY ID_Rol;";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // CONSULTA PARA SELECCIONAR UN ROLES
        public static DataTable SELECCIONAR_ROL(String pIDRol)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Rol, Rol FROM roles WHERE ID_Rol = "+pIDRol+";";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        // VER TODOS LOS PERMISOS
        public static DataTable PERMISOS_DE_UN_ROL(String pIDRol)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                a.ID_Opcion, 
                                a.Opcion, 
                                IF(IFNULL((SELECT ID_Permiso FROM permisos z WHERE z.ID_Rol = " + pIDRol + @" AND z.ID_Opcion = a.ID_Opcion), 0) = 0, 0, 1) Seleccion,
                                IFNULL((SELECT ID_Permiso FROM permisos z WHERE z.ID_Rol = " + pIDRol + @" AND z.ID_Opcion = a.ID_Opcion), 0) as ID_Permiso
                                FROM opciones a
                                ORDER BY ID_Opcion ASC;";
            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }
            return Resultados;
        }

        // VER TODOS LOS PERMISOS DE UN USUARIO
        public static DataTable PERMISOS_DE_UN_USUARIO(String pIDRol)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT DISTINCT a.ID_Opcion, b.Opcion 
                                FROM permisos a, opciones b 
                                WHERE a.ID_Opcion=b.ID_Opcion 
                                AND a.ID_Rol="+pIDRol+";";
            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }
            return Resultados;
        }

        public static DataTable SELECCIONAR_CLIENTE_PERSONA(String pIDCliente)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Cliente, DUI, NIT, Nombres_Cliente, Apellidos_Cliente, Telefono, Direccion, Correo FROM clientes 
                                WHERE ID_Cliente = " + pIDCliente + ";";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }

        public static DataTable SELECCIONAR_CLIENTE_EMPRESA(String pIDCliente)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Cliente, Nombre_Empresa, NIT, Telefono, Direccion, Correo FROM clientes 
                                WHERE ID_Cliente = " + pIDCliente + ";";

            try
            {
                Resultados = Consultor.Consultar(Consulta);
            }
            catch
            {
                Resultados = new DataTable();
            }

            return Resultados;
        }
    }
}
