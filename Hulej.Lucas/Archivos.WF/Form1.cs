using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Archivos.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Environment.SpecialFolder item in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                this.cmbBoxUbicacion.Items.Add(item);
                this.cmbBoxUbicacion.SelectedItem = Environment.SpecialFolder.Desktop;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath((Environment.SpecialFolder)this.cmbBoxUbicacion.SelectedItem) + "\\" +this.txtBoxNombreArchivo.Text;
            try
            {
                using (StreamWriter escritura = new StreamWriter(path))
                {
                    escritura.WriteLine(this.txtBoxTexto.Text);
                }
                this.txtBoxNombreArchivo.Text = "";
                this.txtBoxTexto.Text = "";
            }
            catch (DirectoryNotFoundException exception) //PATH NO VALIDO
            {
                MessageBox.Show(exception.Message);
            }
            catch (ArgumentException exception) //CARACTERES NO VALIDOS EN EL PATH
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception) //OTRAS EXCEPCIONES
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath((Environment.SpecialFolder)this.cmbBoxUbicacion.SelectedItem) + "\\" + this.txtBoxNombreArchivo.Text;
            string contenido = "";
            try
            {
                using (StreamReader lectura = new StreamReader(path))
                {
                    contenido = lectura.ReadToEnd();
                }
                MessageBox.Show(contenido);
                this.txtBoxNombreArchivo.Text = "";
                this.txtBoxTexto.Text = "";
            }
            catch (DirectoryNotFoundException exception) //PATH NO VALIDO
            {
                MessageBox.Show(exception.Message);
            }
            catch (ArgumentException exception) //CARACTERES NO VALIDOS EN EL PATH
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception) //OTRAS EXCEPCIONES
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
