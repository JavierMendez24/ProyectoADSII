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

        // VER TODOS LOS CLIENTES DE TIPO PERSONA
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

        // VER TODOS LOS CLIENTES DE TIPO EMPRESA
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

        // VER TODOS LOS CONTRATOS EMPRESA
        public static DataTable TODOS_LOS_CONTRATOS_EMPRESA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Contrato, b.Nombre_Empresa, a.Numero_Zonas, a.Costo_Arrendamiento, a.Inicio_Arrendamiento, a.Fin_Arrendamiento, a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.Tipo_Contrato = 'Empresa' AND a.ID_Cliente = b.ID_Cliente
                                ORDER BY ID_Contrato;";

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

        // VER TODOS LOS CONTRATOS PERSONA
        public static DataTable TODOS_LOS_CONTRATOS_PERSONA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Contrato, b.Nombres_cliente, a.Numero_Zonas, a.Costo_Arrendamiento, a.Inicio_Arrendamiento, a.Fin_Arrendamiento, a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.Tipo_Contrato = 'Persona Natural' AND a.ID_Cliente = b.ID_Cliente
                                ORDER BY ID_Contrato;";

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

        // VER EL CONTRATO ACTUAL
        public static DataTable CONTRATO_ACTUAL()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Contrato, b.Nombre_Empresa, a.Numero_Zonas, a.Costo_Arrendamiento, a.Inicio_Arrendamiento, a.Fin_Arrendamiento, a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.ID_Cliente = b.ID_Cliente
                                ORDER BY ID_Contrato DESC
                                LIMIT 1;";

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

        // VER TODAS LAS ZONAS
        public static DataTable TODAS_LAS_ZONAS()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                a.ID_Zona, 
                                a.Nombre_Zona, 
                                IF(IFNULL((SELECT ID_Detalle_Contrato FROM Detalle_Contrato z WHERE z.ID_Zona = a.ID_Zona), 0) = 0, 0, 1) Seleccion,
                                IFNULL((SELECT ID_Detalle_Contrato FROM Detalle_Contrato z WHERE z.ID_Zona = a.ID_Zona), 0) as ID_Detalle_Contrato,
                                (SELECT b.Nombre_Bodega FROM bodegas b WHERE b.ID_Bodega = a.ID_Bodega) Nombre_Bodega
                                FROM zonas a
                                ORDER BY ID_Zona ASC;";

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

        // OBTENER LA CANTIDAD DE ZONAS SIN CONTRATO
        public static DataTable TODAS_LAS_ZONAS_SIN_CONTRATO()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT SUM(ISNULL(ID_Contrato)) Zonas FROM Detalle_Contrato;";

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

        // OBTENER LAS ZONAS DEL CONTRATO
        public static DataTable TODAS_LAS_ZONAS_ASIGNADAS(String pIDContrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT GROUP_CONCAT(x.Nombre_Zona SEPARATOR ', ') Zonas FROM zonas x, detalle_contrato v, contratos a WHERE x.ID_Zona = v.ID_Zona AND v.ID_Contrato = a.ID_Contrato AND a.ID_Contrato = "+pIDContrato+";";

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

        // SELECCION DEL CONTRATO
        public static DataTable SELECCIONAR_CONTRATO_EMPRESA(String pIDContrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Contrato, b.Nombre_Empresa, a.Numero_Zonas, a.Costo_Arrendamiento, a.Inicio_Arrendamiento, a.Fin_Arrendamiento, a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.Tipo_Contrato = 'Empresa' AND a.ID_Cliente = b.ID_Cliente AND a.ID_Contrato = "+pIDContrato+@"
                                ORDER BY ID_Contrato;";

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

        public static DataTable SELECCIONAR_CONTRATO_PERSONA(String pIDContrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Contrato, b.Nombres_cliente, a.Numero_Zonas, a.Costo_Arrendamiento, a.Inicio_Arrendamiento, a.Fin_Arrendamiento, a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.Tipo_Contrato = 'Persona Natural' AND a.ID_Cliente = b.ID_Cliente AND a.ID_Contrato = " + pIDContrato + @"
                                ORDER BY ID_Contrato;";

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

        // VER LOS DETALLES DE UN CONTRATO TIPO EMPRESA
        public static DataTable DETALLES_CONTRATO_EMPRESA(String pIDContrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                a.ID_Contrato, 
                                b.Nombre_Empresa, 
                                a.Numero_Zonas, 
                                (SELECT GROUP_CONCAT(x.Nombre_Zona SEPARATOR ', ') FROM zonas x, detalle_contrato v WHERE x.ID_Zona = v.ID_Zona AND v.ID_Contrato = a.ID_Contrato) Zonas,
                                a.Costo_Arrendamiento, 
                                IF((SELECT a.Costo_Arrendamiento*TIMESTAMPDIFF(MONTH, a.Inicio_Arrendamiento, a.Fin_Arrendamiento)) > 0, 
                                (SELECT a.Costo_Arrendamiento*TIMESTAMPDIFF(MONTH, a.Inicio_Arrendamiento, a.Fin_Arrendamiento)), 
                                (SELECT a.Costo_Arrendamiento)) Costo_Total,
                                a.Inicio_Arrendamiento, 
                                a.Fin_Arrendamiento, 
                                (SELECT CONCAT(TIMESTAMPDIFF(MONTH, a.Inicio_Arrendamiento, a.Fin_Arrendamiento), ' Meses ')) Duracion,
                                a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.Tipo_Contrato = 'Empresa' AND a.ID_Cliente = b.ID_Cliente AND a.ID_Contrato = "+pIDContrato+@"
                                ORDER BY ID_Contrato;";

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

        // VER LOS DETALLES DE UN CONTRATO TIPO PERSONA
        public static DataTable DETALLES_CONTRATO_PERSONA(String pIDContrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                a.ID_Contrato, 
                                b.Nombres_cliente, 
                                a.Numero_Zonas, 
                                (SELECT GROUP_CONCAT(x.Nombre_Zona SEPARATOR ', ') FROM zonas x, detalle_contrato v WHERE x.ID_Zona = v.ID_Zona AND v.ID_Contrato = a.ID_Contrato) Zonas,
                                a.Costo_Arrendamiento, 
                                IF((SELECT a.Costo_Arrendamiento*TIMESTAMPDIFF(MONTH, a.Inicio_Arrendamiento, a.Fin_Arrendamiento)) > 0, 
                                (SELECT a.Costo_Arrendamiento*TIMESTAMPDIFF(MONTH, a.Inicio_Arrendamiento, a.Fin_Arrendamiento)), 
                                (SELECT a.Costo_Arrendamiento)) Costo_Total,
                                a.Inicio_Arrendamiento, 
                                a.Fin_Arrendamiento, 
                                (SELECT CONCAT(TIMESTAMPDIFF(MONTH, a.Inicio_Arrendamiento, a.Fin_Arrendamiento), ' Meses ')) Duracion,
                                a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.Tipo_Contrato = 'Persona Natural' AND a.ID_Cliente = b.ID_Cliente AND a.ID_Contrato = " + pIDContrato + @"
                                ORDER BY ID_Contrato;";

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

        // VER TODOS LOS PRODUCTOS EN EL CATALOGO
        public static DataTable PRODUCTOS_CATALOGO()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"select ID_Catalogo, Marca, Nombre_Producto, Categoria, Descripcion from Catalogo order by ID_Catalogo;";

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

        // SELECCION DEL PRODUCTO EN EL CATALOGO
        public static DataTable SELECCIONAR_PRODUCTO_CATALOGO(String pID_Catalogo)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Catalogo, Nombre_Producto, Marca, Categoria, Descripcion FROM catalogo 
                                WHERE ID_Catalogo = " + pID_Catalogo + ";";

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

        // VER TODOS LOS PRODUCTOS EN BODEGA
        public static DataTable PRODUCTOS_LISTA_BODEGA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Producto, a.ID_Catalogo, b.Nombre_Producto, b.Marca, b.Categoria, a.Costo, a.Cantidad, a.Fecha_Vencimiento 
                                FROM productos a, catalogo b
                                WHERE a.ID_Catalogo = b.ID_Catalogo;";

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

        // SELECCION CONTRATO PARA LISTA DE PRODUCTOS
        public static DataTable SELECCIONAR_CONTRATO_LISTA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Contrato, (SELECT CONCAT(b.Nombres_Cliente, b.Nombre_Empresa)) Cliente, a.Tipo_Contrato, a.Inicio_Arrendamiento, a.Fin_Arrendamiento, a.Estado 
                                FROM contratos a, clientes b
                                WHERE a.ID_Cliente = b.ID_Cliente
                                ORDER BY a.ID_Contrato DESC;";

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

        // VER ZONAS DEL CONTRATO
        public static DataTable TODAS_LAS_ZONAS_DEL_CONTRATO(String pIDContrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Zona, a.Nombre_Zona 
                                FROM zonas a, detalle_contrato b
                                WHERE a.ID_Zona = b.ID_Zona AND b.ID_Contrato = "+pIDContrato+";";

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

        // SELECCIONAR EL PRODUCTO ACTUAL
        public static DataTable SELECCIONAR_EL_PRODUCTO_ACTUAL()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Producto 
                                FROM productos 
                                ORDER BY ID_Producto DESC 
                                LIMIT 1;";

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

        // SELECCIONAR EL CLIENTE PARA EL REGISTRO DE ENTRADA
        public static DataTable CLIENTE_PARA_REGISTRO_ENTRADA(String pIDContrato)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT 
                                a.ID_Contrato, 
                                (SELECT CONCAT(b.Nombre_Empresa, b.Nombres_Cliente, ' ', b.Apellidos_Cliente)) Cliente
                                FROM contratos a, clientes b
                                WHERE a.ID_Cliente = b.ID_Cliente
                                AND a.ID_Contrato = "+pIDContrato+@"
                                ORDER BY a.ID_Contrato DESC;";

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

        // VER EL ULTIMO MOVIMIENTO
        public static DataTable ULTIMO_MOVIMIENTO_ENTRADA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Movimiento FROM movimientos Order by ID_Movimiento desc limit 1;";

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

        // VER MOVIMIENTOS DE ENTRADA
        public static DataTable DATOS_MOVIMIENTO_ENTRADA()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Movimiento, Tipo_Movimiento, ID_Usuario, Fecha, Nombre_Cliente, Zona, Nombre_Producto, Marca, Costo, Cantidad_Anterior, Cantidad_Movimiento, Cantidad_Actual 
                                FROM movimientos 
                                Order by ID_Movimiento desc;";

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

        // FILTRAR RESULTADOS DE MOVIMIENTO
        public static DataTable REPORTE_DE_ENTRADA(String pZona, String pFecha)
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT a.ID_Movimiento, a.Tipo_Movimiento, b.Usuario, a.Fecha, a.Nombre_Cliente, a.Zona, a.Nombre_Producto, a.Marca, a.Costo, a.Cantidad_Anterior, a.Cantidad_Movimiento, a.Cantidad_Actual 
                                FROM movimientos a, usuarios b
                                WHERE a.ID_Usuario = b.ID_Usuario
                                AND a.Zona = '"+pZona+"' AND Fecha = '"+pFecha+@"'
                                Order by ID_Movimiento desc; ";

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

        // VER TODAS LAS ZONAS
        public static DataTable TODAS_LAS_ZONAS_REPORTE()
        {
            DataTable Resultados = new DataTable();
            DataManager.CLS.OperacionBD Consultor = new DataManager.CLS.OperacionBD();
            String Consulta = @"SELECT ID_Zona, Nombre_Zona FROM zonas;";

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
