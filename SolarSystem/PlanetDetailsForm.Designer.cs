namespace SolarSystem
{
    partial class PlanetDetailsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtCommon = new TextBox();
            txtScien = new TextBox();
            dataGridView2 = new DataGridView();
            btnSatelite = new Button();
            btnDisks = new Button();
            btnComposition = new Button();
            btnAtmosphere = new Button();
            btnCrust = new Button();
            btnCore = new Button();
            lblShow = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "Planet Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(262, 9);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 1;
            label2.Text = "Common Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(547, 9);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 2;
            label3.Text = "Scientific Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(127, 25);
            txtId.TabIndex = 3;
            // 
            // txtCommon
            // 
            txtCommon.Location = new Point(376, 6);
            txtCommon.Name = "txtCommon";
            txtCommon.ReadOnly = true;
            txtCommon.Size = new Size(127, 25);
            txtCommon.TabIndex = 4;
            // 
            // txtScien
            // 
            txtScien.Location = new Point(661, 6);
            txtScien.Name = "txtScien";
            txtScien.ReadOnly = true;
            txtScien.Size = new Size(124, 25);
            txtScien.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 173);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(772, 221);
            dataGridView2.TabIndex = 21;
            // 
            // btnSatelite
            // 
            btnSatelite.Location = new Point(12, 37);
            btnSatelite.Name = "btnSatelite";
            btnSatelite.Size = new Size(124, 75);
            btnSatelite.TabIndex = 22;
            btnSatelite.Text = "Show Satelites";
            btnSatelite.UseVisualStyleBackColor = true;
            btnSatelite.Click += btnSatelite_Click;
            // 
            // btnDisks
            // 
            btnDisks.Location = new Point(142, 37);
            btnDisks.Name = "btnDisks";
            btnDisks.Size = new Size(124, 75);
            btnDisks.TabIndex = 23;
            btnDisks.Text = "Show Disks";
            btnDisks.UseVisualStyleBackColor = true;
            btnDisks.Click += btnDisks_Click;
            // 
            // btnComposition
            // 
            btnComposition.Location = new Point(272, 37);
            btnComposition.Name = "btnComposition";
            btnComposition.Size = new Size(124, 75);
            btnComposition.TabIndex = 24;
            btnComposition.Text = "Show Planet Composition";
            btnComposition.UseVisualStyleBackColor = true;
            btnComposition.Click += btnComposition_Click;
            // 
            // btnAtmosphere
            // 
            btnAtmosphere.Location = new Point(402, 37);
            btnAtmosphere.Name = "btnAtmosphere";
            btnAtmosphere.Size = new Size(124, 75);
            btnAtmosphere.TabIndex = 25;
            btnAtmosphere.Text = "Show Planet Atmosphere Composition";
            btnAtmosphere.UseVisualStyleBackColor = true;
            btnAtmosphere.Click += btnAtmosphere_Click;
            // 
            // btnCrust
            // 
            btnCrust.Location = new Point(532, 37);
            btnCrust.Name = "btnCrust";
            btnCrust.Size = new Size(124, 75);
            btnCrust.TabIndex = 26;
            btnCrust.Text = "Show Planet Crust Composition";
            btnCrust.UseVisualStyleBackColor = true;
            btnCrust.Click += btnCrust_Click;
            // 
            // btnCore
            // 
            btnCore.Location = new Point(661, 37);
            btnCore.Name = "btnCore";
            btnCore.Size = new Size(124, 75);
            btnCore.TabIndex = 27;
            btnCore.Text = "Show Planet Core Composition";
            btnCore.UseVisualStyleBackColor = true;
            btnCore.Click += btnCore_Click;
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblShow.Location = new Point(12, 129);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(95, 25);
            lblShow.TabIndex = 28;
            lblShow.Text = "Showing:";
            // 
            // PlanetDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 406);
            Controls.Add(lblShow);
            Controls.Add(btnCore);
            Controls.Add(btnCrust);
            Controls.Add(btnAtmosphere);
            Controls.Add(btnComposition);
            Controls.Add(btnDisks);
            Controls.Add(btnSatelite);
            Controls.Add(dataGridView2);
            Controls.Add(txtScien);
            Controls.Add(txtCommon);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PlanetDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlanetDetailsForm";
            Load += PlanetDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtCommon;
        private TextBox txtScien;
        private DataGridView dataGridView2;
        private Button btnSatelite;
        private Button btnDisks;
        private Button btnComposition;
        private Button btnAtmosphere;
        private Button btnCrust;
        private Button btnCore;
        private Label lblShow;
    }
}