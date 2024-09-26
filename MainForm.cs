using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace closeFixer // Asegúrate de que el namespace sea el correcto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Evento para el botón de seleccionar carpeta
        private void BtnClosingSelectClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                labelStatus.Text = "Carpeta seleccionada: " + selectedPath;
                // Aquí puedes agregar lógica adicional para manejar la carpeta seleccionada
            }
        }

        // Evento para el botón de seleccionar cierre
        private void ButtonSelectClosingClick(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Archivos de Cierre (*.txt)|*.txt|Todos los archivos (*.*)|*.*"; // Cambia el filtro según lo que necesites
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                labelStatus.Text = "Cierre seleccionado: " + filePath;
                // Aquí puedes agregar la lógica para manejar el archivo de cierre seleccionado
            }
        }

  

        // Método para exportar datos a una nueva base de datos
        private void ExportDataToNewDb(string originalDbPath)
        {
            string newDbPath = Path.Combine(Path.GetDirectoryName(originalDbPath), "RepairedDatabase.mdb");

            using (OleDbConnection newConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + newDbPath + ";"))
            {
                newConnection.Open();
                try
                {
                    using (OleDbConnection originalConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + originalDbPath + ";"))
                    {
                        originalConnection.Open();
                        var tables = originalConnection.GetSchema("Tables");

                        foreach (DataRow row in tables.Rows)
                        {
                            string tableName = row["TABLE_NAME"].ToString();
                            if (row["TABLE_TYPE"].ToString() == "TABLE")
                            {
                                string createTableSql = "CREATE TABLE [" + tableName + "] (Ticket TEXT(255), TicketGuid TEXT(255));"; // Personaliza según las columnas reales
                                using (OleDbCommand createCommand = new OleDbCommand(createTableSql, newConnection))
                                {
                                    createCommand.ExecuteNonQuery();
                                }

                                string insertSql = "INSERT INTO [" + tableName + "] (Ticket, TicketGuid) SELECT Ticket, TicketGuid FROM [" + tableName + "];";
                                using (OleDbCommand insertCommand = new OleDbCommand(insertSql, newConnection))
                                {
                                    insertCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    File.Delete(originalDbPath);
                    File.Move(newDbPath, originalDbPath);
                    MessageBox.Show("Datos copiados y base de datos reparada en: " + originalDbPath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al copiar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
