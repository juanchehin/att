using att.CapaLogica;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace att.CapaPresentacion
{
    public partial class formVerificar : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        LPersonal objetoCL = new LPersonal();
        DataTable dt = new DataTable();
        string rpta;


        public formVerificar()
        {
            InitializeComponent();
        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("Tasa de aceptación falsa (FAR) = {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            dt = objetoCL.ListarTodoPersonal();

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;

                foreach (DataRow row in dt.Rows)
                {
                    stream = new MemoryStream((byte[])row[6]);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        marcarAsistencia(row[3].ToString());
                        MakeReport("La huella digital fue VERIFICADA. " + row[1] + " " + row[2]);
                        break;
                    }
                }

            }
        }
        private void marcarAsistencia(string DNI)
        {
            try
            {
                rpta = LAsistencias.InsertarAsistencia(Convert.ToInt32(DNI), "-");

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Asistencia marcada");
                }
                else
                {
                    this.MensajeError(rpta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "att", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "att", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
