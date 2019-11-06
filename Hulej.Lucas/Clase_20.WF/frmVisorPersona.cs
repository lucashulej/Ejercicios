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
                SqlConnection conexionSql;
                conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
                conexionSql.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexionSql;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO personas ([nombre],[apellido],[edad]) VALUES('" + frm.Persona.nombre + "','" + frm.Persona.apellido + "'," + Convert.ToInt32(frm.Persona.edad).ToString() + ")";
                command.ExecuteNonQuery();
                conexionSql.Close();
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
                SqlConnection conexionSql;
                selectedIndex = this.lstVisor.SelectedIndex;
                auxPersona = this.listaAux[this.lstVisor.SelectedIndex];
                conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
                conexionSql.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexionSql;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE personas SET [nombre] = @nombre, [apellido] = @apellido, [edad] = @edad WHERE nombre = @nombre2 AND [apellido] = @apellido2 AND [edad] = @edad2";
                command.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                command.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                command.Parameters.AddWithValue("@edad", frm.Persona.edad);
                command.Parameters.AddWithValue("@nombre2", auxPersona.nombre);
                command.Parameters.AddWithValue("@apellido2", auxPersona.apellido);
                command.Parameters.AddWithValue("@edad2", auxPersona.edad);
                command.ExecuteNonQuery();
                this.listaAux[selectedIndex] = frm.Persona;
                this.cargarListBox();
            }
            
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona auxPersona;
            SqlConnection conexionSql;
            auxPersona = this.listaAux[this.lstVisor.SelectedIndex];
            this.listaAux.RemoveAt(this.lstVisor.SelectedIndex);
            conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
            conexionSql.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexionSql;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM personas WHERE [nombre] = '" + auxPersona.nombre + "' AND [apellido] = '" + auxPersona.apellido + "' AND [edad] = " + auxPersona.edad;
            command.ExecuteNonQuery();
            conexionSql.Close();
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
    }
}
