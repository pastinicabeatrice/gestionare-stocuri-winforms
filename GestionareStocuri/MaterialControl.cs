using System.Windows.Forms;

namespace Gestionare_Stocuri
{
    public partial class MaterialControl : UserControl
    {
        public MaterialControl()
        {
            InitializeComponent();
        }

        public void SetMaterial(Material material)
        {
            lblNume.Text = material.Nume;
            lblCodDeBare.Text = material.CodDeBare;
            lblCantitate.Text = material.Cantitate.ToString();
            lblPret.Text = material.Pret.ToString();
            lblFurnizor.Text = material.Furnizor;
            lblLocatieStoc.Text = material.LocatieStoc;
            lblGreutate.Text = material.Greutate.ToString();
            lblLungime.Text = material.Lungime.ToString();
            lblLatime.Text = material.Latime.ToString();
            lblInaltime.Text = material.Inaltime.ToString();
            lblDataExpirare.Text = material.DataExpirare.ToShortDateString();
            lblDataAdaugareStoc.Text = material.DataAdaugareStoc.ToShortDateString();
        }

        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblCodDeBare = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblFurnizor = new System.Windows.Forms.Label();
            this.lblLocatieStoc = new System.Windows.Forms.Label();
            this.lblGreutate = new System.Windows.Forms.Label();
            this.lblLungime = new System.Windows.Forms.Label();
            this.lblLatime = new System.Windows.Forms.Label();
            this.lblInaltime = new System.Windows.Forms.Label();
            this.lblDataExpirare = new System.Windows.Forms.Label();
            this.lblDataAdaugareStoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(56, 14);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(68, 25);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            this.lblCodDeBare.AutoSize = true;
            this.lblCodDeBare.Location = new System.Drawing.Point(56, 41);
            this.lblCodDeBare.Name = "lblCodDeBare";
            this.lblCodDeBare.Size = new System.Drawing.Size(135, 25);
            this.lblCodDeBare.TabIndex = 1;
            this.lblCodDeBare.Text = "Cod De Bare";
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(56, 68);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(98, 25);
            this.lblCantitate.TabIndex = 2;
            this.lblCantitate.Text = "Cantitate";
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(56, 95);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(51, 25);
            this.lblPret.TabIndex = 3;
            this.lblPret.Text = "Pret";
            this.lblFurnizor.AutoSize = true;
            this.lblFurnizor.Location = new System.Drawing.Point(56, 122);
            this.lblFurnizor.Name = "lblFurnizor";
            this.lblFurnizor.Size = new System.Drawing.Size(91, 25);
            this.lblFurnizor.TabIndex = 4;
            this.lblFurnizor.Text = "Furnizor";
            this.lblLocatieStoc.AutoSize = true;
            this.lblLocatieStoc.Location = new System.Drawing.Point(56, 148);
            this.lblLocatieStoc.Name = "lblLocatieStoc";
            this.lblLocatieStoc.Size = new System.Drawing.Size(131, 25);
            this.lblLocatieStoc.TabIndex = 5;
            this.lblLocatieStoc.Text = "Locatie Stoc";
            this.lblGreutate.AutoSize = true;
            this.lblGreutate.Location = new System.Drawing.Point(56, 178);
            this.lblGreutate.Name = "lblGreutate";
            this.lblGreutate.Size = new System.Drawing.Size(95, 25);
            this.lblGreutate.TabIndex = 6;
            this.lblGreutate.Text = "Greutate";
            this.lblLungime.AutoSize = true;
            this.lblLungime.Location = new System.Drawing.Point(57, 206);
            this.lblLungime.Name = "lblLungime";
            this.lblLungime.Size = new System.Drawing.Size(94, 25);
            this.lblLungime.TabIndex = 7;
            this.lblLungime.Text = "Lungime";
            this.lblLatime.AutoSize = true;
            this.lblLatime.Location = new System.Drawing.Point(56, 234);
            this.lblLatime.Name = "lblLatime";
            this.lblLatime.Size = new System.Drawing.Size(76, 25);
            this.lblLatime.TabIndex = 8;
            this.lblLatime.Text = "Latime";
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.Location = new System.Drawing.Point(56, 262);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(86, 25);
            this.lblInaltime.TabIndex = 9;
            this.lblInaltime.Text = "Inaltime";
            this.lblDataExpirare.AutoSize = true;
            this.lblDataExpirare.Location = new System.Drawing.Point(57, 290);
            this.lblDataExpirare.Name = "lblDataExpirare";
            this.lblDataExpirare.Size = new System.Drawing.Size(143, 25);
            this.lblDataExpirare.TabIndex = 10;
            this.lblDataExpirare.Text = "Data Expirare";
            this.lblDataAdaugareStoc.AutoSize = true;
            this.lblDataAdaugareStoc.Location = new System.Drawing.Point(57, 321);
            this.lblDataAdaugareStoc.Name = "lblDataAdaugareStoc";
            this.lblDataAdaugareStoc.Size = new System.Drawing.Size(156, 25);
            this.lblDataAdaugareStoc.TabIndex = 11;
            this.lblDataAdaugareStoc.Text = "Data Adăugare";
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblCodDeBare);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblFurnizor);
            this.Controls.Add(this.lblLocatieStoc);
            this.Controls.Add(this.lblGreutate);
            this.Controls.Add(this.lblLungime);
            this.Controls.Add(this.lblLatime);
            this.Controls.Add(this.lblInaltime);
            this.Controls.Add(this.lblDataExpirare);
            this.Controls.Add(this.lblDataAdaugareStoc);
            this.Name = "MaterialControl";
            this.Size = new System.Drawing.Size(608, 621);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblNume;
        private Label lblCodDeBare;
        private Label lblCantitate;
        private Label lblPret;
        private Label lblFurnizor;
        private Label lblLocatieStoc;
        private Label lblGreutate;
        private Label lblLungime;
        private Label lblLatime;
        private Label lblInaltime;
        private Label lblDataExpirare;
        private Label lblDataAdaugareStoc;
    }
}
