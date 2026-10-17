namespace Gestionare_Stocuri
{
    partial class FormOperatii
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOperatii;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.DateTimePicker dtpDataOperatie;
        private System.Windows.Forms.ComboBox cmbMaterialUtilizat;
        private System.Windows.Forms.ComboBox cmbTipOperatie;
        private System.Windows.Forms.Button butonAdauga;
        private System.Windows.Forms.Button butonActualizeaza;
        private System.Windows.Forms.Button butonSterge;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Label lblDataOperatie;
        private System.Windows.Forms.Label lblMaterialUtilizat;
        private System.Windows.Forms.Label lblTipOperatie;
        private System.Windows.Forms.ErrorProvider errorProviderOperatie;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewOperatii = new System.Windows.Forms.DataGridView();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.dtpDataOperatie = new System.Windows.Forms.DateTimePicker();
            this.cmbMaterialUtilizat = new System.Windows.Forms.ComboBox();
            this.cmbTipOperatie = new System.Windows.Forms.ComboBox();
            this.butonAdauga = new System.Windows.Forms.Button();
            this.butonActualizeaza = new System.Windows.Forms.Button();
            this.butonSterge = new System.Windows.Forms.Button();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.lblDataOperatie = new System.Windows.Forms.Label();
            this.lblMaterialUtilizat = new System.Windows.Forms.Label();
            this.lblTipOperatie = new System.Windows.Forms.Label();
            this.errorProviderOperatie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOperatie)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewOperatii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperatii.Location = new System.Drawing.Point(12, 150);
            this.dataGridViewOperatii.Name = "dataGridViewOperatii";
            this.dataGridViewOperatii.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewOperatii.TabIndex = 0;

            this.txtCantitate.Location = new System.Drawing.Point(120, 12);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(200, 20);
            this.txtCantitate.TabIndex = 1;

            this.dtpDataOperatie.Location = new System.Drawing.Point(120, 38);
            this.dtpDataOperatie.Name = "dtpDataOperatie";
            this.dtpDataOperatie.Size = new System.Drawing.Size(200, 20);
            this.dtpDataOperatie.TabIndex = 2;

            this.cmbMaterialUtilizat.FormattingEnabled = true;
            this.cmbMaterialUtilizat.Location = new System.Drawing.Point(120, 64);
            this.cmbMaterialUtilizat.Name = "cmbMaterialUtilizat";
            this.cmbMaterialUtilizat.Size = new System.Drawing.Size(200, 21);
            this.cmbMaterialUtilizat.TabIndex = 3;

            this.cmbTipOperatie.FormattingEnabled = true;
            this.cmbTipOperatie.Location = new System.Drawing.Point(120, 91);
            this.cmbTipOperatie.Name = "cmbTipOperatie";
            this.cmbTipOperatie.Size = new System.Drawing.Size(200, 21);
            this.cmbTipOperatie.TabIndex = 4;

            this.butonAdauga.Location = new System.Drawing.Point(340, 10);
            this.butonAdauga.Name = "butonAdauga";
            this.butonAdauga.Size = new System.Drawing.Size(75, 23);
            this.butonAdauga.TabIndex = 5;
            this.butonAdauga.Text = "Adaugă";
            this.butonAdauga.UseVisualStyleBackColor = true;
            this.butonAdauga.Click += new System.EventHandler(this.Adauga);

            this.butonActualizeaza.Location = new System.Drawing.Point(340, 38);
            this.butonActualizeaza.Name = "butonActualizeaza";
            this.butonActualizeaza.Size = new System.Drawing.Size(75, 23);
            this.butonActualizeaza.TabIndex = 6;
            this.butonActualizeaza.Text = "Actualizează";
            this.butonActualizeaza.UseVisualStyleBackColor = true;
            this.butonActualizeaza.Click += new System.EventHandler(this.Actualizeaza);

            this.butonSterge.Location = new System.Drawing.Point(340, 66);
            this.butonSterge.Name = "butonSterge";
            this.butonSterge.Size = new System.Drawing.Size(75, 23);
            this.butonSterge.TabIndex = 7;
            this.butonSterge.Text = "Șterge";
            this.butonSterge.UseVisualStyleBackColor = true;
            this.butonSterge.Click += new System.EventHandler(this.Sterge);

            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(12, 15);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(49, 13);
            this.lblCantitate.TabIndex = 8;
            this.lblCantitate.Text = "Cantitate";

            this.lblDataOperatie.AutoSize = true;
            this.lblDataOperatie.Location = new System.Drawing.Point(12, 44);
            this.lblDataOperatie.Name = "lblDataOperatie";
            this.lblDataOperatie.Size = new System.Drawing.Size(76, 13);
            this.lblDataOperatie.TabIndex = 9;
            this.lblDataOperatie.Text = "Data Operatie";

            this.lblMaterialUtilizat.AutoSize = true;
            this.lblMaterialUtilizat.Location = new System.Drawing.Point(12, 67);
            this.lblMaterialUtilizat.Name = "lblMaterialUtilizat";
            this.lblMaterialUtilizat.Size = new System.Drawing.Size(78, 13);
            this.lblMaterialUtilizat.TabIndex = 10;
            this.lblMaterialUtilizat.Text = "Material Utilizat";

            this.lblTipOperatie.AutoSize = true;
            this.lblTipOperatie.Location = new System.Drawing.Point(12, 94);
            this.lblTipOperatie.Name = "lblTipOperatie";
            this.lblTipOperatie.Size = new System.Drawing.Size(64, 13);
            this.lblTipOperatie.TabIndex = 11;
            this.lblTipOperatie.Text = "Tip Operatie";

            this.errorProviderOperatie.ContainerControl = this;

            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTipOperatie);
            this.Controls.Add(this.lblMaterialUtilizat);
            this.Controls.Add(this.lblDataOperatie);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.butonSterge);
            this.Controls.Add(this.butonActualizeaza);
            this.Controls.Add(this.butonAdauga);
            this.Controls.Add(this.cmbTipOperatie);
            this.Controls.Add(this.cmbMaterialUtilizat);
            this.Controls.Add(this.dtpDataOperatie);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.dataGridViewOperatii);
            this.Name = "FormOperatii";
            this.Text = "Gestionare Operatii";
            this.Load += new System.EventHandler(this.FormOperatii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperatii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOperatie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
