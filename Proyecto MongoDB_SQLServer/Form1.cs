namespace Proyecto_MongoDB_SQLServer
{
    public partial class Form1 : Form
    {
        private string rutaCsv;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Seleccione un archivo CSV";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaCsv = openFileDialog.FileName;
                    txtRutaCsv.Text = rutaCsv; // Muestra la ruta en el TextBox
                }
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaCsv))
            {
                MessageBox.Show("Por favor, seleccione un archivo CSV primero.");
                return;
            }

            using (var dbContext = new CinemaKinoContext())
            {
                var importer = new CsvToSqlImporter(dbContext);
                try
                {
                    importer.ImportarDesdeCsv(rutaCsv);
                    MessageBox.Show("Datos importados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al importar los datos: {ex.Message}");
                }
            }
        }
    }
}
