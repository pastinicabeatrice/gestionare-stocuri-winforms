using System;
using System.Linq;

namespace Gestionare_Stocuri
{
    partial class FormMateriale
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMateriale;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCodDeBare;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtFurnizor;
        private System.Windows.Forms.TextBox txtLocatieStoc;
        private System.Windows.Forms.TextBox txtGreutate;
        private System.Windows.Forms.TextBox txtLungime;
        private System.Windows.Forms.TextBox txtLatime;
        private System.Windows.Forms.TextBox txtInaltime;
        private System.Windows.Forms.DateTimePicker dtpDataExpirare;
        private System.Windows.Forms.DateTimePicker dtpDataAdaugareStoc;
        private System.Windows.Forms.Button butonAdauga;
        private System.Windows.Forms.Button butonActualizeaza;
        private System.Windows.Forms.Button butonSterge;
        private System.Windows.Forms.Button butonSalveaza;
        private System.Windows.Forms.Button butonIncarca;
        private System.Windows.Forms.Button butonExporta;
        private System.Windows.Forms.Button butonGenereazaGrafic;
        private System.Windows.Forms.Button butonVizualizeazaOperatii;
        private System.Windows.Forms.ComboBox cmbTipOperatie;
        private System.Windows.Forms.ComboBox cmbCategorieMaterial;
        private System.Windows.Forms.ErrorProvider errorProviderStocuri;

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblCodDeBare;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblFurnizor;
        private System.Windows.Forms.Label lblLocatieStoc;
        private System.Windows.Forms.Label lblGreutate;
        private System.Windows.Forms.Label lblLungime;
        private System.Windows.Forms.Label lblLatime;
        private System.Windows.Forms.Label lblInaltime;
        private System.Windows.Forms.Label lblDataExpirare;
        private System.Windows.Forms.Label lblDataAdaugareStoc;
        private System.Windows.Forms.Label lblTipOperatie;
        private System.Windows.Forms.Label lblCategorieMaterial;

        private System.Windows.Forms.MenuStrip baraDeMeniu;
        private System.Windows.Forms.ToolStrip baraDeInstrumente;
        private System.Windows.Forms.StatusStrip baraDeStare;
        private System.Windows.Forms.ToolStripStatusLabel baraDeStareLabel;
        private System.Windows.Forms.ContextMenuStrip meniuContextual;
        private System.Windows.Forms.ToolStripMenuItem optiuneSterge;

        private System.Windows.Forms.Button butonPrintare;
        private System.Windows.Forms.Button butonPrevizualizarePrintare;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button butonCopiere;
        private System.Windows.Forms.Button butonLipire;

        private MaterialControl materialControl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProviderStocuri = new System.Windows.Forms.ErrorProvider(this.components);
            this.baraDeMeniu = new System.Windows.Forms.MenuStrip();
            this.baraDeInstrumente = new System.Windows.Forms.ToolStrip();
            this.baraDeStare = new System.Windows.Forms.StatusStrip();
            this.baraDeStareLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.meniuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optiuneSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMateriale = new System.Windows.Forms.DataGridView();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCodDeBare = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtFurnizor = new System.Windows.Forms.TextBox();
            this.txtLocatieStoc = new System.Windows.Forms.TextBox();
            this.txtGreutate = new System.Windows.Forms.TextBox();
            this.txtLungime = new System.Windows.Forms.TextBox();
            this.txtLatime = new System.Windows.Forms.TextBox();
            this.txtInaltime = new System.Windows.Forms.TextBox();
            this.dtpDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.dtpDataAdaugareStoc = new System.Windows.Forms.DateTimePicker();
            this.butonAdauga = new System.Windows.Forms.Button();
            this.butonActualizeaza = new System.Windows.Forms.Button();
            this.butonSterge = new System.Windows.Forms.Button();
            this.butonSalveaza = new System.Windows.Forms.Button();
            this.butonIncarca = new System.Windows.Forms.Button();
            this.butonExporta = new System.Windows.Forms.Button();
            this.butonGenereazaGrafic = new System.Windows.Forms.Button();
            this.butonVizualizeazaOperatii = new System.Windows.Forms.Button();
            this.cmbTipOperatie = new System.Windows.Forms.ComboBox();
            this.cmbCategorieMaterial = new System.Windows.Forms.ComboBox();

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
            this.lblTipOperatie = new System.Windows.Forms.Label();
            this.lblCategorieMaterial = new System.Windows.Forms.Label();

