using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestCsharp.Datos;
using RestCsharp.Logica;
namespace RestCsharp.Presentacion.AsistenteInstalacion
{
    public partial class UsuarioPrincipal : Form
    {
        public UsuarioPrincipal()
        {
            InitializeComponent();
        }
        int idsalon;
        int idusuario;
        int idcaja;
        private void UsuarioPrincipal_Load(object sender, EventArgs e)
        {
            CentrarPaneles();
        }
        private void CentrarPaneles()
        {
            Panel2.Location = new Point((Width - Panel2.Width) / 2, (Height - Panel2.Height) / 2);

        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
            {
                if (!string.IsNullOrEmpty(TXTCONTRASEÑA.Text))
                {
                    if (TXTCONTRASEÑA.Text == txtconfirmarcontraseña.Text)
                    {
                        insertarUsuarioDefecto();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinsiden", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Falta ingresar la Contraseña", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Falta ingresar el Nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void insertarComprobantes()
        {
            var funcion = new Dserealizacion();
            var parametros = new Lserializacion();

            //**** ticket
            parametros.Serie = "T";
            parametros.Cantidad_de_numeros = "6";
            parametros.numerofin = 0;
            parametros.Tipo = "TICKET";
            parametros.Por_defecto = "SI";
            funcion.Insertar_Serializacion(parametros);
           

        }
        private void insertarUsuarioDefecto()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Nombre = txtnombre.Text;
            parametros.Login = TXTUSUARIO.Text;
            parametros.Password = Bases.Encriptar(TXTCONTRASEÑA.Text);
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            parametros.Correo = "-";
            parametros.Rol = "Administrador";
            if (funcion.InsertarUsuarios(parametros) == true)
            {
                InsertarLicencia();
                InsertarUsuarioCliente();
                InsertarAreasImpresion();
                insertarCaja();
                insertarCajaRemota();
                insertarComprobantes();
                insertarSalonDefecto();
                insertarMesaLlevar();
                insertar_mesasDefecto();
                //MOD
                insertarSalonParaLlevar();
                insertarMesasParaLlevar();
                //FIN MOD
                insertarPropidadesMesas();


                Insertar_Modulos();
                InsertarTicket();
                InsertarClienteStandar();
                ObtenerIdUsuario();
                insertarMovcajaremota();
                InsertarColores();
                insertarPermisos();

                
            }
        }
        private void InsertarLicencia()
        {
            var funcion = new Dlicencias();
            funcion.InsertarLicencia();
        }
        private void InsertarTicket()
        {
            var funcion = new Dticketventa();
            funcion.Insertar_Ticket();
        }
        private void InsertarUsuarioCliente()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Nombre = "Cliente";
            parametros.Login = "Cliente";
            parametros.Password = Bases.Encriptar("Cliente369");
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            parametros.Correo = "Cliente";
            parametros.Rol = "Cliente";
            funcion.InsertarUsuarios(parametros);
        }
        private void insertarMesaLlevar()
        {
            var funcion = new Dmesas();
            funcion.insertarMesaLlevar();
        }
        private void InsertarClienteStandar()
        {
            var funcion = new Dclientes();
            var parametros = new Lclientes();
            parametros.Nombre = "GENERICO";
            parametros.Direccion = "GENERICO";
            parametros.IdentificadorFiscal = "GENERICO";
            parametros.Celular = "GENERICO";
            parametros.Cedula = "GENERICO";
            funcion.insertar_clientes(parametros);
        }
        private void InsertarAreasImpresion()
        {
            var funcion = new Dareasimpresion();
            funcion.InsertarAreasImpresion();
        }
        private void InsertarColores()
        {
            Dcolores funcion = new Dcolores();
            funcion.InsertarColores();
        }
        private void insertarPermisos()
        {
            DataTable dt = new DataTable();
            Dmodulos funcionModulos = new Dmodulos();
            funcionModulos.mostrar_Modulos(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                int idModulo = Convert.ToInt32(row["IdModulo"]);
                Lpermisos parametros = new Lpermisos();
                Dpermisos funcion = new Dpermisos();
                parametros.IdModulo = idModulo;
                parametros.IdUsuario = idusuario;
                funcion.Insertar_Permisos(parametros);
               
            }
            MessageBox.Show("!LISTO! RECUERDA que para Iniciar Sesión tu Usuario es: " + TXTUSUARIO.Text + " y tu Contraseña es: " + TXTCONTRASEÑA.Text, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
            Login.LoginForm frm = new Login.LoginForm();
            frm.ShowDialog();
        }
        private void ObtenerIdUsuario()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.ObtenerIdUsuario(ref idusuario, TXTUSUARIO.Text);

        }
        private void Insertar_Modulos()
        {
            Lmodulos parametros = new Lmodulos();
            Dmodulos funcion = new Dmodulos();
            var Modulos = new List<string> {"Para llevar", "Cambio de mesa", "Ver cuentas","Cerrar caja","Cocina","Administrar","Generar codigos QR","Ingreso / Salida de dinero","Cobrar" };
            foreach (var Modulo in Modulos )
            {
                parametros.Modulo = Modulo;
                funcion.Insertar_Modulos(parametros);
            }
        }
        private void insertarPropidadesMesas()
        {
            DpropiedadesMesas funcion = new DpropiedadesMesas();
            funcion.insertarPropidadesMesas();
        }
        private void insertar_mesasDefecto()
        {
            ObtenerIdsalon();
            Lmesas parametros = new Lmesas();
            Dmesas funcion = new Dmesas();
            parametros.Mesa = "NULO";
            parametros.Id_salon = idsalon;
            for (int i=1;i<=80;i++)
            {
                funcion.insertar_mesa(parametros);
            }

        }
        private void ObtenerIdsalon()
        {
            Dsalon funcion = new Dsalon();
            funcion.ObtenerSalonInicial(ref idsalon);
        }
        private void insertarSalonDefecto()
        {
            Lsalon parametros = new Lsalon();
            Dsalon funcion = new Dsalon();
            parametros.Salon = "Principal";
            funcion.insertar_Salon(parametros);
        }

        private void insertarSalonParaLlevar ()
        {
            Lsalon parametros = new Lsalon();
            Dsalon funcion = new Dsalon();
            parametros.Salon = "Para Llevar";
            funcion.insertar_Salon(parametros);
        }

        private void insertarMesasParaLlevar()
        {
            //ObtenerIdsalon();
            int c = 0;
            int id = 81;
            Lmesas parametros = new Lmesas();
            Dmesas funcion = new Dmesas();
            parametros.Mesa = "NULO";
            parametros.Id_salon = 2;
            for (int i = 1; i <= 80; i++)
            {
                funcion.insertar_mesa(parametros);
            }

            CONEXIONMAESTRA.abrir();
            for (int i = 1; i <= 5; i++)
            {
                c += 1;
                id += 1;
                SqlCommand cmd = new SqlCommand("editar_mesa", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mesa", "Orden " + c);
                cmd.Parameters.AddWithValue("@id_mesa", id);
                cmd.ExecuteNonQuery();
            }
            /*
            CONEXIONMAESTRA.abrir();
            SqlCommand cmd = new SqlCommand("editar_mesa", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mesa", "Orden 1");
            cmd.Parameters.AddWithValue("@id_mesa", 82);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("editar_mesa", CONEXIONMAESTRA.conectar);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@mesa", "Orden 2");
            cmd.Parameters.AddWithValue("@id_mesa", 83);
            cmd.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("editar_mesa", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mesa", "Orden 3");
            cmd.Parameters.AddWithValue("@id_mesa", 84);
            cmd.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand("editar_mesa", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mesa", "Orden 4");
            cmd.Parameters.AddWithValue("@id_mesa", 85);
            cmd.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("editar_mesa", CONEXIONMAESTRA.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mesa", "Orden 5");
            cmd.Parameters.AddWithValue("@id_mesa", 86);
            cmd.ExecuteNonQuery();
            */
            CONEXIONMAESTRA.cerrar();
            
            //Lmesas parametros 
            /*
            Lmesas parametros1 = new Lmesas();
            Dmesas funcion1 = new Dmesas();
            parametros1.Mesa = "Para Llevar 1";
            parametros1.Id_mesa = 82;

            Lmesas parametros2 = new Lmesas();
            Dmesas funcion2 = new Dmesas();
            parametros2.Mesa = "Para Llevar 2";
            parametros2.Id_mesa = 83;

            Lmesas parametros3 = new Lmesas();
            Dmesas funcion3 = new Dmesas();
            parametros3.Mesa = "Para Llevar 3";
            parametros3.Id_mesa = 84;

            Lmesas parametros4 = new Lmesas();
            Dmesas funcion4 = new Dmesas();
            parametros4.Mesa = "Para Llevar 4";
            parametros4.Id_mesa = 85;

            Lmesas parametros5 = new Lmesas();
            Dmesas funcion5 = new Dmesas();
            parametros5.Mesa = "Para Llevar 5";
            parametros5.Id_mesa = 86;
            */
        }

        private void insertarCaja()
        {
            Lcaja parametros = new Lcaja();
            Dcaja funcion = new Dcaja();
            parametros.Descripcion = "Caja principal";
            parametros.Tema = "Claro";
            parametros.Tipo = "PRINCIPAL";
            funcion.Insertar_caja(parametros);
        }
        private void insertarCajaRemota()
        {
            Lcaja parametros = new Lcaja();
            Dcaja funcion = new Dcaja();
            parametros.Descripcion = "Caja remota";
            parametros.Tema = "Claro";
            parametros.Tipo = "REMOTA";
            funcion.Insertar_cajaRemota(parametros);
        }
        private void insertarMovcajaremota()
        {
            mostrarIdcajaremota();
            var parametros = new LmovientosCaja();
            var funcion = new DmovimientoCaja();
            parametros.Idusuario = idusuario;
            parametros.IdCaja =idcaja;
            funcion.insertar_movCajaremota(parametros);
        }
      private void mostrarIdcajaremota()
        {
            var funcion = new Dcaja();
            funcion.mostrarCajaRemota(ref idcaja);
        }

    }
}
