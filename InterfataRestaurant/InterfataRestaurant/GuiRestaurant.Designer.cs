
namespace InterfataRestaurant
{
    partial class GUIRestaurant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIRestaurant));
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.textBoxAdresaClient = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.buttonHelpClient = new System.Windows.Forms.Button();
            this.bonClient = new System.Windows.Forms.ListBox();
            this.stergeProdusClient = new System.Windows.Forms.Button();
            this.observatiiClient = new System.Windows.Forms.TextBox();
            this.observatiiLabelClient = new System.Windows.Forms.Label();
            this.labelTotalClient = new System.Windows.Forms.Label();
            this.textTotalClient = new System.Windows.Forms.TextBox();
            this.trimiteComandaClient = new System.Windows.Forms.Button();
            this.adaugaMancareClient = new System.Windows.Forms.Button();
            this.labelBonClient = new System.Windows.Forms.Label();
            this.labelMancareClient = new System.Windows.Forms.Label();
            this.mancareClient = new System.Windows.Forms.ComboBox();
            this.groupChelner = new System.Windows.Forms.GroupBox();
            this.buttonHelpChelner = new System.Windows.Forms.Button();
            this.inchideCasa = new System.Windows.Forms.Button();
            this.labelComenzi = new System.Windows.Forms.Label();
            this.observatiiLabelChelner = new System.Windows.Forms.Label();
            this.observatiiChelner = new System.Windows.Forms.TextBox();
            this.emiteBon = new System.Windows.Forms.Button();
            this.labelComandaChelner = new System.Windows.Forms.Label();
            this.detaliiComandaChelner = new System.Windows.Forms.TextBox();
            this.listaComenziChelner = new System.Windows.Forms.ListBox();
            this.groupClient.SuspendLayout();
            this.groupChelner.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClient
            // 
            this.groupClient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupClient.Controls.Add(this.textBoxAdresaClient);
            this.groupClient.Controls.Add(this.labelAdresa);
            this.groupClient.Controls.Add(this.radioButtonDelivery);
            this.groupClient.Controls.Add(this.buttonHelpClient);
            this.groupClient.Controls.Add(this.bonClient);
            this.groupClient.Controls.Add(this.stergeProdusClient);
            this.groupClient.Controls.Add(this.observatiiClient);
            this.groupClient.Controls.Add(this.observatiiLabelClient);
            this.groupClient.Controls.Add(this.labelTotalClient);
            this.groupClient.Controls.Add(this.textTotalClient);
            this.groupClient.Controls.Add(this.trimiteComandaClient);
            this.groupClient.Controls.Add(this.adaugaMancareClient);
            this.groupClient.Controls.Add(this.labelBonClient);
            this.groupClient.Controls.Add(this.labelMancareClient);
            this.groupClient.Controls.Add(this.mancareClient);
            this.groupClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupClient.ForeColor = System.Drawing.Color.DimGray;
            this.groupClient.Location = new System.Drawing.Point(16, 15);
            this.groupClient.Margin = new System.Windows.Forms.Padding(4);
            this.groupClient.Name = "groupClient";
            this.groupClient.Padding = new System.Windows.Forms.Padding(4);
            this.groupClient.Size = new System.Drawing.Size(1327, 309);
            this.groupClient.TabIndex = 0;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Client";
            // 
            // textBoxAdresaClient
            // 
            this.textBoxAdresaClient.Enabled = false;
            this.textBoxAdresaClient.Location = new System.Drawing.Point(85, 237);
            this.textBoxAdresaClient.Multiline = true;
            this.textBoxAdresaClient.Name = "textBoxAdresaClient";
            this.textBoxAdresaClient.Size = new System.Drawing.Size(543, 60);
            this.textBoxAdresaClient.TabIndex = 25;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelAdresa.Location = new System.Drawing.Point(7, 231);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(72, 30);
            this.labelAdresa.TabIndex = 24;
            this.labelAdresa.Text = "Adresa";
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonDelivery.Location = new System.Drawing.Point(7, 189);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(232, 39);
            this.radioButtonDelivery.TabIndex = 22;
            this.radioButtonDelivery.TabStop = true;
            this.radioButtonDelivery.Text = "Livrare la domiciliu";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            this.radioButtonDelivery.Click += new System.EventHandler(this.radioButtonDelivery_Click);
            // 
            // buttonHelpClient
            // 
            this.buttonHelpClient.BackColor = System.Drawing.Color.Teal;
            this.buttonHelpClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelpClient.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelpClient.ForeColor = System.Drawing.Color.White;
            this.buttonHelpClient.Location = new System.Drawing.Point(636, 203);
            this.buttonHelpClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelpClient.Name = "buttonHelpClient";
            this.buttonHelpClient.Size = new System.Drawing.Size(101, 41);
            this.buttonHelpClient.TabIndex = 21;
            this.buttonHelpClient.Text = "Help";
            this.buttonHelpClient.UseVisualStyleBackColor = false;
            this.buttonHelpClient.Click += new System.EventHandler(this.buttonHelpClient_Click);
            // 
            // bonClient
            // 
            this.bonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonClient.FormattingEnabled = true;
            this.bonClient.ItemHeight = 20;
            this.bonClient.Location = new System.Drawing.Point(744, 60);
            this.bonClient.Name = "bonClient";
            this.bonClient.Size = new System.Drawing.Size(563, 184);
            this.bonClient.TabIndex = 20;
            // 
            // stergeProdusClient
            // 
            this.stergeProdusClient.BackColor = System.Drawing.Color.Teal;
            this.stergeProdusClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stergeProdusClient.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeProdusClient.ForeColor = System.Drawing.Color.White;
            this.stergeProdusClient.Location = new System.Drawing.Point(925, 251);
            this.stergeProdusClient.Margin = new System.Windows.Forms.Padding(4);
            this.stergeProdusClient.Name = "stergeProdusClient";
            this.stergeProdusClient.Size = new System.Drawing.Size(186, 44);
            this.stergeProdusClient.TabIndex = 19;
            this.stergeProdusClient.Text = "Șterge Produs";
            this.stergeProdusClient.UseVisualStyleBackColor = false;
            this.stergeProdusClient.Click += new System.EventHandler(this.stergeProdusClient_Click);
            // 
            // observatiiClient
            // 
            this.observatiiClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observatiiClient.Location = new System.Drawing.Point(8, 132);
            this.observatiiClient.Margin = new System.Windows.Forms.Padding(4);
            this.observatiiClient.Multiline = true;
            this.observatiiClient.Name = "observatiiClient";
            this.observatiiClient.Size = new System.Drawing.Size(620, 50);
            this.observatiiClient.TabIndex = 12;
            // 
            // observatiiLabelClient
            // 
            this.observatiiLabelClient.AutoSize = true;
            this.observatiiLabelClient.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observatiiLabelClient.ForeColor = System.Drawing.Color.DimGray;
            this.observatiiLabelClient.Location = new System.Drawing.Point(8, 93);
            this.observatiiLabelClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observatiiLabelClient.Name = "observatiiLabelClient";
            this.observatiiLabelClient.Size = new System.Drawing.Size(115, 35);
            this.observatiiLabelClient.TabIndex = 11;
            this.observatiiLabelClient.Text = "Observații";
            // 
            // labelTotalClient
            // 
            this.labelTotalClient.AutoSize = true;
            this.labelTotalClient.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalClient.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalClient.Location = new System.Drawing.Point(743, 258);
            this.labelTotalClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalClient.Name = "labelTotalClient";
            this.labelTotalClient.Size = new System.Drawing.Size(57, 30);
            this.labelTotalClient.TabIndex = 10;
            this.labelTotalClient.Text = "Total";
            // 
            // textTotalClient
            // 
            this.textTotalClient.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalClient.Location = new System.Drawing.Point(808, 262);
            this.textTotalClient.Margin = new System.Windows.Forms.Padding(4);
            this.textTotalClient.Name = "textTotalClient";
            this.textTotalClient.Size = new System.Drawing.Size(92, 30);
            this.textTotalClient.TabIndex = 9;
            // 
            // trimiteComandaClient
            // 
            this.trimiteComandaClient.BackColor = System.Drawing.Color.Teal;
            this.trimiteComandaClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trimiteComandaClient.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trimiteComandaClient.ForeColor = System.Drawing.Color.White;
            this.trimiteComandaClient.Location = new System.Drawing.Point(1119, 251);
            this.trimiteComandaClient.Margin = new System.Windows.Forms.Padding(4);
            this.trimiteComandaClient.Name = "trimiteComandaClient";
            this.trimiteComandaClient.Size = new System.Drawing.Size(188, 44);
            this.trimiteComandaClient.TabIndex = 8;
            this.trimiteComandaClient.Text = "Trimite comanda";
            this.trimiteComandaClient.UseVisualStyleBackColor = false;
            this.trimiteComandaClient.Click += new System.EventHandler(this.trimiteComandaClient_Click);
            // 
            // adaugaMancareClient
            // 
            this.adaugaMancareClient.BackColor = System.Drawing.Color.Teal;
            this.adaugaMancareClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adaugaMancareClient.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaMancareClient.ForeColor = System.Drawing.Color.White;
            this.adaugaMancareClient.Location = new System.Drawing.Point(636, 102);
            this.adaugaMancareClient.Margin = new System.Windows.Forms.Padding(4);
            this.adaugaMancareClient.Name = "adaugaMancareClient";
            this.adaugaMancareClient.Size = new System.Drawing.Size(96, 80);
            this.adaugaMancareClient.TabIndex = 6;
            this.adaugaMancareClient.Text = "Adaugă";
            this.adaugaMancareClient.UseVisualStyleBackColor = false;
            this.adaugaMancareClient.Click += new System.EventHandler(this.adaugaMancareClient_Click);
            // 
            // labelBonClient
            // 
            this.labelBonClient.AutoSize = true;
            this.labelBonClient.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBonClient.ForeColor = System.Drawing.Color.DimGray;
            this.labelBonClient.Location = new System.Drawing.Point(992, 19);
            this.labelBonClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBonClient.Name = "labelBonClient";
            this.labelBonClient.Size = new System.Drawing.Size(54, 35);
            this.labelBonClient.TabIndex = 5;
            this.labelBonClient.Text = "Bon";
            // 
            // labelMancareClient
            // 
            this.labelMancareClient.AutoSize = true;
            this.labelMancareClient.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMancareClient.ForeColor = System.Drawing.Color.DimGray;
            this.labelMancareClient.Location = new System.Drawing.Point(22, 19);
            this.labelMancareClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMancareClient.Name = "labelMancareClient";
            this.labelMancareClient.Size = new System.Drawing.Size(101, 35);
            this.labelMancareClient.TabIndex = 1;
            this.labelMancareClient.Text = "Mâncare";
            // 
            // mancareClient
            // 
            this.mancareClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mancareClient.FormattingEnabled = true;
            this.mancareClient.Items.AddRange(new object[] {
            "Meniu Crispy ( cartofi, salata, sos ) - 400g - 30 de lei",
            "Meniu Porc ( ceafa porc, salata, cartofi ) - 450g - 35 lei"});
            this.mancareClient.Location = new System.Drawing.Point(13, 61);
            this.mancareClient.Margin = new System.Windows.Forms.Padding(4);
            this.mancareClient.Name = "mancareClient";
            this.mancareClient.Size = new System.Drawing.Size(724, 28);
            this.mancareClient.TabIndex = 0;
            // 
            // groupChelner
            // 
            this.groupChelner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupChelner.Controls.Add(this.buttonHelpChelner);
            this.groupChelner.Controls.Add(this.inchideCasa);
            this.groupChelner.Controls.Add(this.labelComenzi);
            this.groupChelner.Controls.Add(this.observatiiLabelChelner);
            this.groupChelner.Controls.Add(this.observatiiChelner);
            this.groupChelner.Controls.Add(this.emiteBon);
            this.groupChelner.Controls.Add(this.labelComandaChelner);
            this.groupChelner.Controls.Add(this.detaliiComandaChelner);
            this.groupChelner.Controls.Add(this.listaComenziChelner);
            this.groupChelner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupChelner.ForeColor = System.Drawing.Color.White;
            this.groupChelner.Location = new System.Drawing.Point(16, 331);
            this.groupChelner.Margin = new System.Windows.Forms.Padding(4);
            this.groupChelner.Name = "groupChelner";
            this.groupChelner.Padding = new System.Windows.Forms.Padding(4);
            this.groupChelner.Size = new System.Drawing.Size(1327, 682);
            this.groupChelner.TabIndex = 1;
            this.groupChelner.TabStop = false;
            this.groupChelner.Text = "Chelner";
            // 
            // buttonHelpChelner
            // 
            this.buttonHelpChelner.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonHelpChelner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelpChelner.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelpChelner.ForeColor = System.Drawing.Color.Teal;
            this.buttonHelpChelner.Location = new System.Drawing.Point(1043, 315);
            this.buttonHelpChelner.Name = "buttonHelpChelner";
            this.buttonHelpChelner.Size = new System.Drawing.Size(216, 85);
            this.buttonHelpChelner.TabIndex = 19;
            this.buttonHelpChelner.Text = "Help";
            this.buttonHelpChelner.UseVisualStyleBackColor = false;
            this.buttonHelpChelner.Click += new System.EventHandler(this.buttonHelpChelner_Click);
            // 
            // inchideCasa
            // 
            this.inchideCasa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.inchideCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inchideCasa.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchideCasa.ForeColor = System.Drawing.Color.Teal;
            this.inchideCasa.Location = new System.Drawing.Point(1043, 197);
            this.inchideCasa.Name = "inchideCasa";
            this.inchideCasa.Size = new System.Drawing.Size(216, 85);
            this.inchideCasa.TabIndex = 18;
            this.inchideCasa.Text = "Închide casa";
            this.inchideCasa.UseVisualStyleBackColor = false;
            this.inchideCasa.Click += new System.EventHandler(this.inchideCasa_Click);
            // 
            // labelComenzi
            // 
            this.labelComenzi.AutoSize = true;
            this.labelComenzi.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComenzi.Location = new System.Drawing.Point(81, 43);
            this.labelComenzi.Name = "labelComenzi";
            this.labelComenzi.Size = new System.Drawing.Size(99, 35);
            this.labelComenzi.TabIndex = 17;
            this.labelComenzi.Text = "Comenzi";
            // 
            // observatiiLabelChelner
            // 
            this.observatiiLabelChelner.AutoSize = true;
            this.observatiiLabelChelner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.observatiiLabelChelner.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observatiiLabelChelner.Location = new System.Drawing.Point(790, 43);
            this.observatiiLabelChelner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observatiiLabelChelner.Name = "observatiiLabelChelner";
            this.observatiiLabelChelner.Size = new System.Drawing.Size(214, 35);
            this.observatiiLabelChelner.TabIndex = 16;
            this.observatiiLabelChelner.Text = "Observații comandă";
            // 
            // observatiiChelner
            // 
            this.observatiiChelner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observatiiChelner.ForeColor = System.Drawing.Color.Red;
            this.observatiiChelner.Location = new System.Drawing.Point(775, 81);
            this.observatiiChelner.Margin = new System.Windows.Forms.Padding(4);
            this.observatiiChelner.Multiline = true;
            this.observatiiChelner.Name = "observatiiChelner";
            this.observatiiChelner.Size = new System.Drawing.Size(229, 342);
            this.observatiiChelner.TabIndex = 15;
            // 
            // emiteBon
            // 
            this.emiteBon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.emiteBon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emiteBon.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emiteBon.ForeColor = System.Drawing.Color.Teal;
            this.emiteBon.Location = new System.Drawing.Point(1043, 81);
            this.emiteBon.Margin = new System.Windows.Forms.Padding(4);
            this.emiteBon.Name = "emiteBon";
            this.emiteBon.Size = new System.Drawing.Size(216, 83);
            this.emiteBon.TabIndex = 11;
            this.emiteBon.Text = "Emite bon";
            this.emiteBon.UseVisualStyleBackColor = false;
            this.emiteBon.Click += new System.EventHandler(this.emiteBon_Click);
            // 
            // labelComandaChelner
            // 
            this.labelComandaChelner.AutoSize = true;
            this.labelComandaChelner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelComandaChelner.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComandaChelner.Location = new System.Drawing.Point(464, 43);
            this.labelComandaChelner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComandaChelner.Name = "labelComandaChelner";
            this.labelComandaChelner.Size = new System.Drawing.Size(179, 35);
            this.labelComandaChelner.TabIndex = 11;
            this.labelComandaChelner.Text = "Detalii comandă";
            // 
            // detaliiComandaChelner
            // 
            this.detaliiComandaChelner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaliiComandaChelner.Location = new System.Drawing.Point(264, 81);
            this.detaliiComandaChelner.Margin = new System.Windows.Forms.Padding(4);
            this.detaliiComandaChelner.Multiline = true;
            this.detaliiComandaChelner.Name = "detaliiComandaChelner";
            this.detaliiComandaChelner.Size = new System.Drawing.Size(503, 342);
            this.detaliiComandaChelner.TabIndex = 11;
            // 
            // listaComenziChelner
            // 
            this.listaComenziChelner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaComenziChelner.ForeColor = System.Drawing.Color.Black;
            this.listaComenziChelner.FormattingEnabled = true;
            this.listaComenziChelner.ItemHeight = 26;
            this.listaComenziChelner.Location = new System.Drawing.Point(7, 81);
            this.listaComenziChelner.Margin = new System.Windows.Forms.Padding(4);
            this.listaComenziChelner.Name = "listaComenziChelner";
            this.listaComenziChelner.Size = new System.Drawing.Size(249, 342);
            this.listaComenziChelner.TabIndex = 0;
            this.listaComenziChelner.SelectedIndexChanged += new System.EventHandler(this.listaComenziChelner_SelectedIndexChanged);
            // 
            // GUIRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1335, 820);
            this.Controls.Add(this.groupChelner);
            this.Controls.Add(this.groupClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUIRestaurant";
            this.Text = "Restaurant";
            this.groupClient.ResumeLayout(false);
            this.groupClient.PerformLayout();
            this.groupChelner.ResumeLayout(false);
            this.groupChelner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClient;
        private System.Windows.Forms.Label labelMancareClient;
        private System.Windows.Forms.ComboBox mancareClient;
        private System.Windows.Forms.GroupBox groupChelner;
        private System.Windows.Forms.Label labelBonClient;
        private System.Windows.Forms.Button trimiteComandaClient;
        private System.Windows.Forms.Button adaugaMancareClient;
        private System.Windows.Forms.Label labelTotalClient;
        private System.Windows.Forms.TextBox textTotalClient;
        private System.Windows.Forms.ListBox listaComenziChelner;
        private System.Windows.Forms.Button emiteBon;
        private System.Windows.Forms.Label labelComandaChelner;
        private System.Windows.Forms.TextBox detaliiComandaChelner;
        private System.Windows.Forms.TextBox observatiiClient;
        private System.Windows.Forms.Label observatiiLabelClient;
        private System.Windows.Forms.Label observatiiLabelChelner;
        private System.Windows.Forms.TextBox observatiiChelner;
        private System.Windows.Forms.Button stergeProdusClient;
        private System.Windows.Forms.ListBox bonClient;
        private System.Windows.Forms.Label labelComenzi;
        private System.Windows.Forms.Button inchideCasa;
        private System.Windows.Forms.Button buttonHelpClient;
        private System.Windows.Forms.Button buttonHelpChelner;
        private System.Windows.Forms.TextBox textBoxAdresaClient;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
    }
}

