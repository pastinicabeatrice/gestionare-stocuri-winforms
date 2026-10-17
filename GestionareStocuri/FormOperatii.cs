using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Gestionare_Stocuri
{
    public partial class FormOperatii : Form
    {
        private List<Operatie> operatii;
        private List<Material> materiale;
        private ErrorProvider errorProviderOperatii;

        public FormOperatii(List<Operatie> operatiiExistente)
        {
            InitializeComponent();
            operatii = operatiiExistente;
            materiale = operatiiExistente.Select(o => o.MaterialUtilizat).Distinct().ToList();
            errorProviderOperatii = new ErrorProvider();

            cmbMaterialUtilizat.DataSource = materiale;
            cmbMaterialUtilizat.DisplayMember = "Nume";
            cmbMaterialUtilizat.ValueMember = "Id";
            cmbTipOperatie.DataSource = Enum.GetValues(typeof(TipOperatie));

            RefreshOperatiiGrid();
        }

        private void FormOperatii_Load(object sender, EventArgs e)
        {
            txtCantitate.Validating += new CancelEventHandler(txtCantitate_Validating);
        }

        private void Adauga(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var material = materiale.Find(m => m.Id == (int)cmbMaterialUtilizat.SelectedValue);
                var operatie = new Operatie(
                    operatii.Any() ? operatii.Max(o => o.Id) + 1 : 1,
                    (TipOperatie)cmbTipOperatie.SelectedItem,
                    material,
                    int.Parse(txtCantitate.Text),
                    dtpDataOperatie.Value);

                operatii.Add(operatie);
                RefreshOperatiiGrid();
                ClearFields();
            }
        }

        private void Actualizeaza(object sender, EventArgs e)
        {
            if (ValidateChildren() && dataGridViewOperatii.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewOperatii.SelectedRows[0].Cells[0].Value.ToString());
                var operatie = operatii.Find(o => o.Id == id);
                if (operatie != null)
                {
                    var material = materiale.Find(m => m.Id == (int)cmbMaterialUtilizat.SelectedValue);
                    operatie.ActualizeazaOperatie(
                        (TipOperatie)cmbTipOperatie.SelectedItem,
                        material,
                        int.Parse(txtCantitate.Text),
                        dtpDataOperatie.Value);

                    RefreshOperatiiGrid();
                    ClearFields();
                }
            }
        }

        private void Sterge(object sender, EventArgs e)
        {
            if (dataGridViewOperatii.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewOperatii.SelectedRows[0].Cells[0].Value.ToString());
                var operatie = operatii.Find(o => o.Id == id);
                if (operatie != null)
                {
                    operatii.Remove(operatie);
                    RefreshOperatiiGrid();
                    ClearFields();
                }
            }
        }

        private void RefreshOperatiiGrid()
        {
            dataGridViewOperatii.DataSource = null;
            dataGridViewOperatii.DataSource = operatii;
        }

        private void ClearFields()
        {
            cmbTipOperatie.SelectedIndex = -1;
            cmbMaterialUtilizat.SelectedIndex = -1;
            txtCantitate.Text = "";
            dtpDataOperatie.Value = DateTime.Now;
        }

        private void txtCantitate_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtCantitate.Text, out int cantitate) || cantitate <= 0)
            {
                e.Cancel = true;
                errorProviderOperatii.SetError(txtCantitate, "Cantitatea trebuie să fie un număr pozitiv.");
            }
            else
            {
                e.Cancel = false;
                errorProviderOperatii.SetError(txtCantitate, null);
            }
        }
    }
}
