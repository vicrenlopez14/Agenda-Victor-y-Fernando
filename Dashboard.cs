using Paneles_VictorLopez_2A;

namespace _2A_Agenda_Victor_Fernando
{
    public partial class Agenda_fm : Form
    {
        public Agenda_fm()
        {
            InitializeComponent();
        }

        private void Agenda_fm_Load(object sender, EventArgs e)
        {
            var productos = Contacto.LeerProductosAsProducto();

            foreach (var producto in productos)
            {

                var productCard = new ContactCard(producto);

                Contactos_ListView.Controls.Add(productCard);

            }
        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            new ManipularContactoForm().ShowDialog();
        }

        private void Seleccionar_btn_Click(object sender, EventArgs e)
        {

        }
    }
}