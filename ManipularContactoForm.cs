using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2A_Agenda_Victor_Fernando
{
    public partial class ManipularContactoForm : Form
    {
        Contacto toManipulate = new Contacto();

        public ManipularContactoForm()
        {
            InitializeComponent();
            CreateMode();
        }

        public ManipularContactoForm(Contacto contactParam)
        {
            InitializeComponent();
            toManipulate = contactParam;
            EditMode();
        }

        public void EditMode()
        {
            Actualizar_btn.Visible = true;
            Eliminar_btn.Visible = true;
            Crear_btn.Visible = false;
            LoadData();
        }

        public void CreateMode()
        {
            Actualizar_btn.Visible = false;
            Eliminar_btn.Visible = false;
            Crear_btn.Visible = true;
            toManipulate = new Contacto();
        }

        public void LoadData()
        {
            Nombre_txt.Text = toManipulate.Nombre;
            Dirección_txt.Text = toManipulate.Dirección;
            Teléfono_txt.Text = toManipulate.Teléfono;
            Email_txt.Text = toManipulate.Email;
            País_cb.Text = toManipulate.País;
            Picture_pb.Image = ByteToImage(toManipulate.Foto);
        }


        private void ManipularContactoForm_Load(object sender, EventArgs e)
        {

        }

        private void Crear_btn_Click(object sender, EventArgs e)
        {

            if (toManipulate.Crear())
            {
                MessageBox.Show("Contacto creado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al crear el contacto");
            }
        }

        private void Actualizar_btn_Click(object sender, EventArgs e)
        {
            if (toManipulate.Actualizar())
            {
                MessageBox.Show("Actualizado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            if (toManipulate.Eliminar())
            {
                MessageBox.Show("Contacto eliminado exitosamente");
                this.Close();
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
