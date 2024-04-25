
namespace RestCsharp.Presentacion.Reportes
{
    partial class Menureportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menureportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.panelCondicionales = new System.Windows.Forms.Panel();
            this.PanelEmpleado = new System.Windows.Forms.Panel();
            this.txtEmpleado = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnHoy = new System.Windows.Forms.Button();
            this.chekFiltros = new System.Windows.Forms.CheckBox();
            this.PanelFiltros = new System.Windows.Forms.Panel();
            this.TXTFF = new System.Windows.Forms.DateTimePicker();
            this.TXTFI = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MenuStrip6 = new System.Windows.Forms.MenuStrip();
            this.TFILTROS = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnResumenVentas = new System.Windows.Forms.Button();
            this.PResumenVentas = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.PVentasPorempleado = new System.Windows.Forms.Panel();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelCondicionales.SuspendLayout();
            this.PanelEmpleado.SuspendLayout();
            this.PanelFiltros.SuspendLayout();
            this.MenuStrip6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 642);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnVentas);
            this.flowLayoutPanel1.Controls.Add(this.btnProductos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 225);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 369);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVentas.Location = new System.Drawing.Point(5, 5);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(273, 43);
            this.btnVentas.TabIndex = 615;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductos.Location = new System.Drawing.Point(5, 58);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(273, 74);
            this.btnProductos.TabIndex = 616;
            this.btnProductos.Text = "Productos + vendidos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 218);
            this.panel2.TabIndex = 0;
            // 
            // panelVentas
            // 
            this.panelVentas.Controls.Add(this.reportViewer1);
            this.panelVentas.Controls.Add(this.panelCondicionales);
            this.panelVentas.Controls.Add(this.flowLayoutPanel2);
            this.panelVentas.Location = new System.Drawing.Point(805, 138);
            this.panelVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(1075, 661);
            this.panelVentas.TabIndex = 1;
            this.panelVentas.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 230);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1075, 431);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // panelCondicionales
            // 
            this.panelCondicionales.Controls.Add(this.PanelEmpleado);
            this.panelCondicionales.Controls.Add(this.btnHoy);
            this.panelCondicionales.Controls.Add(this.chekFiltros);
            this.panelCondicionales.Controls.Add(this.PanelFiltros);
            this.panelCondicionales.Controls.Add(this.MenuStrip6);
            this.panelCondicionales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondicionales.Location = new System.Drawing.Point(0, 65);
            this.panelCondicionales.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelCondicionales.Name = "panelCondicionales";
            this.panelCondicionales.Size = new System.Drawing.Size(1075, 165);
            this.panelCondicionales.TabIndex = 3;
            // 
            // PanelEmpleado
            // 
            this.PanelEmpleado.Controls.Add(this.txtEmpleado);
            this.PanelEmpleado.Controls.Add(this.Label4);
            this.PanelEmpleado.Location = new System.Drawing.Point(8, 89);
            this.PanelEmpleado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelEmpleado.Name = "PanelEmpleado";
            this.PanelEmpleado.Size = new System.Drawing.Size(667, 63);
            this.PanelEmpleado.TabIndex = 616;
            this.PanelEmpleado.Visible = false;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtEmpleado.Font = new System.Drawing.Font("Consolas", 14F);
            this.txtEmpleado.FormattingEnabled = true;
            this.txtEmpleado.Location = new System.Drawing.Point(149, 11);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(500, 35);
            this.txtEmpleado.TabIndex = 3;
            this.txtEmpleado.SelectedIndexChanged += new System.EventHandler(this.txtEmpleado_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Consolas", 14F);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label4.Location = new System.Drawing.Point(5, 16);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(129, 28);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Empleado:";
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.Transparent;
            this.btnHoy.FlatAppearance.BorderSize = 0;
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.DimGray;
            this.btnHoy.Location = new System.Drawing.Point(0, 25);
            this.btnHoy.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(207, 50);
            this.btnHoy.TabIndex = 615;
            this.btnHoy.Text = "Hasta HOY";
            this.btnHoy.UseVisualStyleBackColor = false;
            // 
            // chekFiltros
            // 
            this.chekFiltros.AutoSize = true;
            this.chekFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chekFiltros.Location = new System.Drawing.Point(244, 44);
            this.chekFiltros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chekFiltros.Name = "chekFiltros";
            this.chekFiltros.Size = new System.Drawing.Size(18, 17);
            this.chekFiltros.TabIndex = 613;
            this.chekFiltros.UseVisualStyleBackColor = true;
            this.chekFiltros.CheckedChanged += new System.EventHandler(this.chekFiltros_CheckedChanged);
            // 
            // PanelFiltros
            // 
            this.PanelFiltros.BackColor = System.Drawing.Color.White;
            this.PanelFiltros.Controls.Add(this.TXTFF);
            this.PanelFiltros.Controls.Add(this.TXTFI);
            this.PanelFiltros.Controls.Add(this.Label2);
            this.PanelFiltros.Controls.Add(this.Label3);
            this.PanelFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PanelFiltros.Location = new System.Drawing.Point(417, 18);
            this.PanelFiltros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelFiltros.Name = "PanelFiltros";
            this.PanelFiltros.Size = new System.Drawing.Size(625, 63);
            this.PanelFiltros.TabIndex = 611;
            this.PanelFiltros.Visible = false;
            // 
            // TXTFF
            // 
            this.TXTFF.Font = new System.Drawing.Font("Consolas", 14F);
            this.TXTFF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXTFF.Location = new System.Drawing.Point(384, 14);
            this.TXTFF.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXTFF.Name = "TXTFF";
            this.TXTFF.Size = new System.Drawing.Size(187, 35);
            this.TXTFF.TabIndex = 2;
            this.TXTFF.Value = new System.DateTime(2020, 6, 2, 0, 0, 0, 0);
            this.TXTFF.ValueChanged += new System.EventHandler(this.TXTFF_ValueChanged);
            // 
            // TXTFI
            // 
            this.TXTFI.Font = new System.Drawing.Font("Consolas", 14F);
            this.TXTFI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXTFI.Location = new System.Drawing.Point(91, 12);
            this.TXTFI.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TXTFI.Name = "TXTFI";
            this.TXTFI.Size = new System.Drawing.Size(181, 35);
            this.TXTFI.TabIndex = 2;
            this.TXTFI.Value = new System.DateTime(2020, 6, 2, 0, 0, 0, 0);
            this.TXTFI.ValueChanged += new System.EventHandler(this.TXTFI_ValueChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label2.Location = new System.Drawing.Point(284, 17);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 28);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label3.Location = new System.Drawing.Point(5, 17);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(90, 28);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Desde:";
            // 
            // MenuStrip6
            // 
            this.MenuStrip6.AutoSize = false;
            this.MenuStrip6.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TFILTROS});
            this.MenuStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip6.Location = new System.Drawing.Point(256, 31);
            this.MenuStrip6.Name = "MenuStrip6";
            this.MenuStrip6.ShowItemToolTips = true;
            this.MenuStrip6.Size = new System.Drawing.Size(161, 39);
            this.MenuStrip6.TabIndex = 612;
            this.MenuStrip6.Text = "MenuStrip6";
            // 
            // TFILTROS
            // 
            this.TFILTROS.BackColor = System.Drawing.Color.Transparent;
            this.TFILTROS.Checked = true;
            this.TFILTROS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TFILTROS.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.TFILTROS.ForeColor = System.Drawing.Color.DimGray;
            this.TFILTROS.Image = ((System.Drawing.Image)(resources.GetObject("TFILTROS.Image")));
            this.TFILTROS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TFILTROS.Name = "TFILTROS";
            this.TFILTROS.Size = new System.Drawing.Size(137, 35);
            this.TFILTROS.Text = "Filtros";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1075, 65);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnResumenVentas);
            this.panel4.Controls.Add(this.PResumenVentas);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 59);
            this.panel4.TabIndex = 405;
            // 
            // btnResumenVentas
            // 
            this.btnResumenVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnResumenVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResumenVentas.FlatAppearance.BorderSize = 0;
            this.btnResumenVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumenVentas.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumenVentas.ForeColor = System.Drawing.Color.DimGray;
            this.btnResumenVentas.Location = new System.Drawing.Point(0, 0);
            this.btnResumenVentas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnResumenVentas.Name = "btnResumenVentas";
            this.btnResumenVentas.Size = new System.Drawing.Size(320, 54);
            this.btnResumenVentas.TabIndex = 614;
            this.btnResumenVentas.Text = "Resumen de Ventas";
            this.btnResumenVentas.UseVisualStyleBackColor = false;
            this.btnResumenVentas.Click += new System.EventHandler(this.btnResumenVentas_Click);
            // 
            // PResumenVentas
            // 
            this.PResumenVentas.BackColor = System.Drawing.Color.OrangeRed;
            this.PResumenVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PResumenVentas.ForeColor = System.Drawing.Color.OrangeRed;
            this.PResumenVentas.Location = new System.Drawing.Point(0, 54);
            this.PResumenVentas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PResumenVentas.Name = "PResumenVentas";
            this.PResumenVentas.Size = new System.Drawing.Size(320, 5);
            this.PResumenVentas.TabIndex = 0;
            this.PResumenVentas.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEmpleado);
            this.panel5.Controls.Add(this.PVentasPorempleado);
            this.panel5.Location = new System.Drawing.Point(335, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 59);
            this.panel5.TabIndex = 618;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.DimGray;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(383, 54);
            this.btnEmpleado.TabIndex = 615;
            this.btnEmpleado.Text = "Ventas por Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // PVentasPorempleado
            // 
            this.PVentasPorempleado.BackColor = System.Drawing.Color.OrangeRed;
            this.PVentasPorempleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PVentasPorempleado.Location = new System.Drawing.Point(0, 54);
            this.PVentasPorempleado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PVentasPorempleado.Name = "PVentasPorempleado";
            this.PVentasPorempleado.Size = new System.Drawing.Size(383, 5);
            this.PVentasPorempleado.TabIndex = 0;
            this.PVentasPorempleado.Visible = false;
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.reportViewer2);
            this.panelProductos.Location = new System.Drawing.Point(328, 34);
            this.panelProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(481, 394);
            this.panelProductos.TabIndex = 2;
            this.panelProductos.Visible = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.AccessibilityKeyMap = null;
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(481, 394);
            this.reportViewer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RestCsharp.Properties.Resources.WhatsApp_Image_2024_04_24_at_7_44_38_AM__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menureportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 642);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelVentas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menureportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menur Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menureportes_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelCondicionales.ResumeLayout(false);
            this.panelCondicionales.PerformLayout();
            this.PanelEmpleado.ResumeLayout(false);
            this.PanelEmpleado.PerformLayout();
            this.PanelFiltros.ResumeLayout(false);
            this.PanelFiltros.PerformLayout();
            this.MenuStrip6.ResumeLayout(false);
            this.MenuStrip6.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelVentas;
        internal System.Windows.Forms.Panel panelCondicionales;
        internal System.Windows.Forms.Panel PanelEmpleado;
        internal System.Windows.Forms.ComboBox txtEmpleado;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnHoy;
        internal System.Windows.Forms.CheckBox chekFiltros;
        internal System.Windows.Forms.Panel PanelFiltros;
        internal System.Windows.Forms.DateTimePicker TXTFF;
        internal System.Windows.Forms.DateTimePicker TXTFI;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.MenuStrip MenuStrip6;
        internal System.Windows.Forms.ToolStripMenuItem TFILTROS;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Button btnResumenVentas;
        internal System.Windows.Forms.Panel PResumenVentas;
        internal System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button btnEmpleado;
        internal System.Windows.Forms.Panel PVentasPorempleado;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        internal System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panelProductos;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}