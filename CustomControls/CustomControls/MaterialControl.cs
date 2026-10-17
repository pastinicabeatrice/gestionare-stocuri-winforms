using System;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class MaterialControl : UserControl
    {
        public string MaterialName
        {
            get => txtNume.Text;
            set => txtNume.Text = value;
        }

        public string CodDeBare
        {
            get => txtCodDeBare.Text;
            set => txtCodDeBare.Text = value;
        }

        public int Cantitate
        {
            get => int.Parse(txtCantitate.Text);
            set => txtCantitate.Text = value.ToString();
        }

        public decimal Pret
        {
            get => decimal.Parse(txtPret.Text);
            set => txtPret.Text = value.ToString();
        }

        public DateTime DataExpirare
        {
            get => dtpDataExpirare.Value;
            set => dtpDataExpirare.Value = value;
        }

        public MaterialControl()
        {
            InitializeComponent();
        }
    }
}
