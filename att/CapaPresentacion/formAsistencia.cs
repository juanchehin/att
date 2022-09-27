using att.CapaLogica;
using System;
using System.Windows.Forms;

namespace att.CapaPresentacion
{
    public partial class formAsistencia : Form
    {
        public formAsistencia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.guardarAsistencia();
        }        


        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.guardarAsistencia();
            }
        }

        private void guardarAsistencia()
        {
            int i;
            string rpta = "";
            try
            {
                if (int.TryParse(txtDNI.Text, out i).ToString() == "False")
                {
                    MensajeError("El campo DNI debe ser numerico");
                    return;
                }
                if (this.txtDNI.Text == string.Empty)
                {
                    MensajeError("El campo DNI es obligatorio");
                }
                else
                {
                    rpta = LAsistencias.InsertarAsistencia(Convert.ToInt32(txtDNI.Text), this.tbObservaciones.Text.Trim());

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            txtDNI.Clear();
            tbObservaciones.Clear();
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "att", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "att", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnHuella_Click(object sender, EventArgs e)
        {
            formVerificar verificar = new formVerificar();
            verificar.ShowDialog();
        }
    }
}
