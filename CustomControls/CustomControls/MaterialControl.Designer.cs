using System.Windows.Forms;

namespace CustomControls
{
    partial class MaterialControl
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNume;
        private TextBox txtCodDeBare;
        private TextBox txtCantitate;
        private TextBox txtPret;
        private DateTimePicker dtpDataExpirare;

        private void InitializeComponent()
        {
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCodDeBare = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.dtpDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();

            this.txtNume.Location = new System.Drawing.Point(10, 10);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(150, 20);
            this.txtNume.TabIndex = 0;
            this.txtCodDeBare.Location = new System.Drawing.Point(10, 40);
            this.txtCodDeBare.Name = "txtCodDeBare";
            this.txtCodDeBare.Size = new System.Drawing.Size(150, 20);
            this.txtCodDeBare.TabIndex = 1;
            this.txtCantitate.Location = new System.Drawing.Point(10, 70);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(150, 20);
            this.txtCantitate.TabIndex = 2;
            this.txtPret.Location = new System.Drawing.Point(10, 100);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(150, 20);
            this.txtPret.TabIndex = 3;
            this.dtpDataExpirare.Location = new System.Drawing.Point(10, 130);
            this.dtpDataExpirare.Name = "dtpDataExpirare";
            this.dtpDataExpirare.Size = new System.Drawing.Size(150, 20);
            this.dtpDataExpirare.TabIndex = 4;

            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCodDeBare);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.dtpDataExpirare);
            this.Name = "MaterialControl";
            this.Size = new System.Drawing.Size(200, 160);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
