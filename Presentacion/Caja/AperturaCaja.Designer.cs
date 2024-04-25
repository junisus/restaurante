namespace RestCsharp.Presentacion.Caja
{
    partial class AperturaCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AperturaCaja));
            this.PanelCaja = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panelbotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnOmitir = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PanelCaja.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCaja
            // 
            this.PanelCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelCaja.Controls.Add(this.panel3);
            this.PanelCaja.Controls.Add(this.Panelbotones);
            this.PanelCaja.Controls.Add(this.BtnOmitir);
            this.PanelCaja.Controls.Add(this.BtnIniciar);
            this.PanelCaja.Controls.Add(this.Panel2);
            this.PanelCaja.Controls.Add(this.Label9);
            this.PanelCaja.Controls.Add(this.Label1);
            this.PanelCaja.Location = new System.Drawing.Point(192, 15);
            this.PanelCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelCaja.Name = "PanelCaja";
            this.PanelCaja.Size = new System.Drawing.Size(605, 702);
            this.PanelCaja.TabIndex = 568;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtmonto);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(41, 145);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 52);
            this.panel3.TabIndex = 569;
            // 
            // txtmonto
            // 
            this.txtmonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmonto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtmonto.ForeColor = System.Drawing.Color.White;
            this.txtmonto.Location = new System.Drawing.Point(0, 16);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(449, 29);
            this.txtmonto.TabIndex = 564;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 6);
            this.panel4.TabIndex = 570;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 1);
            this.panel1.TabIndex = 569;
            // 
            // Panelbotones
            // 
            this.Panelbotones.Location = new System.Drawing.Point(41, 271);
            this.Panelbotones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panelbotones.Name = "Panelbotones";
            this.Panelbotones.Size = new System.Drawing.Size(383, 422);
            this.Panelbotones.TabIndex = 568;
            // 
            // BtnOmitir
            // 
            this.BtnOmitir.BackgroundImage = global::RestCsharp.Properties.Resources.verde;
            this.BtnOmitir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOmitir.FlatAppearance.BorderSize = 0;
            this.BtnOmitir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnOmitir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnOmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOmitir.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOmitir.ForeColor = System.Drawing.Color.White;
            this.BtnOmitir.Location = new System.Drawing.Point(165, 204);
            this.BtnOmitir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOmitir.Name = "BtnOmitir";
            this.BtnOmitir.Size = new System.Drawing.Size(116, 59);
            this.BtnOmitir.TabIndex = 567;
            this.BtnOmitir.Text = "Omitir";
            this.BtnOmitir.UseVisualStyleBackColor = true;
            this.BtnOmitir.Click += new System.EventHandler(this.BtnOmitir_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackgroundImage = global::RestCsharp.Properties.Resources.azul;
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(41, 204);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(116, 59);
            this.BtnIniciar.TabIndex = 566;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.ForeColor = System.Drawing.Color.White;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(605, 74);
            this.Panel2.TabIndex = 565;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(605, 74);
            this.Label2.TabIndex = 532;
            this.Label2.Text = "Dinero en Caja";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(16, 92);
            this.Label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(0, 17);
            this.Label9.TabIndex = 533;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(33, 92);
            this.Label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(399, 39);
            this.Label1.TabIndex = 511;
            this.Label1.Text = "¿Efectivo inicial en Caja?";
            // 
            // AperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1069, 762);
            this.Controls.Add(this.PanelCaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apertura caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AperturaCaja_Load);
            this.PanelCaja.ResumeLayout(false);
            this.PanelCaja.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PanelCaja;
        private System.Windows.Forms.Button BtnOmitir;
        private System.Windows.Forms.Button BtnIniciar;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtmonto;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.FlowLayoutPanel Panelbotones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}