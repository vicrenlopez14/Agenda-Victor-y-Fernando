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
        => CargarTarjetas(Contacto.LeerContactosAsProducto());


        public void CargarTarjetas(List<Contacto> contacts)
        {
            foreach (var contactito in contacts)
            {

                var contactCard = new ContactCard(contactito);

                Contactos_ListView.Controls.Add(contactCard);

            }
        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            new ManipularContactoForm().ShowDialog();
        }

        private void Seleccionar_btn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        => CargarTarjetas(Contacto.LeerContactosBuscadosAsContacto(Buscar_tb.Text));
    }
}