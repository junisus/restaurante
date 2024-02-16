﻿using RestCsharp.Datos;
using RestCsharp.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestCsharp.Presentacion.Serializacion
{
    public partial class SerialziacionComp : Form
    {
        public SerialziacionComp()
        {
            InitializeComponent();
        }
        int idserie;
        string pordefecto;
        private void VOLVEROK_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            InsertarComprobante();
        }
        private void InsertarComprobante()
        {
            var funcion = new Dserealizacion();
            var parametros = new Lserializacion();
            parametros.Serie = txtSerie.Text;
            parametros.Cantidad_de_numeros = TXTCANTIDADDECEROS.Text;
            parametros.numerofin = Convert.ToInt32(txtnumerofin.Text);
            parametros.Tipo = TXTCOMPRO.Text;
            parametros.Por_defecto = "-";
            funcion.Insertar_Serializacion(parametros);
            mostrarComprobantes();
            panel3.Visible = false;
        }
        private void mostrarComprobantes()
        {
            var funcion = new Dserealizacion();
            var dt = new DataTable();
            funcion.mostrarComprobantes(ref dt);
            datalistado.DataSource = dt;
            datalistado.Columns[1].Visible = false;
            var diseño = new Bases();
            diseño.DiseñoDatagridview(ref datalistado);

        }

        private void GUARDARCAMBIOS_Click(object sender, EventArgs e)
        {
            Editarpordefecto();
            editar_serializacion();
        }
        private void editar_serializacion()
        {
            var funcion = new Dserealizacion();
            var parametros = new Lserializacion();
            parametros.Serie = txtSerie.Text;
            parametros.Cantidad_de_numeros = TXTCANTIDADDECEROS.Text;
            parametros.numerofin =Convert.ToInt32( txtnumerofin.Text);
            parametros.Tipo = TXTCOMPRO.Text;
            parametros.Id_serializacion = idserie;
            funcion.editar_serializacion(parametros);
            mostrarComprobantes();
            panel3.Visible = false;
        }
        private void Editarpordefecto()
        {
            if (checkDefecto.Checked == true)
            {
                var funcion = new Dserealizacion();
                var parametros = new Lserializacion();
                parametros.Id_serializacion = idserie;
                funcion.editarSerieDefecto(parametros);
            }


        }

        private void datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            GUARDAR.Visible = true;
            GUARDARCAMBIOS.Visible = false;
            TXTCOMPRO.Clear();
            TXTCANTIDADDECEROS.Clear();
            txtnumerofin.Clear();
            txtSerie.Clear();
            checkDefecto.Checked = false;
            checkDefecto.Visible = false;
        }

        private void pelimintar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Realmente desea eliminar los registros seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                idserie = Convert.ToInt32(datalistado.SelectedCells[1].Value);
                Eliminar();
            }

        }
        private void Eliminar()
        {
            var funcion = new Dserealizacion();
            var parametros = new Lserializacion();
            parametros.Id_serializacion = idserie;
            funcion.eliminar_Serializacion(parametros);
            mostrarComprobantes();
        }

        private void SerialziacionComp_Load(object sender, EventArgs e)
        {
            mostrarComprobantes();
        }

        private void datalistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            try
            {
                idserie=Convert.ToInt32( datalistado.SelectedCells[1].Value);
                TXTCOMPRO.Text = datalistado.SelectedCells[5].Value.ToString();
                TXTCANTIDADDECEROS.Text = datalistado.SelectedCells[3].Value.ToString();
                txtnumerofin.Text = datalistado.SelectedCells[4].Value.ToString();
                txtSerie.Text = datalistado.SelectedCells[2].Value.ToString();
                GUARDAR.Visible = false;
                GUARDARCAMBIOS.Visible = true;
                pordefecto = datalistado.SelectedCells[6].Value.ToString();
                if (pordefecto == "SI")
                {
                    checkDefecto.Visible = false;
                    checkDefecto.Checked = true;
                }
                else
                {
                    checkDefecto.Visible = true;
                    checkDefecto.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}