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
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        private SqlConnection baseDeDatos;
        private SqlCommand comandoSql;
        private SqlDataReader lectorSql;
        private DataTable tablaPersonas;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            this.tablaPersonas = new DataTable("Personas");
            this.cargarDataTable();
        }

        private void cargarDataTable()
        {
            try
            {
                this.baseDeDatos = new SqlConnection(Properties.Settings.Default.Conexion);
                this.baseDeDatos.Open();
                this.comandoSql = new SqlCommand();
                this.comandoSql.Connection = this.baseDeDatos;
                this.comandoSql.CommandType = CommandType.Text;
                this.comandoSql.CommandText = " SELECT * FROM[personas_bd].[dbo].[personas]";
                this.lectorSql = comandoSql.ExecuteReader();
                this.tablaPersonas.Load(lectorSql);
                this.lectorSql.Close();
                this.baseDeDatos.Close();
                MessageBox.Show("Conexion con base de datos establecida");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer archivo = new XmlSerializer(typeof(List<Persona>));
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                using (StreamReader reader = new StreamReader(openFile.FileName))
                {
                    this.lista = (List<Persona>)archivo.Deserialize(reader);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer archivo = new XmlSerializer(typeof(List<Persona>));
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.ShowDialog();
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    archivo.Serialize(writer, this.lista);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

            this.lista = frm.Lista;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDeDatos = new SqlConnection(Properties.Settings.Default.Conexion);
                this.baseDeDatos.Open();

                this.comandoSql = new SqlCommand();
                this.comandoSql.Connection = this.baseDeDatos;
                this.comandoSql.CommandType = CommandType.Text;
                this.comandoSql.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
                this.lectorSql = comandoSql.ExecuteReader();
                Persona aux;
                while(this.lectorSql.Read())
                {
                    aux = new Persona(lectorSql["nombre"].ToString(), lectorSql["apellido"].ToString(), int.Parse(lectorSql["edad"].ToString()));
                    this.lista.Add(aux);
                }
                this.baseDeDatos.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataTable frmDataTable = new FrmDataTable(this.tablaPersonas);
            frmDataTable.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
