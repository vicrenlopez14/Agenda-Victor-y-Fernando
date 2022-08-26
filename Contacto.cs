using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A_Agenda_Victor_Fernando
{
    public class Contacto
    {
        public Contacto() { }

        public Contacto(string id, string nombre, string dirección, string teléfono, string email, string país, byte[] foto)
        {
            Id = id;
            Nombre = nombre;
            Dirección = dirección;
            Teléfono = teléfono;
            Email = email;
            País = país;
            Foto = foto;
        }

        public string Id { get; set; }
        public string Nombre { get; set; } = "Sin nombre";
        public string Dirección { get; set; } = "Dirección desconocida";
        public string Teléfono { get; set; } = "Teléfono deconocido";
        public string Email { get; set; } = "Correo no especificado";
        public string País { get; set; } = "País no reconocido";
        public byte[] Foto { get; set; }

        public static DataTable LeerContactos()
        {
            try
            {
                // Aquí cambiá las queries
                return MySimpleConnection.Services.MySimpleConnection.ExecuteQueryInDatabase(
                    "SELECT nombreProducto, descripcionProducto, precioProducto, nombreCategoria, nombreProveedor FROM Producto INNER JOIN Categoria ON Producto.idCategoria = Categoria.idCategoria INNER JOIN Proveedor ON Producto.idProveedor = Proveedor.idProveedor;");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        public static DataTable BuscarContactos(string nombre)
        {
            try
            {
                // Aquí cambiá las queries
                return MySimpleConnection.Services.MySimpleConnection.ExecuteQueryInDatabase(
                    "SELECT nombreProducto, descripcionProducto, precioProducto, nombreCategoria, nombreProveedor FROM Producto INNER JOIN Categoria ON Producto.idCategoria = Categoria.idCategoria INNER JOIN Proveedor ON Producto.idProveedor = Proveedor.idProveedor;");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public static List<Contacto> LeerContactosAsProducto()
        {
            var dt = new DataTable();
            try
            {
                dt = LeerContactos();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            var listaContactos = new List<Contacto>();
            foreach (DataRow row in dt.Rows)
            {
                listaContactos.Add(new Contacto
                {
                    Id = row["idProducto"].ToString(),
                    Nombre = row["nombreProducto"].ToString(),
                    Dirección = row["descripcionProducto"].ToString(),
                    Teléfono = row["precioProducto"].ToString(),
                    Email = row["nombreCategoria"].ToString(),
                    País = row["nombreProveedor"].ToString(),
                    Foto = (byte[])row["foto"]
                });
            }

            return listaContactos;

        }

        public static List<Contacto> LeerContactosBuscadosAsContacto(string nombre)
        {
            var dt = new DataTable();
            try
            {
                dt = BuscarContactos(nombre);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            var listaContactos = new List<Contacto>();
            foreach (DataRow row in dt.Rows)
            {
                listaContactos.Add(new Contacto
                {
                    Id = row["idProducto"].ToString(),
                    Nombre = row["nombreProducto"].ToString(),
                    Dirección = row["descripcionProducto"].ToString(),
                    Teléfono = row["precioProducto"].ToString(),
                    Email = row["nombreCategoria"].ToString(),
                    País = row["nombreProveedor"].ToString(),
                    Foto = (byte[])row["foto"]
                });
            }

            return listaContactos;

        }

        public bool Crear()
        {
            return true;
        }

        public bool Eliminar()
        {
            return true;
        }

        public bool Actualizar()
        {
            return true;
        }
    }
}
