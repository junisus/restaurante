
namespace RestCsharp.Presentacion.AsistenteInstalacion
{
    partial class EleccionServidor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EleccionServidor));
            this.Panel8 = new System.Windows.Forms.Panel();
            this.btnServidorlisto = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.lblEstado_de_conexion = new System.Windows.Forms.Label();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PanelPc = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnSecundaria = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PanelServidor = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnconectar = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.txtBd = new System.Windows.Forms.TextBox();
            this.checkUsuario = new System.Windows.Forms.CheckBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.Panel8.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.PanelPc.SuspendLayout();
            this.PanelServidor.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Panel8.Controls.Add(this.btnServidorlisto);
            this.Panel8.Controls.Add(this.Panel3);
            this.Panel8.Controls.Add(this.PictureBox7);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(1484, 106);
            this.Panel8.TabIndex = 591;
            // 
            // btnServidorlisto
            // 
            this.btnServidorlisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnServidorlisto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServidorlisto.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnServidorlisto.FlatAppearance.BorderSize = 0;
            this.btnServidorlisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServidorlisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnServidorlisto.ForeColor = System.Drawing.Color.White;
            this.btnServidorlisto.Location = new System.Drawing.Point(1111, 0);
            this.btnServidorlisto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServidorlisto.Name = "btnServidorlisto";
            this.btnServidorlisto.Size = new System.Drawing.Size(373, 106);
            this.btnServidorlisto.TabIndex = 610;
            this.btnServidorlisto.Text = "Conectar a Bd existente";
            this.btnServidorlisto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServidorlisto.UseVisualStyleBackColor = false;
            this.btnServidorlisto.Click += new System.EventHandler(this.btnServidorlisto_Click);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.lblEstado_de_conexion);
            this.Panel3.Controls.Add(this.datalistado);
            this.Panel3.Location = new System.Drawing.Point(463, 9);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(13, 12);
            this.Panel3.TabIndex = 606;
            // 
            // lblEstado_de_conexion
            // 
            this.lblEstado_de_conexion.AutoSize = true;
            this.lblEstado_de_conexion.BackColor = System.Drawing.Color.White;
            this.lblEstado_de_conexion.Location = new System.Drawing.Point(92, 42);
            this.lblEstado_de_conexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado_de_conexion.Name = "lblEstado_de_conexion";
            this.lblEstado_de_conexion.Size = new System.Drawing.Size(108, 17);
            this.lblEstado_de_conexion.TabIndex = 605;
            this.lblEstado_de_conexion.Text = "lblRutaInstancia";
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToDeleteRows = false;
            this.datalistado.AllowUserToOrderColumns = true;
            this.datalistado.BackgroundColor = System.Drawing.Color.White;
            this.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistado.DefaultCellStyle = dataGridViewCellStyle2;
            this.datalistado.EnableHeadersVisualStyles = false;
            this.datalistado.GridColor = System.Drawing.Color.LightGray;
            this.datalistado.Location = new System.Drawing.Point(57, 22);
            this.datalistado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datalistado.RowHeadersVisible = false;
            this.datalistado.RowHeadersWidth = 5;
            this.datalistado.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistado.RowTemplate.Height = 60;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(399, 68);
            this.datalistado.TabIndex = 606;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            this.Eliminar.Width = 125;
            // 
            // PanelPc
            // 
            this.PanelPc.Controls.Add(this.Label4);
            this.PanelPc.Controls.Add(this.btnSecundaria);
            this.PanelPc.Controls.Add(this.btnPrincipal);
            this.PanelPc.Controls.Add(this.Label9);
            this.PanelPc.Controls.Add(this.Label1);
            this.PanelPc.Controls.Add(this.Panel1);
            this.PanelPc.Controls.Add(this.Panel2);
            this.PanelPc.Controls.Add(this.PictureBox1);
            this.PanelPc.Location = new System.Drawing.Point(65, 113);
            this.PanelPc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelPc.Name = "PanelPc";
            this.PanelPc.Size = new System.Drawing.Size(1369, 614);
            this.PanelPc.TabIndex = 615;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(892, 417);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(424, 127);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Se Conecta a la Computadora Principal siempre y cuando la Principal este Encendid" +
    "a";
            // 
            // btnSecundaria
            // 
            this.btnSecundaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnSecundaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecundaria.FlatAppearance.BorderSize = 0;
            this.btnSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecundaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.btnSecundaria.ForeColor = System.Drawing.Color.White;
            this.btnSecundaria.Location = new System.Drawing.Point(52, 399);
            this.btnSecundaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSecundaria.Name = "btnSecundaria";
            this.btnSecundaria.Size = new System.Drawing.Size(329, 103);
            this.btnSecundaria.TabIndex = 609;
            this.btnSecundaria.Text = "Secundaria";
            this.btnSecundaria.UseVisualStyleBackColor = false;
            this.btnSecundaria.Click += new System.EventHandler(this.btnSecundaria_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.btnPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPrincipal.Location = new System.Drawing.Point(183, 150);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(329, 103);
            this.btnPrincipal.TabIndex = 608;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(761, 162);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(516, 127);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Esta Computadora debe estar Encendida para que las Computadoras\r\nSecundarias se C" +
    "onecten. Si se apaga no podran conectarse.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(304, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(586, 58);
            this.Label1.TabIndex = 605;
            this.Label1.Text = "¿Esta Computadora es?";
            // 
            // PanelServidor
            // 
            this.PanelServidor.Controls.Add(this.btnVolver);
            this.PanelServidor.Controls.Add(this.btnconectar);
            this.PanelServidor.Controls.Add(this.txtCadena);
            this.PanelServidor.Controls.Add(this.Panel7);
            this.PanelServidor.Controls.Add(this.txtBd);
            this.PanelServidor.Controls.Add(this.checkUsuario);
            this.PanelServidor.Controls.Add(this.Label8);
            this.PanelServidor.Controls.Add(this.panelUsuario);
            this.PanelServidor.Controls.Add(this.panel9);
            this.PanelServidor.Controls.Add(this.txtservidor);
            this.PanelServidor.Controls.Add(this.Label3);
            this.PanelServidor.Controls.Add(this.Label6);
            this.PanelServidor.Controls.Add(this.Label7);
            this.PanelServidor.Location = new System.Drawing.Point(303, 113);
            this.PanelServidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelServidor.Name = "PanelServidor";
            this.PanelServidor.Size = new System.Drawing.Size(897, 654);
            this.PanelServidor.TabIndex = 616;
            this.PanelServidor.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVolver.Location = new System.Drawing.Point(315, 537);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(321, 58);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnconectar
            // 
            this.btnconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnconectar.FlatAppearance.BorderSize = 0;
            this.btnconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnconectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnconectar.Location = new System.Drawing.Point(313, 471);
            this.btnconectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(323, 58);
            this.btnconectar.TabIndex = 23;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = false;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCadena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCadena.ForeColor = System.Drawing.Color.White;
            this.txtCadena.Location = new System.Drawing.Point(397, 487);
            this.txtCadena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(173, 27);
            this.txtCadena.TabIndex = 26;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.Silver;
            this.Panel7.Location = new System.Drawing.Point(311, 340);
            this.Panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(323, 1);
            this.Panel7.TabIndex = 19;
            // 
            // txtBd
            // 
            this.txtBd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBd.ForeColor = System.Drawing.Color.White;
            this.txtBd.Location = new System.Drawing.Point(312, 304);
            this.txtBd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBd.Name = "txtBd";
            this.txtBd.Size = new System.Drawing.Size(321, 27);
            this.txtBd.TabIndex = 18;
            // 
            // checkUsuario
            // 
            this.checkUsuario.AutoSize = true;
            this.checkUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUsuario.ForeColor = System.Drawing.Color.White;
            this.checkUsuario.Location = new System.Drawing.Point(652, 247);
            this.checkUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkUsuario.Name = "checkUsuario";
            this.checkUsuario.Size = new System.Drawing.Size(227, 33);
            this.checkUsuario.TabIndex = 25;
            this.checkUsuario.Text = "Tengo un Usuario";
            this.checkUsuario.UseVisualStyleBackColor = true;
            this.checkUsuario.CheckedChanged += new System.EventHandler(this.checkUsuario_CheckedChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label8.Location = new System.Drawing.Point(125, 304);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(173, 29);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Base de datos:";
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.Label2);
            this.panelUsuario.Controls.Add(this.txtusuario);
            this.panelUsuario.Controls.Add(this.panel5);
            this.panelUsuario.Controls.Add(this.panel6);
            this.panelUsuario.Controls.Add(this.txtcontraseña);
            this.panelUsuario.Controls.Add(this.Label5);
            this.panelUsuario.Location = new System.Drawing.Point(153, 356);
            this.panelUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(505, 108);
            this.panelUsuario.TabIndex = 24;
            this.panelUsuario.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label2.Location = new System.Drawing.Point(48, 12);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(102, 29);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(161, 12);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(321, 27);
            this.txtusuario.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(160, 102);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 1);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(160, 48);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 1);
            this.panel6.TabIndex = 19;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtcontraseña.ForeColor = System.Drawing.Color.White;
            this.txtcontraseña.Location = new System.Drawing.Point(161, 66);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(321, 27);
            this.txtcontraseña.TabIndex = 21;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label5.Location = new System.Drawing.Point(5, 64);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(142, 29);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Contraseña:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(311, 286);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(323, 1);
            this.panel9.TabIndex = 16;
            // 
            // txtservidor
            // 
            this.txtservidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtservidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtservidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtservidor.ForeColor = System.Drawing.Color.White;
            this.txtservidor.Location = new System.Drawing.Point(312, 250);
            this.txtservidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(321, 27);
            this.txtservidor.TabIndex = 15;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label3.Location = new System.Drawing.Point(191, 247);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 29);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Servidor:";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.DarkGray;
            this.Label6.Location = new System.Drawing.Point(0, 166);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(897, 65);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "Ingrese los datos Manualmente";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label7.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(0, 0);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(897, 166);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Servidor";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel1.BackgroundImage")));
            this.Panel1.Location = new System.Drawing.Point(740, 139);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(4, 166);
            this.Panel1.TabIndex = 606;
            // 
            // Panel2
            // 
            this.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel2.BackgroundImage")));
            this.Panel2.Location = new System.Drawing.Point(871, 385);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(4, 171);
            this.Panel2.TabIndex = 607;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(315, 139);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(629, 417);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 604;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox7
            // 
            this.PictureBox7.Image = global::RestCsharp.Properties.Resources.WhatsApp_Image_2024_04_24_at_7_44_38_AM__2_;
            this.PictureBox7.Location = new System.Drawing.Point(16, 15);
            this.PictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(147, 78);
            this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox7.TabIndex = 604;
            this.PictureBox7.TabStop = false;
            // 
            // EleccionServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1484, 886);
            this.Controls.Add(this.PanelPc);
            this.Controls.Add(this.PanelServidor);
            this.Controls.Add(this.Panel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EleccionServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleccion Servidor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EleccionServidor_Load);
            this.Panel8.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.PanelPc.ResumeLayout(false);
            this.PanelPc.PerformLayout();
            this.PanelServidor.ResumeLayout(false);
            this.PanelServidor.PerformLayout();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.Button btnServidorlisto;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label lblEstado_de_conexion;
        internal System.Windows.Forms.DataGridView datalistado;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        internal System.Windows.Forms.PictureBox PictureBox7;
        internal System.Windows.Forms.Panel PanelPc;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnSecundaria;
        internal System.Windows.Forms.Button btnPrincipal;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel PanelServidor;
        internal System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.Button btnconectar;
        internal System.Windows.Forms.TextBox txtCadena;
        internal System.Windows.Forms.Panel Panel7;
        internal System.Windows.Forms.TextBox txtBd;
        internal System.Windows.Forms.CheckBox checkUsuario;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Panel panelUsuario;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtusuario;
        internal System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.TextBox txtcontraseña;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel panel9;
        internal System.Windows.Forms.TextBox txtservidor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
    }
}