using _2A_Agenda_Victor_Fernando;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paneles_VictorLopez_2A
{
    public partial class ContactCard : UserControl
    {
        Contacto contact;

        public ContactCard(Contacto contactParam)
        {
            InitializeComponent();
            contact = contactParam;

            LoadData();
        }
        private void LoadData()
        {

            Nombre_tb.Text = contact.Nombre;
            Direccion_tb.Text = contact.Dirección;
            Telefono_tb.Text = contact.Teléfono;
            Email_tb.Text = contact.Email;
            Pais_tb.Text = contact.País;
            Picture_pb.Image = ByteToImage(contact.Foto);
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }

        private void ContactCard_DoubleClick(object sender, EventArgs e)
        {
            new ManipularContactoForm(contact).ShowDialog();
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
