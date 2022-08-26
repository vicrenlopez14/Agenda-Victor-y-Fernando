namespace _2A_Agenda_Victor_Fernando
{
    partial class Agenda_fm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Contactos_ListView = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Seleccionar_btn = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.Agregar_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Contactos_ListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.73237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.26763F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Contactos_ListView
            // 
            this.Contactos_ListView.AutoScroll = true;
            this.Contactos_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contactos_ListView.Location = new System.Drawing.Point(3, 90);
            this.Contactos_ListView.Name = "Contactos_ListView";
            this.Contactos_ListView.Size = new System.Drawing.Size(976, 460);
            this.Contactos_ListView.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Seleccionar_btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Titulo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Agregar_btn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(976, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Seleccionar_btn
            // 
            this.Seleccionar_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Seleccionar_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seleccionar_btn.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seleccionar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Seleccionar_btn.Location = new System.Drawing.Point(735, 3);
            this.Seleccionar_btn.Name = "Seleccionar_btn";
            this.Seleccionar_btn.Size = new System.Drawing.Size(238, 75);
            this.Seleccionar_btn.TabIndex = 4;
            this.Seleccionar_btn.Text = "Seleccionar";
            this.Seleccionar_btn.UseVisualStyleBackColor = false;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(3, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(482, 81);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Mi Tilino - Agenda";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Agregar_btn
            // 
            this.Agregar_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Agregar_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Agregar_btn.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Agregar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Agregar_btn.Location = new System.Drawing.Point(491, 3);
            this.Agregar_btn.Name = "Agregar_btn";
            this.Agregar_btn.Size = new System.Drawing.Size(238, 75);
            this.Agregar_btn.TabIndex = 3;
            this.Agregar_btn.Text = "Agregar";
            this.Agregar_btn.UseVisualStyleBackColor = false;
            this.Agregar_btn.Click += new System.EventHandler(this.Agregar_btn_Click);
            // 
            // Agenda_fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agenda_fm";
            this.Text = "Mi Tilino";
            this.Load += new System.EventHandler(this.Agenda_fm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Titulo;
        private FlowLayoutPanel Contactos_ListView;
        private Button Seleccionar_btn;
        private Button Agregar_btn;
    }
}