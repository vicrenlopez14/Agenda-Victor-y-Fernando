﻿using _2A_Agenda_Victor_Fernando;
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
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }

        private void ContactCard_DoubleClick(object sender, EventArgs e)
        {
            new ManipularContactoForm(contact).ShowDialog();
        }
    }
}
