using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gestionare_Stocuri
{
    public partial class FormMateriale : Form
    {
        private AppDbContext dbContext;
        private List<Material> materiale;
        private ErrorProvider errorProvider;
        private List<Operatie> operatii;

        public FormMateriale()
        {
            InitializeComponent();
            dbContext = new AppDbContext();
            materiale = dbContext.Materiale.Include(m => m.Operatii).ToList();
            operatii = dbContext.Operatii.Include(o => o.MaterialUtilizat).ToList();
            dataGridViewMateriale.DataSource = materiale;
            errorProvider = new ErrorProvider();
            dataGridViewMateriale.SelectionChanged += DataGridViewMateriale_SelectionChanged;
            cmbTipOperatie.DataSource = Enum.GetValues(typeof(TipOperatie));
            cmbCategorieMaterial.DataSource = Enum.GetValues(typeof(CategorieMaterial));
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument_PrintPage); 
        }

        private void FormMateriale_Load(object sender, EventArgs e)
        {
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            materiale = dbContext.Materiale.Include(m => m.Operatii).ToList();
            dataGridViewMateriale.DataSource = materiale;
        }

        private void Adauga(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    int nextId = materiale.Any() ? materiale.Max(m => m.Id) + 1 : 1;

                    var material = new Material
                    {
                        Id = nextId,
                        Nume = txtNume.Text,
                        CodDeBare = txtCodDeBare.Text,
                        Cantitate = int.Parse(txtCantitate.Text),
                        Pret = decimal.Parse(txtPret.Text),
                        DataExpirare = dtpDataExpirare.Value,
                        Furnizor = txtFurnizor.Text,
                        LocatieStoc = txtLocatieStoc.Text,
                        Greutate = double.Parse(txtGreutate.Text),
                        Lungime = double.Parse(txtLungime.Text),
                        Latime = double.Parse(txtLatime.Text),
                        Inaltime = double.Parse(txtInaltime.Text),
                        DataAdaugareStoc = dtpDataAdaugareStoc.Value,
                        TipOperatie = (TipOperatie)cmbTipOperatie.SelectedItem,
                        Categorie = (CategorieMaterial)cmbCategorieMaterial.SelectedItem 
                    };

                    materiale.Add(material);
                    dbContext.Materiale.Add(material);
                    dbContext.SaveChanges();

                    IncarcaDate();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la adăugarea materialului: " + ex.Message);
                    LogError(ex);
                }
            }
        }

        private void Actualizeaza(object sender, EventArgs e)
        {
            if (ValidateChildren() && dataGridViewMateriale.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedRow = dataGridViewMateriale.SelectedRows[0];
                    var materialId = (int)selectedRow.Cells["Id"].Value;
                    var material = materiale.First(m => m.Id == materialId);

                    material.Nume = txtNume.Text;
                    material.CodDeBare = txtCodDeBare.Text;
                    material.Cantitate = int.Parse(txtCantitate.Text);
                    material.Pret = decimal.Parse(txtPret.Text);
                    material.DataExpirare = dtpDataExpirare.Value;
                    material.Furnizor = txtFurnizor.Text;
                    material.LocatieStoc = txtLocatieStoc.Text;
                    material.Greutate = double.Parse(txtGreutate.Text);
                    material.Lungime = double.Parse(txtLungime.Text);
                    material.Latime = double.Parse(txtLatime.Text);
                    material.Inaltime = double.Parse(txtInaltime.Text);
                    material.DataAdaugareStoc = dtpDataAdaugareStoc.Value;
                    material.TipOperatie = (TipOperatie)cmbTipOperatie.SelectedItem;
                    material.Categorie = (CategorieMaterial)cmbCategorieMaterial.SelectedItem; 

                    dbContext.Entry(material).State = EntityState.Modified;
                    dbContext.SaveChanges();

                    IncarcaDate();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la actualizarea materialului: " + ex.Message);
                    LogError(ex);
                }
            }
        }

        private void Sterge(object sender, EventArgs e)
        {
            if (dataGridViewMateriale.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedRow = dataGridViewMateriale.SelectedRows[0];
                    var materialId = (int)selectedRow.Cells["Id"].Value;
                    var material = materiale.First(m => m.Id == materialId);

                    materiale.Remove(material);
                    dbContext.Materiale.Remove(material);
                    dbContext.SaveChanges();

                    IncarcaDate();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la ștergerea materialului: " + ex.Message);
                    LogError(ex);
                }
            }
        }

        private void Salveaza(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter("materiale.txt"))
                {
                    foreach (var material in materiale)
                    {
                        writer.WriteLine($"{material.Nume},{material.CodDeBare},{material.Cantitate},{material.Pret},{material.DataExpirare},{material.Furnizor},{material.LocatieStoc},{material.Greutate},{material.Lungime},{material.Latime},{material.Inaltime},{material.DataAdaugareStoc},{material.TipOperatie},{material.Categorie}");
                    }
                }

                MessageBox.Show("Datele au fost salvate cu succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la salvarea datelor: " + ex.Message);
                LogError(ex);
            }
        }

        private void Incarca(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader("materiale.txt"))
                {
                    string line;
                    materiale.Clear();
                    while ((line = reader.ReadLine()) != null)
                    {
                        var values = line.Split(',');
                        var material = new Material
                        {
                            Nume = values[0],
                            CodDeBare = values[1],
                            Cantitate = int.Parse(values[2]),
                            Pret = decimal.Parse(values[3]),
                            DataExpirare = DateTime.Parse(values[4]),
                            Furnizor = values[5],
                            LocatieStoc = values[6],
                            Greutate = double.Parse(values[7]),
                            Lungime = double.Parse(values[8]),
                            Latime = double.Parse(values[9]),
                            Inaltime = double.Parse(values[10]),
                            DataAdaugareStoc = DateTime.Parse(values[11]),
                            TipOperatie = (TipOperatie)Enum.Parse(typeof(TipOperatie), values[12]),
                            Categorie = (CategorieMaterial)Enum.Parse(typeof(CategorieMaterial), values[13]) 
                        };
                        materiale.Add(material);
                    }

                    dbContext.Materiale.RemoveRange(dbContext.Materiale);
                    dbContext.Materiale.AddRange(materiale);
                    dbContext.SaveChanges();

                    IncarcaDate();
                    MessageBox.Show("Datele au fost încărcate cu succes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la încărcarea datelor: " + ex.Message);
                LogError(ex);
            }
        }

        private void Exporta(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter("raport_materiale.txt"))
                {
                    writer.WriteLine("Raport materiale:");
                    foreach (var material in materiale)
                    {
                        writer.WriteLine($"{material.Nume} - {material.CodDeBare} - {material.Cantitate} - {material.Pret} - {material.Furnizor} - {material.TipOperatie} - {material.Categorie}");
                    }
                }

                MessageBox.Show("Raportul a fost exportat cu succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la exportarea raportului: " + ex.Message);
                LogError(ex);
            }
        }

        private void ClearFields()
        {
            txtNume.Clear();
            txtCodDeBare.Clear();
            txtCantitate.Clear();
            txtPret.Clear();
            txtFurnizor.Clear();
            txtLocatieStoc.Clear();
            txtGreutate.Clear();
            txtLungime.Clear();
            txtLatime.Clear();
            txtInaltime.Clear();
            dtpDataExpirare.Value = DateTime.Now;
            dtpDataAdaugareStoc.Value = DateTime.Now;
            cmbTipOperatie.SelectedIndex = -1; 
            cmbCategorieMaterial.SelectedIndex = -1; 
        }

        private void DrawChart()
        {
            var chartForm = new Form
            {
                Text = "Statistici Materiale",
                Width = 800,
                Height = 600
            };

            chartForm.Paint += (s, e) =>
            {
                var graphics = e.Graphics;
                var materialsByCategory = materiale.GroupBy(m => m.Furnizor)
                    .Select(g => new { Furnizor = g.Key, Count = g.Count() })
                    .ToList();

                var maxCount = materialsByCategory.Max(m => m.Count);
                var scaleFactor = 400.0 / maxCount;
                var brush = new SolidBrush(Color.Blue);

                for (int i = 0; i < materialsByCategory.Count; i++)
                {
                    var barHeight = (int)(materialsByCategory[i].Count * scaleFactor);
                    graphics.FillRectangle(brush, new Rectangle(100 + i * 100, 500 - barHeight, 50, barHeight));
                    graphics.DrawString(materialsByCategory[i].Furnizor, new Font("Arial", 10), Brushes.Black, new PointF(100 + i * 100, 510));
                }
            };

            chartForm.ShowDialog();
        }

        private void DataGridViewMateriale_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMateriale.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMateriale.SelectedRows[0];
                var materialId = (int)selectedRow.Cells["Id"].Value;
                var selectedMaterial = dbContext.Materiale.Include(m => m.Operatii).FirstOrDefault(m => m.Id == materialId);

                if (selectedMaterial != null)
                {
                    txtNume.Text = selectedMaterial.Nume;
                    txtCodDeBare.Text = selectedMaterial.CodDeBare;
                    txtCantitate.Text = selectedMaterial.Cantitate.ToString();
                    txtPret.Text = selectedMaterial.Pret.ToString();
                    txtFurnizor.Text = selectedMaterial.Furnizor;
                    txtLocatieStoc.Text = selectedMaterial.LocatieStoc;
                    txtGreutate.Text = selectedMaterial.Greutate.ToString();
                    txtLungime.Text = selectedMaterial.Lungime.ToString();
                    txtLatime.Text = selectedMaterial.Latime.ToString();
                    txtInaltime.Text = selectedMaterial.Inaltime.ToString();
                    dtpDataExpirare.Value = selectedMaterial.DataExpirare;
                    dtpDataAdaugareStoc.Value = selectedMaterial.DataAdaugareStoc;
                    cmbTipOperatie.SelectedItem = selectedMaterial.TipOperatie; 
                    cmbCategorieMaterial.SelectedItem = selectedMaterial.Categorie; 

                    materialControl.SetMaterial(selectedMaterial);
                }
            }
        }

        public void SalveazaMateriale(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, materiale);
            }
        }

        public void IncarcaMateriale(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                materiale = (List<Material>)binaryFormatter.Deserialize(stream);
                dataGridViewMateriale.DataSource = materiale;
            }
        }

        private void txtNume_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                e.Cancel = true;
                txtNume.Focus();
                errorProvider.SetError(txtNume, "Numele nu poate fi gol!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNume, "");
            }
        }

        private void txtCodDeBare_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodDeBare.Text))
            {
                e.Cancel = true;
                txtCodDeBare.Focus();
                errorProvider.SetError(txtCodDeBare, "Codul de bare nu poate fi gol!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCodDeBare, "");
            }
        }

        private void txtCantitate_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtCantitate.Text, out _))
            {
                e.Cancel = true;
                txtCantitate.Focus();
                errorProvider.SetError(txtCantitate, "Cantitatea trebuie să fie un număr pozitiv!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCantitate, "");
            }
        }

        private void txtPret_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(txtPret.Text, out _))
            {
                e.Cancel = true;
                txtPret.Focus();
                errorProvider.SetError(txtPret, "Prețul trebuie să fie un număr pozitiv!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPret, "");
            }
        }

        private void LogError(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter("error_log.txt", true))
            {
                writer.WriteLine($"{DateTime.Now}: {ex.Message}");
                writer.WriteLine(ex.StackTrace);
            }
        }

        private void Printare(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrevizualizarePrintare(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            e.Graphics.DrawString("Raport Materiale", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 100, 100);

            int yPosition = 150;
            foreach (var material in materiale)
            {
                string text = $"Nume: {material.Nume}, Cod De Bare: {material.CodDeBare}, Cantitate: {material.Cantitate}, Pret: {material.Pret}";
                e.Graphics.DrawString(text, new Font("Arial", 12), Brushes.Black, 100, yPosition);
                yPosition += 25;
            }
        }

        private void dataGridViewMateriale_MouseDown(object sender, MouseEventArgs e)
        {
            if (dataGridViewMateriale.SelectedRows.Count > 0)
            {
                var selectedMaterial = dataGridViewMateriale.SelectedRows[0].DataBoundItem as Material;
                if (selectedMaterial != null)
                {
                    dataGridViewMateriale.DoDragDrop(selectedMaterial.Nume, DragDropEffects.Copy);
                }
            }
        }

        private void txtNume_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtNume_DragDrop(object sender, DragEventArgs e)
        {
            txtNume.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void Copiere(object sender, EventArgs e)
        {
            if (dataGridViewMateriale.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMateriale.SelectedRows[0];
                var material = new Material
                {
                    Nume = selectedRow.Cells["Nume"].Value.ToString(),
                    CodDeBare = selectedRow.Cells["CodDeBare"].Value.ToString(),
                    Cantitate = int.Parse(selectedRow.Cells["Cantitate"].Value.ToString()),
                    Pret = decimal.Parse(selectedRow.Cells["Pret"].Value.ToString()),
                    DataExpirare = DateTime.Parse(selectedRow.Cells["DataExpirare"].Value.ToString()),
                    Furnizor = selectedRow.Cells["Furnizor"].Value.ToString(),
                    LocatieStoc = selectedRow.Cells["LocatieStoc"].Value.ToString(),
                    Greutate = double.Parse(selectedRow.Cells["Greutate"].Value.ToString()),
                    Lungime = double.Parse(selectedRow.Cells["Lungime"].Value.ToString()),
                    Latime = double.Parse(selectedRow.Cells["Latime"].Value.ToString()),
                    Inaltime = double.Parse(selectedRow.Cells["Inaltime"].Value.ToString()),
                    DataAdaugareStoc = DateTime.Parse(selectedRow.Cells["DataAdaugareStoc"].Value.ToString()),
                    TipOperatie = (TipOperatie)Enum.Parse(typeof(TipOperatie), selectedRow.Cells["TipOperatie"].Value.ToString()),
                    Categorie = (CategorieMaterial)Enum.Parse(typeof(CategorieMaterial), selectedRow.Cells["Categorie"].Value.ToString())
                };

                Clipboard.SetData("Material", material);
            }
        }

        private void Lipire(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData("Material"))
            {
                var material = (Material)Clipboard.GetData("Material");
                materiale.Add(material);
                dbContext.Materiale.Add(material);
                dbContext.SaveChanges();

                IncarcaDate();
            }
        }
    }
}
