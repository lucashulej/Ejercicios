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

        private SqlConnection conexionSql;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
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
                this.conexionSql = new SqlConnection(Properties.Settings.Default.Conexion);
                this.conexionSql.Open();

                MessageBox.Show("EXITO EN CONEXION CON BASE DE DATOS");

                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = this.conexionSql;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
                SqlDataReader dataReader = comandoSql.ExecuteReader();
                Persona aux;
                while(dataReader.Read())
                {
                    aux = new Persona(dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), int.Parse(dataReader["id"].ToString()));
                    this.lista.Add(aux);
                    //MessageBox.Show(dataReader["id"].ToString() + " - " + dataReader["nombre"].ToString());
                }
                MessageBox.Show("Se cargaron todas las personas de la base de datos");
                this.conexionSql.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
