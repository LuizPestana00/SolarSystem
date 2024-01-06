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
            txtSSName = new TextBox();
            txtScien = new TextBox();
            dataGridView2 = new DataGridView();
            btnSatelite = new Button();
            btnDisks = new Button();
            btnComposition = new Button();
            btnAtmosphere = new Button();
            btnCrust = new Button();
            btnCore = new Button();
            lblShow = new Label();
            txtAtmTexture = new TextBox();
            label4 = new Label();
            txtTempVariation = new TextBox();
            label5 = new Label();
            txtRadius = new TextBox();
            txtAtmRadius = new TextBox();
            txtCommon = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAvgTemp = new TextBox();
            label9 = new Label();
            txtDensity = new TextBox();
            txtOrbitalPeriod = new TextBox();
            txtMass = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtPlanetType = new TextBox();
            label13 = new Label();
            txtDayDuration = new TextBox();
            txtCoreType = new TextBox();
            txtGravity = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtDisk = new TextBox();
            label17 = new Label();
            txtDistance = new TextBox();
            txtSatelite = new TextBox();
            txtOrbitAngle = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            txtAxis = new TextBox();
            label22 = new Label();
            txtCoreTexture = new TextBox();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "Planet Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 260);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 1;
            label2.Text = "Orbit Angle:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 43);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 2;
            label3.Text = "Scientific Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 9);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(124, 25);
            txtId.TabIndex = 3;
            // 
            // txtSSName
            // 
            txtSSName.Location = new Point(427, 9);
            txtSSName.Name = "txtSSName";
            txtSSName.ReadOnly = true;
            txtSSName.Size = new Size(127, 25);
            txtSSName.TabIndex = 4;
            // 
            // txtScien
            // 
            txtScien.Location = new Point(127, 40);
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
            dataGridView2.Location = new Point(567, 118);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(774, 226);
            dataGridView2.TabIndex = 21;
            // 
            // btnSatelite
            // 
            btnSatelite.Location = new Point(567, 37);
            btnSatelite.Name = "btnSatelite";
            btnSatelite.Size = new Size(124, 75);
            btnSatelite.TabIndex = 22;
            btnSatelite.Text = "Show Satelites";
            btnSatelite.UseVisualStyleBackColor = true;
            btnSatelite.Click += btnSatelite_Click;
            // 
            // btnDisks
            // 
            btnDisks.Location = new Point(697, 37);
            btnDisks.Name = "btnDisks";
            btnDisks.Size = new Size(124, 75);
            btnDisks.TabIndex = 23;
            btnDisks.Text = "Show Disks";
            btnDisks.UseVisualStyleBackColor = true;
            btnDisks.Click += btnDisks_Click;
            // 
            // btnComposition
            // 
            btnComposition.Location = new Point(827, 37);
            btnComposition.Name = "btnComposition";
            btnComposition.Size = new Size(124, 75);
            btnComposition.TabIndex = 24;
            btnComposition.Text = "Show Planet Composition";
            btnComposition.UseVisualStyleBackColor = true;
            btnComposition.Click += btnComposition_Click;
            // 
            // btnAtmosphere
            // 
            btnAtmosphere.Location = new Point(957, 37);
            btnAtmosphere.Name = "btnAtmosphere";
            btnAtmosphere.Size = new Size(124, 75);
            btnAtmosphere.TabIndex = 25;
            btnAtmosphere.Text = "Show Planet Atmosphere Composition";
            btnAtmosphere.UseVisualStyleBackColor = true;
            btnAtmosphere.Click += btnAtmosphere_Click;
            // 
            // btnCrust
            // 
            btnCrust.Location = new Point(1087, 37);
            btnCrust.Name = "btnCrust";
            btnCrust.Size = new Size(124, 75);
            btnCrust.TabIndex = 26;
            btnCrust.Text = "Show Planet Crust Composition";
            btnCrust.UseVisualStyleBackColor = true;
            btnCrust.Click += btnCrust_Click;
            // 
            // btnCore
            // 
            btnCore.Location = new Point(1217, 37);
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
            lblShow.Location = new Point(567, 9);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(95, 25);
            lblShow.TabIndex = 28;
            lblShow.Text = "Showing:";
            // 
            // txtAtmTexture
            // 
            txtAtmTexture.Location = new Point(427, 40);
            txtAtmTexture.Name = "txtAtmTexture";
            txtAtmTexture.ReadOnly = true;
            txtAtmTexture.Size = new Size(127, 25);
            txtAtmTexture.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 229);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 29;
            label4.Text = "Day Duration:";
            // 
            // txtTempVariation
            // 
            txtTempVariation.Location = new Point(427, 102);
            txtTempVariation.Name = "txtTempVariation";
            txtTempVariation.ReadOnly = true;
            txtTempVariation.Size = new Size(127, 25);
            txtTempVariation.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(271, 167);
            label5.Name = "label5";
            label5.Size = new Size(144, 17);
            label5.TabIndex = 37;
            label5.Text = "Average Temperature:";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(127, 102);
            txtRadius.Name = "txtRadius";
            txtRadius.ReadOnly = true;
            txtRadius.Size = new Size(124, 25);
            txtRadius.TabIndex = 36;
            // 
            // txtAtmRadius
            // 
            txtAtmRadius.Location = new Point(427, 71);
            txtAtmRadius.Name = "txtAtmRadius";
            txtAtmRadius.ReadOnly = true;
            txtAtmRadius.Size = new Size(127, 25);
            txtAtmRadius.TabIndex = 35;
            // 
            // txtCommon
            // 
            txtCommon.Location = new Point(127, 71);
            txtCommon.Name = "txtCommon";
            txtCommon.ReadOnly = true;
            txtCommon.Size = new Size(124, 25);
            txtCommon.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 105);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 33;
            label6.Text = "Planet Radius:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(271, 136);
            label7.Name = "label7";
            label7.Size = new Size(99, 17);
            label7.TabIndex = 32;
            label7.Text = "Orbital Period:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 74);
            label8.Name = "label8";
            label8.Size = new Size(108, 17);
            label8.TabIndex = 31;
            label8.Text = "Common Name:";
            // 
            // txtAvgTemp
            // 
            txtAvgTemp.Location = new Point(427, 164);
            txtAvgTemp.Name = "txtAvgTemp";
            txtAvgTemp.ReadOnly = true;
            txtAvgTemp.Size = new Size(127, 25);
            txtAvgTemp.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(271, 198);
            label9.Name = "label9";
            label9.Size = new Size(73, 17);
            label9.TabIndex = 45;
            label9.Text = "Core Type:";
            // 
            // txtDensity
            // 
            txtDensity.Location = new Point(127, 164);
            txtDensity.Name = "txtDensity";
            txtDensity.ReadOnly = true;
            txtDensity.Size = new Size(124, 25);
            txtDensity.TabIndex = 44;
            // 
            // txtOrbitalPeriod
            // 
            txtOrbitalPeriod.Location = new Point(427, 133);
            txtOrbitalPeriod.Name = "txtOrbitalPeriod";
            txtOrbitalPeriod.ReadOnly = true;
            txtOrbitalPeriod.Size = new Size(127, 25);
            txtOrbitalPeriod.TabIndex = 43;
            // 
            // txtMass
            // 
            txtMass.Location = new Point(127, 133);
            txtMass.Name = "txtMass";
            txtMass.ReadOnly = true;
            txtMass.Size = new Size(124, 25);
            txtMass.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(10, 167);
            label10.Name = "label10";
            label10.Size = new Size(102, 17);
            label10.TabIndex = 41;
            label10.Text = "Planet Density:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(271, 105);
            label11.Name = "label11";
            label11.Size = new Size(150, 17);
            label11.TabIndex = 40;
            label11.Text = "Temperature Variation:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 136);
            label12.Name = "label12";
            label12.Size = new Size(86, 17);
            label12.TabIndex = 39;
            label12.Text = "Planet Mass:";
            // 
            // txtPlanetType
            // 
            txtPlanetType.Location = new Point(427, 226);
            txtPlanetType.Name = "txtPlanetType";
            txtPlanetType.ReadOnly = true;
            txtPlanetType.Size = new Size(127, 25);
            txtPlanetType.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(271, 291);
            label13.Name = "label13";
            label13.Size = new Size(80, 17);
            label13.TabIndex = 53;
            label13.Text = "Disk Count:";
            // 
            // txtDayDuration
            // 
            txtDayDuration.Location = new Point(127, 226);
            txtDayDuration.Name = "txtDayDuration";
            txtDayDuration.ReadOnly = true;
            txtDayDuration.Size = new Size(124, 25);
            txtDayDuration.TabIndex = 52;
            // 
            // txtCoreType
            // 
            txtCoreType.Location = new Point(427, 195);
            txtCoreType.Name = "txtCoreType";
            txtCoreType.ReadOnly = true;
            txtCoreType.Size = new Size(127, 25);
            txtCoreType.TabIndex = 51;
            // 
            // txtGravity
            // 
            txtGravity.Location = new Point(127, 195);
            txtGravity.Name = "txtGravity";
            txtGravity.ReadOnly = true;
            txtGravity.Size = new Size(124, 25);
            txtGravity.TabIndex = 50;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(271, 74);
            label14.Name = "label14";
            label14.Size = new Size(132, 17);
            label14.TabIndex = 49;
            label14.Text = "Atmosphere Radius:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(271, 229);
            label15.Name = "label15";
            label15.Size = new Size(84, 17);
            label15.TabIndex = 48;
            label15.Text = "Planet Type:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(10, 198);
            label16.Name = "label16";
            label16.Size = new Size(99, 17);
            label16.TabIndex = 47;
            label16.Text = "Planet Gravity:";
            // 
            // txtDisk
            // 
            txtDisk.Location = new Point(427, 288);
            txtDisk.Name = "txtDisk";
            txtDisk.ReadOnly = true;
            txtDisk.Size = new Size(127, 25);
            txtDisk.TabIndex = 62;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(272, 12);
            label17.Name = "label17";
            label17.Size = new Size(131, 17);
            label17.TabIndex = 61;
            label17.Text = "Solar System Name:";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(127, 288);
            txtDistance.Name = "txtDistance";
            txtDistance.ReadOnly = true;
            txtDistance.Size = new Size(124, 25);
            txtDistance.TabIndex = 60;
            // 
            // txtSatelite
            // 
            txtSatelite.Location = new Point(427, 257);
            txtSatelite.Name = "txtSatelite";
            txtSatelite.ReadOnly = true;
            txtSatelite.Size = new Size(127, 25);
            txtSatelite.TabIndex = 59;
            // 
            // txtOrbitAngle
            // 
            txtOrbitAngle.Location = new Point(127, 257);
            txtOrbitAngle.Name = "txtOrbitAngle";
            txtOrbitAngle.ReadOnly = true;
            txtOrbitAngle.Size = new Size(124, 25);
            txtOrbitAngle.TabIndex = 58;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(10, 291);
            label18.Name = "label18";
            label18.Size = new Size(111, 17);
            label18.TabIndex = 57;
            label18.Text = "Distance to Star:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(271, 260);
            label19.Name = "label19";
            label19.Size = new Size(99, 17);
            label19.TabIndex = 56;
            label19.Text = "Satelite Count:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(271, 43);
            label20.Name = "label20";
            label20.Size = new Size(137, 17);
            label20.TabIndex = 55;
            label20.Text = "Atmosphere Texture:";
            // 
            // txtAxis
            // 
            txtAxis.Location = new Point(127, 319);
            txtAxis.Name = "txtAxis";
            txtAxis.ReadOnly = true;
            txtAxis.Size = new Size(124, 25);
            txtAxis.TabIndex = 64;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(10, 322);
            label22.Name = "label22";
            label22.Size = new Size(78, 17);
            label22.TabIndex = 63;
            label22.Text = "Axis Angle:";
            // 
            // txtCoreTexture
            // 
            txtCoreTexture.Location = new Point(427, 319);
            txtCoreTexture.Name = "txtCoreTexture";
            txtCoreTexture.ReadOnly = true;
            txtCoreTexture.Size = new Size(127, 25);
            txtCoreTexture.TabIndex = 66;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(271, 322);
            label21.Name = "label21";
            label21.Size = new Size(90, 17);
            label21.TabIndex = 65;
            label21.Text = "Core Texture:";
            // 
            // PlanetDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 356);
            Controls.Add(txtCoreTexture);
            Controls.Add(label21);
            Controls.Add(txtAxis);
            Controls.Add(label22);
            Controls.Add(txtDisk);
            Controls.Add(label17);
            Controls.Add(txtDistance);
            Controls.Add(txtSatelite);
            Controls.Add(txtOrbitAngle);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(txtPlanetType);
            Controls.Add(label13);
            Controls.Add(txtDayDuration);
            Controls.Add(txtCoreType);
            Controls.Add(txtGravity);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(txtAvgTemp);
            Controls.Add(label9);
            Controls.Add(txtDensity);
            Controls.Add(txtOrbitalPeriod);
            Controls.Add(txtMass);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtTempVariation);
            Controls.Add(label5);
            Controls.Add(txtRadius);
            Controls.Add(txtAtmRadius);
            Controls.Add(txtCommon);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtAtmTexture);
            Controls.Add(label4);
            Controls.Add(lblShow);
            Controls.Add(btnCore);
            Controls.Add(btnCrust);
            Controls.Add(btnAtmosphere);
            Controls.Add(btnComposition);
            Controls.Add(btnDisks);
            Controls.Add(btnSatelite);
            Controls.Add(dataGridView2);
            Controls.Add(txtScien);
            Controls.Add(txtSSName);
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
        private TextBox txtSSName;
        private TextBox txtScien;
        private DataGridView dataGridView2;
        private Button btnSatelite;
        private Button btnDisks;
        private Button btnComposition;
        private Button btnAtmosphere;
        private Button btnCrust;
        private Button btnCore;
        private Label lblShow;
        private TextBox txtAtmTexture;
        private Label label4;
        private TextBox txtTempVariation;
        private Label label5;
        private TextBox txtRadius;
        private TextBox txtAtmRadius;
        private TextBox txtCommon;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAvgTemp;
        private Label label9;
        private TextBox txtDensity;
        private TextBox txtOrbitalPeriod;
        private TextBox txtMass;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtPlanetType;
        private Label label13;
        private TextBox txtDayDuration;
        private TextBox txtCoreType;
        private TextBox txtGravity;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtDisk;
        private Label label17;
        private TextBox txtDistance;
        private TextBox txtSatelite;
        private TextBox txtOrbitAngle;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox txtAxis;
        private Label label22;
        private TextBox txtCoreTexture;
        private Label label21;
    }
}