            this.materialControl = new MaterialControl();

            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStocuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriale)).BeginInit();
            this.baraDeMeniu.SuspendLayout();
            this.baraDeInstrumente.SuspendLayout();
            this.baraDeStare.SuspendLayout();
            this.meniuContextual.SuspendLayout();
            this.SuspendLayout();

            this.errorProviderStocuri.ContainerControl = this;

            this.baraDeMeniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                new System.Windows.Forms.ToolStripMenuItem("Fișier", null, new System.Windows.Forms.ToolStripItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("Salvează", null, this.MeniuSalveaza),
                    new System.Windows.Forms.ToolStripMenuItem("Încarcă", null, this.MeniuIncarca),
                    new System.Windows.Forms.ToolStripMenuItem("Exportă", null, this.MeniuExporta),
                    new System.Windows.Forms.ToolStripMenuItem("Ieșire", null, this.MeniuIesire)
                })
            });
            this.baraDeMeniu.Location = new System.Drawing.Point(0, 0);
            this.baraDeMeniu.Name = "baraDeMeniu";
            this.baraDeMeniu.Size = new System.Drawing.Size(1200, 24);
            this.baraDeMeniu.TabIndex = 0;
            this.baraDeMeniu.Text = "baraDeMeniu";

            this.baraDeInstrumente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                new System.Windows.Forms.ToolStripButton("Adaugă", null, this.InstrumentAdauga),
                new System.Windows.Forms.ToolStripButton("Actualizează", null, this.InstrumentActualizeaza),
                new System.Windows.Forms.ToolStripButton("Șterge", null, this.InstrumentSterge)
            });
            this.baraDeInstrumente.Location = new System.Drawing.Point(0, 24);
            this.baraDeInstrumente.Name = "baraDeInstrumente";
            this.baraDeInstrumente.Size = new System.Drawing.Size(1200, 25);
            this.baraDeInstrumente.TabIndex = 1;
            this.baraDeInstrumente.Text = "baraDeInstrumente";

            this.baraDeStare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.baraDeStareLabel
            });
            this.baraDeStare.Location = new System.Drawing.Point(0, 578);
            this.baraDeStare.Name = "baraDeStare";
            this.baraDeStare.Size = new System.Drawing.Size(1200, 22);
            this.baraDeStare.TabIndex = 2;
            this.baraDeStare.Text = "baraDeStare";
            this.baraDeStareLabel.Name = "baraDeStareLabel";
            this.baraDeStareLabel.Size = new System.Drawing.Size(118, 17);
            this.baraDeStareLabel.Text = "Gata";

            this.meniuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.optiuneSterge
            });
            this.meniuContextual.Name = "meniuContextual";
            this.meniuContextual.Size = new System.Drawing.Size(108, 26);
            this.dataGridViewMateriale.ContextMenuStrip = this.meniuContextual;
            this.optiuneSterge.Name = "optiuneSterge";
            this.optiuneSterge.Size = new System.Drawing.Size(107, 22);
            this.optiuneSterge.Text = "Șterge";
            this.optiuneSterge.Click += new System.EventHandler(this.Sterge);

            this.dataGridViewMateriale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriale.Location = new System.Drawing.Point(12, 350);
            this.dataGridViewMateriale.Name = "dataGridViewMateriale";
            this.dataGridViewMateriale.Size = new System.Drawing.Size(1176, 220);
            this.dataGridViewMateriale.TabIndex = 3;
            this.dataGridViewMateriale.SelectionChanged += new System.EventHandler(this.DataGridViewMateriale_SelectionChanged);

            this.txtNume.Location = new System.Drawing.Point(120, 40);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 20);
            this.txtNume.TabIndex = 4;
            this.txtNume.Validating += new System.ComponentModel.CancelEventHandler(this.txtNume_Validating);

            this.txtCodDeBare.Location = new System.Drawing.Point(120, 70);
            this.txtCodDeBare.Name = "txtCodDeBare";
            this.txtCodDeBare.Size = new System.Drawing.Size(200, 20);
            this.txtCodDeBare.TabIndex = 5;
            this.txtCodDeBare.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodDeBare_Validating);

            this.txtCantitate.Location = new System.Drawing.Point(120, 100);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(200, 20);
            this.txtCantitate.TabIndex = 6;
            this.txtCantitate.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantitate_Validating);

            this.txtPret.Location = new System.Drawing.Point(120, 130);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(200, 20);
            this.txtPret.TabIndex = 7;
            this.txtPret.Validating += new System.ComponentModel.CancelEventHandler(this.txtPret_Validating);

            this.txtFurnizor.Location = new System.Drawing.Point(120, 160);
            this.txtFurnizor.Name = "txtFurnizor";
            this.txtFurnizor.Size = new System.Drawing.Size(200, 20);
            this.txtFurnizor.TabIndex = 8;

            this.txtLocatieStoc.Location = new System.Drawing.Point(120, 190);
            this.txtLocatieStoc.Name = "txtLocatieStoc";
            this.txtLocatieStoc.Size = new System.Drawing.Size(200, 20);
            this.txtLocatieStoc.TabIndex = 9;

            this.txtGreutate.Location = new System.Drawing.Point(120, 220);
            this.txtGreutate.Name = "txtGreutate";
            this.txtGreutate.Size = new System.Drawing.Size(200, 20);
            this.txtGreutate.TabIndex = 10;

            this.txtLungime.Location = new System.Drawing.Point(120, 250);
            this.txtLungime.Name = "txtLungime";
            this.txtLungime.Size = new System.Drawing.Size(200, 20);
            this.txtLungime.TabIndex = 11;

            this.txtLatime.Location = new System.Drawing.Point(120, 280);
            this.txtLatime.Name = "txtLatime";
            this.txtLatime.Size = new System.Drawing.Size(200, 20);
            this.txtLatime.TabIndex = 12;

            this.txtInaltime.Location = new System.Drawing.Point(120, 310);
            this.txtInaltime.Name = "txtInaltime";
            this.txtInaltime.Size = new System.Drawing.Size(200, 20);
            this.txtInaltime.TabIndex = 13;

            this.dtpDataExpirare.Location = new System.Drawing.Point(420, 40);
            this.dtpDataExpirare.Name = "dtpDataExpirare";
            this.dtpDataExpirare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataExpirare.TabIndex = 14;

            this.dtpDataAdaugareStoc.Location = new System.Drawing.Point(420, 70);
            this.dtpDataAdaugareStoc.Name = "dtpDataAdaugareStoc";
            this.dtpDataAdaugareStoc.Size = new System.Drawing.Size(200, 20);
            this.dtpDataAdaugareStoc.TabIndex = 15;

            this.cmbTipOperatie.FormattingEnabled = true;
            this.cmbTipOperatie.Location = new System.Drawing.Point(420, 100);
            this.cmbTipOperatie.Name = "cmbTipOperatie";
            this.cmbTipOperatie.Size = new System.Drawing.Size(200, 21);
            this.cmbTipOperatie.TabIndex = 35;

            this.cmbCategorieMaterial.FormattingEnabled = true;
            this.cmbCategorieMaterial.Location = new System.Drawing.Point(420, 130);
            this.cmbCategorieMaterial.Name = "cmbCategorieMaterial";
            this.cmbCategorieMaterial.Size = new System.Drawing.Size(200, 21);
            this.cmbCategorieMaterial.TabIndex = 36;

            this.butonAdauga.Location = new System.Drawing.Point(650, 40);
            this.butonAdauga.Name = "butonAdauga";
            this.butonAdauga.Size = new System.Drawing.Size(75, 23);
            this.butonAdauga.TabIndex = 16;
            this.butonAdauga.Text = "&Adaugă";
            this.butonAdauga.UseVisualStyleBackColor = true;
            this.butonAdauga.Click += new System.EventHandler(this.Adauga);

            this.butonActualizeaza.Location = new System.Drawing.Point(650, 70);
            this.butonActualizeaza.Name = "butonActualizeaza";
            this.butonActualizeaza.Size = new System.Drawing.Size(75, 23);
            this.butonActualizeaza.TabIndex = 17;
            this.butonActualizeaza.Text = "&Actualizează";
            this.butonActualizeaza.UseVisualStyleBackColor = true;
            this.butonActualizeaza.Click += new System.EventHandler(this.Actualizeaza);

            this.butonSterge.Location = new System.Drawing.Point(650, 100);
            this.butonSterge.Name = "butonSterge";
            this.butonSterge.Size = new System.Drawing.Size(75, 23);
            this.butonSterge.TabIndex = 18;
            this.butonSterge.Text = "&Șterge";
            this.butonSterge.UseVisualStyleBackColor = true;
            this.butonSterge.Click += new System.EventHandler(this.Sterge);

            this.butonSalveaza.Location = new System.Drawing.Point(650, 130);
            this.butonSalveaza.Name = "butonSalveaza";
            this.butonSalveaza.Size = new System.Drawing.Size(75, 23);
            this.butonSalveaza.TabIndex = 19;
            this.butonSalveaza.Text = "&Salvează";
            this.butonSalveaza.UseVisualStyleBackColor = true;
            this.butonSalveaza.Click += new System.EventHandler(this.Salveaza);

            this.butonIncarca.Location = new System.Drawing.Point(650, 160);
            this.butonIncarca.Name = "butonIncarca";
            this.butonIncarca.Size = new System.Drawing.Size(75, 23);
            this.butonIncarca.TabIndex = 20;
            this.butonIncarca.Text = "&Încarcă";
            this.butonIncarca.UseVisualStyleBackColor = true;
            this.butonIncarca.Click += new System.EventHandler(this.Incarca);

            this.butonExporta.Location = new System.Drawing.Point(650, 190);
            this.butonExporta.Name = "butonExporta";
            this.butonExporta.Size = new System.Drawing.Size(75, 23);
            this.butonExporta.TabIndex = 21;
            this.butonExporta.Text = "&Exportă";
            this.butonExporta.UseVisualStyleBackColor = true;
            this.butonExporta.Click += new System.EventHandler(this.Exporta);

            this.butonGenereazaGrafic.Location = new System.Drawing.Point(650, 220);
            this.butonGenereazaGrafic.Name = "butonGenereazaGrafic";
            this.butonGenereazaGrafic.Size = new System.Drawing.Size(120, 23);
            this.butonGenereazaGrafic.TabIndex = 22;
            this.butonGenereazaGrafic.Text = "Generează Grafic";
            this.butonGenereazaGrafic.UseVisualStyleBackColor = true;
            this.butonGenereazaGrafic.Click += new System.EventHandler(this.GenerareGrafic);

            this.butonVizualizeazaOperatii.Location = new System.Drawing.Point(650, 250);
            this.butonVizualizeazaOperatii.Name = "butonVizualizeazaOperatii";
            this.butonVizualizeazaOperatii.Size = new System.Drawing.Size(120, 23);
            this.butonVizualizeazaOperatii.TabIndex = 37;
            this.butonVizualizeazaOperatii.Text = "Vizualizează Operații";
            this.butonVizualizeazaOperatii.UseVisualStyleBackColor = true;
            this.butonVizualizeazaOperatii.Click += new System.EventHandler(this.VizualizeazaOperatii);

            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(12, 43);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 22;
            this.lblNume.Text = "Nume";

            this.lblCodDeBare.AutoSize = true;
            this.lblCodDeBare.Location = new System.Drawing.Point(12, 73);
            this.lblCodDeBare.Name = "lblCodDeBare";
            this.lblCodDeBare.Size = new System.Drawing.Size(67, 13);
            this.lblCodDeBare.TabIndex = 23;
            this.lblCodDeBare.Text = "Cod De Bare";

            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(12, 103);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(49, 13);
            this.lblCantitate.TabIndex = 24;
            this.lblCantitate.Text = "Cantitate";

            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(12, 133);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 25;
            this.lblPret.Text = "Pret";

            this.lblFurnizor.AutoSize = true;
            this.lblFurnizor.Location = new System.Drawing.Point(12, 163);
            this.lblFurnizor.Name = "lblFurnizor";
            this.lblFurnizor.Size = new System.Drawing.Size(45, 13);
            this.lblFurnizor.TabIndex = 26;
            this.lblFurnizor.Text = "Furnizor";

            this.lblLocatieStoc.AutoSize = true;
            this.lblLocatieStoc.Location = new System.Drawing.Point(12, 193);
            this.lblLocatieStoc.Name = "lblLocatieStoc";
            this.lblLocatieStoc.Size = new System.Drawing.Size(67, 13);
            this.lblLocatieStoc.TabIndex = 27;
            this.lblLocatieStoc.Text = "Locatie Stoc";

            this.lblGreutate.AutoSize = true;
            this.lblGreutate.Location = new System.Drawing.Point(12, 223);
            this.lblGreutate.Name = "lblGreutate";
            this.lblGreutate.Size = new System.Drawing.Size(49, 13);
            this.lblGreutate.TabIndex = 28;
            this.lblGreutate.Text = "Greutate";

            this.lblLungime.AutoSize = true;
            this.lblLungime.Location = new System.Drawing.Point(12, 253);
            this.lblLungime.Name = "lblLungime";
            this.lblLungime.Size = new System.Drawing.Size(47, 13);
            this.lblLungime.TabIndex = 29;
            this.lblLungime.Text = "Lungime";

            this.lblLatime.AutoSize = true;
            this.lblLatime.Location = new System.Drawing.Point(12, 283);
            this.lblLatime.Name = "lblLatime";
            this.lblLatime.Size = new System.Drawing.Size(36, 13);
            this.lblLatime.TabIndex = 30;
            this.lblLatime.Text = "Latime";

            this.lblInaltime.AutoSize = true;
            this.lblInaltime.Location = new System.Drawing.Point(12, 313);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(42, 13);
            this.lblInaltime.TabIndex = 31;
            this.lblInaltime.Text = "Inaltime";

            this.lblDataExpirare.AutoSize = true;
            this.lblDataExpirare.Location = new System.Drawing.Point(350, 43);
            this.lblDataExpirare.Name = "lblDataExpirare";
            this.lblDataExpirare.Size = new System.Drawing.Size(67, 13);
            this.lblDataExpirare.TabIndex = 32;
            this.lblDataExpirare.Text = "Data Expirare";

            this.lblDataAdaugareStoc.AutoSize = true;
            this.lblDataAdaugareStoc.Location = new System.Drawing.Point(350, 73);
            this.lblDataAdaugareStoc.Name = "lblDataAdaugareStoc";
            this.lblDataAdaugareStoc.Size = new System.Drawing.Size(61, 13);
            this.lblDataAdaugareStoc.TabIndex = 33;
            this.lblDataAdaugareStoc.Text = "Data Adăugare";

            this.lblTipOperatie.AutoSize = true;
            this.lblTipOperatie.Location = new System.Drawing.Point(350, 103);
            this.lblTipOperatie.Name = "lblTipOperatie";
            this.lblTipOperatie.Size = new System.Drawing.Size(64, 13);
            this.lblTipOperatie.TabIndex = 36;
            this.lblTipOperatie.Text = "Tip Operatie";

            this.lblCategorieMaterial.AutoSize = true;
            this.lblCategorieMaterial.Location = new System.Drawing.Point(350, 133);
            this.lblCategorieMaterial.Name = "lblCategorieMaterial";
            this.lblCategorieMaterial.Size = new System.Drawing.Size(64, 13);
            this.lblCategorieMaterial.TabIndex = 38;
            this.lblCategorieMaterial.Text = "Categorie Material";

            this.materialControl.Location = new System.Drawing.Point(800, 40);
            this.materialControl.Name = "materialControl";
            this.materialControl.Size = new System.Drawing.Size(300, 350);
            this.materialControl.TabIndex = 34;

            this.ClientSize = new System.Drawing.Size(1200, 600);
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
            this.Controls.Add(this.lblTipOperatie);
            this.Controls.Add(this.lblCategorieMaterial);
            this.Controls.Add(this.cmbTipOperatie);
            this.Controls.Add(this.cmbCategorieMaterial);
            this.Controls.Add(this.dataGridViewMateriale);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCodDeBare);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtFurnizor);
            this.Controls.Add(this.txtLocatieStoc);
            this.Controls.Add(this.txtGreutate);
            this.Controls.Add(this.txtLungime);
            this.Controls.Add(this.txtLatime);
            this.Controls.Add(this.txtInaltime);
            this.Controls.Add(this.dtpDataExpirare);
            this.Controls.Add(this.dtpDataAdaugareStoc);
            this.Controls.Add(this.butonAdauga);
            this.Controls.Add(this.butonActualizeaza);
            this.Controls.Add(this.butonSterge);
            this.Controls.Add(this.butonSalveaza);
            this.Controls.Add(this.butonIncarca);
            this.Controls.Add(this.butonExporta);
            this.Controls.Add(this.butonGenereazaGrafic);
            this.Controls.Add(this.butonVizualizeazaOperatii);
            this.Controls.Add(this.baraDeMeniu);
            this.Controls.Add(this.baraDeInstrumente);
            this.Controls.Add(this.baraDeStare);
            this.Controls.Add(this.materialControl);
            this.MainMenuStrip = this.baraDeMeniu;
            this.Name = "FormMateriale";
            this.Text = "Gestionare Stocuri - Materiale";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStocuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriale)).EndInit();
            this.baraDeMeniu.ResumeLayout(false);
            this.baraDeMeniu.PerformLayout();
            this.baraDeInstrumente.ResumeLayout(false);
            this.baraDeInstrumente.PerformLayout();
            this.baraDeStare.ResumeLayout(false);
            this.baraDeStare.PerformLayout();
            this.meniuContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.butonPrintare = new System.Windows.Forms.Button();
            this.butonPrevizualizarePrintare = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();

            this.butonPrintare.Location = new System.Drawing.Point(650, 280);
            this.butonPrintare.Name = "butonPrintare";
            this.butonPrintare.Size = new System.Drawing.Size(120, 23);
            this.butonPrintare.TabIndex = 38;
            this.butonPrintare.Text = "Tipărește";
            this.butonPrintare.UseVisualStyleBackColor = true;
            this.butonPrintare.Click += new System.EventHandler(this.Printare);
            this.butonPrevizualizarePrintare.Location = new System.Drawing.Point(650, 310);
            this.butonPrevizualizarePrintare.Name = "butonPrevizualizarePrintare";
            this.butonPrevizualizarePrintare.Size = new System.Drawing.Size(120, 23);
            this.butonPrevizualizarePrintare.TabIndex = 39;
            this.butonPrevizualizarePrintare.Text = "Previzualizează";
            this.butonPrevizualizarePrintare.UseVisualStyleBackColor = true;
            this.butonPrevizualizarePrintare.Click += new System.EventHandler(this.PrevizualizarePrintare);

            this.printDialog.Document = this.printDocument;

            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Location = new System.Drawing.Point(29, 29);
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;

            this.Controls.Add(this.butonPrintare);
            this.Controls.Add(this.butonPrevizualizarePrintare);

            this.txtNume.AllowDrop = true;
            this.txtNume.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtNume_DragEnter);
            this.txtNume.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtNume_DragDrop);

            this.dataGridViewMateriale.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMateriale_MouseDown);

            this.butonCopiere = new System.Windows.Forms.Button();
            this.butonLipire = new System.Windows.Forms.Button();
            this.butonCopiere.Location = new System.Drawing.Point(420, 160);
            this.butonCopiere.Name = "butonCopiere";
            this.butonCopiere.Size = new System.Drawing.Size(75, 23);
            this.butonCopiere.TabIndex = 38;
            this.butonCopiere.Text = "Copiază";
            this.butonCopiere.UseVisualStyleBackColor = true;
            this.butonCopiere.Click += new System.EventHandler(this.Copiere);
            this.butonLipire.Location = new System.Drawing.Point(500, 160);
            this.butonLipire.Name = "butonLipire";
            this.butonLipire.Size = new System.Drawing.Size(75, 23);
            this.butonLipire.TabIndex = 39;
            this.butonLipire.Text = "Lipește";
            this.butonLipire.UseVisualStyleBackColor = true;
            this.butonLipire.Click += new System.EventHandler(this.Lipire);

            this.Controls.Add(this.butonCopiere);
            this.Controls.Add(this.butonLipire);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }

        private void MeniuSalveaza(object sender, EventArgs e)
        {
            Salveaza(sender, e);
        }

        private void MeniuIncarca(object sender, EventArgs e)
        {
            Incarca(sender, e);
        }

        private void MeniuExporta(object sender, EventArgs e)
        {
            Exporta(sender, e);
        }

        private void MeniuIesire(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstrumentAdauga(object sender, EventArgs e)
        {
            Adauga(sender, e);
        }

        private void InstrumentActualizeaza(object sender, EventArgs e)
        {
            Actualizeaza(sender, e);
        }

        private void InstrumentSterge(object sender, EventArgs e)
        {
            Sterge(sender, e);
        }

        private void GenerareGrafic(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void VizualizeazaOperatii(object sender, EventArgs e)
        {
            if (dataGridViewMateriale.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMateriale.SelectedRows[0];
                var materialId = (int)selectedRow.Cells["Id"].Value;
                var selectedMaterial = dbContext.Materiale
                    .Include("Operatii") 
                    .FirstOrDefault(m => m.Id == materialId);

                if (selectedMaterial != null)
                {
                    var operatiiForm = new FormOperatii(selectedMaterial.Operatii.ToList());
                    operatiiForm.ShowDialog();
                }
            }
        }
    }
}
