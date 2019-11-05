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
        private List<Persona> listaAux;

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

        private void btnAgregar_Click(object sender, EventArgs e)
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
                command.CommandText = "INSERT INTO personas ([nombre],[apellido],[edad]) \n VALUES('" + frm.Persona.nombre + "','" + frm.Persona.apellido + "'," + Convert.ToInt32(frm.Persona.edad).ToString() + ")";
                command.ExecuteNonQuery();
                conexionSql.Close();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //PARAMETRO EN CONSTRUCTOR APRA MODIFICAR
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            //command.CommandText = "UPDATE personas SET [nombre] = '" + aux.nombre + "', [apellido] = '" + aux.apellido + "', [edad] = " + aux.Edad + " WHERE [id] = " + this.lstVisor.SelectedIndex;
            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            SqlConnection conexionSql;
            this.listaAux.RemoveAt(this.lstVisor.SelectedIndex);
            frm.StartPosition = FormStartPosition.CenterScreen;
            conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
            conexionSql.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexionSql;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM personas WHERE [row_number] = " + this.lstVisor.SelectedIndex + 1;
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
