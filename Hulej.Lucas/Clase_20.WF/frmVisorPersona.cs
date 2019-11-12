using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_20.Entidades;
using System.IO;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        protected List<Persona> listaAux;
        protected SqlConnection conexion;
        protected SqlCommand comando;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.listaAux = new List<Persona>();
        }

        public frmVisorPersona(List<Persona> lista) : this()
        {
            this.listaAux = lista;
            this.cargarListBox();
        }

        public List<Persona> Lista
        {
            get
            {
                return this.listaAux;
            }
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                this.listaAux.Add(frm.Persona);
                this.cargarListBox();

                this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                this.conexion.Open();
                this.comando = new SqlCommand();
                this.comando.Connection = this.conexion;
                this.comando.CommandType = CommandType.Text;

                this.comando.CommandText = "INSERT INTO personas ([nombre],[apellido],[edad]) VALUES(@nombre,@apellido,@edad)";
                this.comando.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                this.comando.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                this.comando.Parameters.AddWithValue("@edad", Convert.ToInt32(frm.Persona.edad));
                this.comando.ExecuteNonQuery();
                this.conexion.Close();
            }

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            Persona auxPersona = this.listaAux[this.lstVisor.SelectedIndex];
            frmPersona frm = new frmPersona(auxPersona);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                selectedIndex = this.lstVisor.SelectedIndex;
                auxPersona = this.listaAux[this.lstVisor.SelectedIndex];

                this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                this.conexion.Open();
                this.comando = new SqlCommand();
                this.comando.Connection = this.conexion;
                this.comando.CommandType = CommandType.Text;

                this.comando.CommandText = "UPDATE personas SET [nombre] = @nombre, [apellido] = @apellido, [edad] = @edad WHERE nombre = @nombre2 AND [apellido] = @apellido2 AND [edad] = @edad2";
                this.comando.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                this.comando.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                this.comando.Parameters.AddWithValue("@edad", frm.Persona.edad);
                this.comando.Parameters.AddWithValue("@nombre2", auxPersona.nombre);
                this.comando.Parameters.AddWithValue("@apellido2", auxPersona.apellido);
                this.comando.Parameters.AddWithValue("@edad2", auxPersona.edad);
                this.comando.ExecuteNonQuery();
                this.listaAux[selectedIndex] = frm.Persona;
                this.cargarListBox();
            }
            
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona auxPersona;
            auxPersona = this.listaAux[this.lstVisor.SelectedIndex];
            this.listaAux.RemoveAt(this.lstVisor.SelectedIndex);

            this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            this.conexion.Open();
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;

            this.comando.CommandText = "DELETE FROM personas WHERE [nombre] = @nombre AND [apellido] = @apellido AND [edad] = @edad";
            this.comando.Parameters.AddWithValue("@nombre", auxPersona.nombre);
            this.comando.Parameters.AddWithValue("@apellido", auxPersona.apellido);
            this.comando.Parameters.AddWithValue("@edad", auxPersona.edad);
            this.comando.ExecuteNonQuery();
            this.conexion.Close();
            this.cargarListBox();
        }

        private void cargarListBox()
        {
            this.lstVisor.Items.Clear();
            foreach (Persona item in this.listaAux)
            {
                this.lstVisor.Items.Add(item.ToString());
            }
        }

        private void frmVisorPersona_Load(object sender, EventArgs e)
        {
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnModificar.Click -= new System.EventHandler(this.btnModificar_Click);
            this.btnEliminar.Click -= new System.EventHandler(this.btnEliminar_Click);
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        }
    }
}
