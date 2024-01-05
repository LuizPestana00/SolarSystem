namespace SolarSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            label4 = new Label();
            txtZ = new TextBox();
            label5 = new Label();
            txtAmplitude = new TextBox();
            label6 = new Label();
            txtRange = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            btnClean = new Button();
            btnFind = new Button();
            gbS2 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label2 = new Label();
            txtS2Crown = new TextBox();
            txtS2Texture = new TextBox();
            txtS2Color = new TextBox();
            txtS2Radius = new TextBox();
            txtS2Brightness = new TextBox();
            txtS2ST = new TextBox();
            txtS2Mass = new TextBox();
            txtS2Type = new TextBox();
            gbS1 = new GroupBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            txtS1Crown = new TextBox();
            txtS1Texture = new TextBox();
            txtS1Color = new TextBox();
            txtS1Radius = new TextBox();
            txtS1Brightness = new TextBox();
            txtS1ST = new TextBox();
            txtS1Mass = new TextBox();
            txtS1Type = new TextBox();
            label25 = new Label();
            dataGridView2 = new DataGridView();
            btnShowDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbS2.SuspendLayout();
            gbS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Find Solar Systems";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 61);
            label3.Name = "label3";
            label3.Size = new Size(19, 17);
            label3.TabIndex = 3;
            label3.Text = "X:";
            // 
            // txtX
            // 
            txtX.Location = new Point(44, 57);
            txtX.Name = "txtX";
            txtX.Size = new Size(140, 25);
            txtX.TabIndex = 1;
            // 
            // txtY
            // 
            txtY.Location = new Point(214, 57);
            txtY.Name = "txtY";
            txtY.Size = new Size(140, 25);
            txtY.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 61);
            label4.Name = "label4";
            label4.Size = new Size(18, 17);
            label4.TabIndex = 5;
            label4.Text = "Y:";
            // 
            // txtZ
            // 
            txtZ.Location = new Point(384, 57);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(140, 25);
            txtZ.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 61);
            label5.Name = "label5";
            label5.Size = new Size(18, 17);
            label5.TabIndex = 7;
            label5.Text = "Z:";
            // 
            // txtAmplitude
            // 
            txtAmplitude.Location = new Point(606, 57);
            txtAmplitude.Name = "txtAmplitude";
            txtAmplitude.Size = new Size(140, 25);
            txtAmplitude.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 61);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 9;
            label6.Text = "Amplitude:";
            // 
            // txtRange
            // 
            txtRange.Location = new Point(806, 57);
            txtRange.Name = "txtRange";
            txtRange.Size = new Size(150, 25);
            txtRange.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(752, 61);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 12;
            label7.Text = "Range:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(944, 287);
            dataGridView1.TabIndex = 14;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(1163, 57);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(189, 25);
            btnClean.TabIndex = 7;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(962, 57);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(195, 25);
            btnFind.TabIndex = 6;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // gbS2
            // 
            gbS2.Controls.Add(label15);
            gbS2.Controls.Add(label14);
            gbS2.Controls.Add(label13);
            gbS2.Controls.Add(label12);
            gbS2.Controls.Add(label11);
            gbS2.Controls.Add(label10);
            gbS2.Controls.Add(label9);
            gbS2.Controls.Add(label8);
            gbS2.Controls.Add(label2);
            gbS2.Controls.Add(txtS2Crown);
            gbS2.Controls.Add(txtS2Texture);
            gbS2.Controls.Add(txtS2Color);
            gbS2.Controls.Add(txtS2Radius);
            gbS2.Controls.Add(txtS2Brightness);
            gbS2.Controls.Add(txtS2ST);
            gbS2.Controls.Add(txtS2Mass);
            gbS2.Controls.Add(txtS2Type);
            gbS2.Location = new Point(1163, 96);
            gbS2.Name = "gbS2";
            gbS2.Size = new Size(195, 287);
            gbS2.TabIndex = 17;
            gbS2.TabStop = false;
            gbS2.Text = "Estrela 2";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 256);
            label15.Name = "label15";
            label15.Size = new Size(48, 17);
            label15.TabIndex = 16;
            label15.Text = "Crown:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 225);
            label14.Name = "label14";
            label14.Size = new Size(53, 17);
            label14.TabIndex = 15;
            label14.Text = "Texture:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 194);
            label13.Name = "label13";
            label13.Size = new Size(43, 17);
            label13.TabIndex = 14;
            label13.Text = "Color:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 163);
            label12.Name = "label12";
            label12.Size = new Size(50, 17);
            label12.TabIndex = 13;
            label12.Text = "Radius:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 132);
            label11.Name = "label11";
            label11.Size = new Size(71, 17);
            label11.TabIndex = 12;
            label11.Text = "Brightness:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 101);
            label10.Name = "label10";
            label10.Size = new Size(82, 17);
            label10.TabIndex = 11;
            label10.Text = "Temperature";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 84);
            label9.Name = "label9";
            label9.Size = new Size(51, 17);
            label9.TabIndex = 10;
            label9.Text = "Surface";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 53);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 9;
            label8.Text = "Mass:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 8;
            label2.Text = "Type:";
            // 
            // txtS2Crown
            // 
            txtS2Crown.Location = new Point(92, 253);
            txtS2Crown.Name = "txtS2Crown";
            txtS2Crown.ReadOnly = true;
            txtS2Crown.Size = new Size(97, 25);
            txtS2Crown.TabIndex = 7;
            // 
            // txtS2Texture
            // 
            txtS2Texture.Location = new Point(92, 222);
            txtS2Texture.Name = "txtS2Texture";
            txtS2Texture.ReadOnly = true;
            txtS2Texture.Size = new Size(97, 25);
            txtS2Texture.TabIndex = 6;
            // 
            // txtS2Color
            // 
            txtS2Color.Location = new Point(92, 191);
            txtS2Color.Name = "txtS2Color";
            txtS2Color.ReadOnly = true;
            txtS2Color.Size = new Size(97, 25);
            txtS2Color.TabIndex = 5;
            // 
            // txtS2Radius
            // 
            txtS2Radius.Location = new Point(92, 160);
            txtS2Radius.Name = "txtS2Radius";
            txtS2Radius.ReadOnly = true;
            txtS2Radius.Size = new Size(97, 25);
            txtS2Radius.TabIndex = 4;
            // 
            // txtS2Brightness
            // 
            txtS2Brightness.Location = new Point(92, 129);
            txtS2Brightness.Name = "txtS2Brightness";
            txtS2Brightness.ReadOnly = true;
            txtS2Brightness.Size = new Size(97, 25);
            txtS2Brightness.TabIndex = 3;
            // 
            // txtS2ST
            // 
            txtS2ST.Location = new Point(92, 88);
            txtS2ST.Name = "txtS2ST";
            txtS2ST.ReadOnly = true;
            txtS2ST.Size = new Size(97, 25);
            txtS2ST.TabIndex = 2;
            // 
            // txtS2Mass
            // 
            txtS2Mass.Location = new Point(92, 50);
            txtS2Mass.Name = "txtS2Mass";
            txtS2Mass.ReadOnly = true;
            txtS2Mass.Size = new Size(97, 25);
            txtS2Mass.TabIndex = 1;
            // 
            // txtS2Type
            // 
            txtS2Type.Location = new Point(92, 19);
            txtS2Type.Name = "txtS2Type";
            txtS2Type.ReadOnly = true;
            txtS2Type.Size = new Size(97, 25);
            txtS2Type.TabIndex = 0;
            // 
            // gbS1
            // 
            gbS1.Controls.Add(label16);
            gbS1.Controls.Add(label17);
            gbS1.Controls.Add(label18);
            gbS1.Controls.Add(label19);
            gbS1.Controls.Add(label20);
            gbS1.Controls.Add(label21);
            gbS1.Controls.Add(label22);
            gbS1.Controls.Add(label23);
            gbS1.Controls.Add(label24);
            gbS1.Controls.Add(txtS1Crown);
            gbS1.Controls.Add(txtS1Texture);
            gbS1.Controls.Add(txtS1Color);
            gbS1.Controls.Add(txtS1Radius);
            gbS1.Controls.Add(txtS1Brightness);
            gbS1.Controls.Add(txtS1ST);
            gbS1.Controls.Add(txtS1Mass);
            gbS1.Controls.Add(txtS1Type);
            gbS1.Location = new Point(962, 96);
            gbS1.Name = "gbS1";
            gbS1.Size = new Size(195, 287);
            gbS1.TabIndex = 18;
            gbS1.TabStop = false;
            gbS1.Text = "Estrela 1";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 256);
            label16.Name = "label16";
            label16.Size = new Size(48, 17);
            label16.TabIndex = 16;
            label16.Text = "Crown:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 225);
            label17.Name = "label17";
            label17.Size = new Size(53, 17);
            label17.TabIndex = 15;
            label17.Text = "Texture:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 194);
            label18.Name = "label18";
            label18.Size = new Size(43, 17);
            label18.TabIndex = 14;
            label18.Text = "Color:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 163);
            label19.Name = "label19";
            label19.Size = new Size(50, 17);
            label19.TabIndex = 13;
            label19.Text = "Radius:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 132);
            label20.Name = "label20";
            label20.Size = new Size(71, 17);
            label20.TabIndex = 12;
            label20.Text = "Brightness:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 101);
            label21.Name = "label21";
            label21.Size = new Size(82, 17);
            label21.TabIndex = 11;
            label21.Text = "Temperature";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 84);
            label22.Name = "label22";
            label22.Size = new Size(51, 17);
            label22.TabIndex = 10;
            label22.Text = "Surface";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 53);
            label23.Name = "label23";
            label23.Size = new Size(42, 17);
            label23.TabIndex = 9;
            label23.Text = "Mass:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 22);
            label24.Name = "label24";
            label24.Size = new Size(38, 17);
            label24.TabIndex = 8;
            label24.Text = "Type:";
            // 
            // txtS1Crown
            // 
            txtS1Crown.Location = new Point(92, 253);
            txtS1Crown.Name = "txtS1Crown";
            txtS1Crown.ReadOnly = true;
            txtS1Crown.Size = new Size(97, 25);
            txtS1Crown.TabIndex = 7;
            // 
            // txtS1Texture
            // 
            txtS1Texture.Location = new Point(92, 222);
            txtS1Texture.Name = "txtS1Texture";
            txtS1Texture.ReadOnly = true;
            txtS1Texture.Size = new Size(97, 25);
            txtS1Texture.TabIndex = 6;
            // 
            // txtS1Color
            // 
            txtS1Color.Location = new Point(92, 191);
            txtS1Color.Name = "txtS1Color";
            txtS1Color.ReadOnly = true;
            txtS1Color.Size = new Size(97, 25);
            txtS1Color.TabIndex = 5;
            // 
            // txtS1Radius
            // 
            txtS1Radius.Location = new Point(92, 160);
            txtS1Radius.Name = "txtS1Radius";
            txtS1Radius.ReadOnly = true;
            txtS1Radius.Size = new Size(97, 25);
            txtS1Radius.TabIndex = 4;
            // 
            // txtS1Brightness
            // 
            txtS1Brightness.Location = new Point(92, 129);
            txtS1Brightness.Name = "txtS1Brightness";
            txtS1Brightness.ReadOnly = true;
            txtS1Brightness.Size = new Size(97, 25);
            txtS1Brightness.TabIndex = 3;
            // 
            // txtS1ST
            // 
            txtS1ST.Location = new Point(92, 88);
            txtS1ST.Name = "txtS1ST";
            txtS1ST.ReadOnly = true;
            txtS1ST.Size = new Size(97, 25);
            txtS1ST.TabIndex = 2;
            // 
            // txtS1Mass
            // 
            txtS1Mass.Location = new Point(92, 50);
            txtS1Mass.Name = "txtS1Mass";
            txtS1Mass.ReadOnly = true;
            txtS1Mass.Size = new Size(97, 25);
            txtS1Mass.TabIndex = 1;
            // 
            // txtS1Type
            // 
            txtS1Type.Location = new Point(92, 19);
            txtS1Type.Name = "txtS1Type";
            txtS1Type.ReadOnly = true;
            txtS1Type.Size = new Size(97, 25);
            txtS1Type.TabIndex = 0;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(12, 395);
            label25.Name = "label25";
            label25.Size = new Size(76, 25);
            label25.TabIndex = 19;
            label25.Text = "Planets";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 423);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1346, 221);
            dataGridView2.TabIndex = 20;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // btnShowDetails
            // 
            btnShowDetails.Enabled = false;
            btnShowDetails.Location = new Point(12, 650);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(1346, 30);
            btnShowDetails.TabIndex = 21;
            btnShowDetails.Text = "Show Selected Planet Details";
            btnShowDetails.UseVisualStyleBackColor = true;
            btnShowDetails.Click += btnShowDetails_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 671);
            Controls.Add(btnShowDetails);
            Controls.Add(dataGridView2);
            Controls.Add(label25);
            Controls.Add(gbS1);
            Controls.Add(gbS2);
            Controls.Add(btnFind);
            Controls.Add(btnClean);
            Controls.Add(dataGridView1);
            Controls.Add(txtRange);
            Controls.Add(label7);
            Controls.Add(txtAmplitude);
            Controls.Add(label6);
            Controls.Add(txtZ);
            Controls.Add(label5);
            Controls.Add(txtY);
            Controls.Add(label4);
            Controls.Add(txtX);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            PreviewKeyDown += Form1_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbS2.ResumeLayout(false);
            gbS2.PerformLayout();
            gbS1.ResumeLayout(false);
            gbS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtX;
        private TextBox txtY;
        private Label label4;
        private TextBox txtZ;
        private Label label5;
        private TextBox txtAmplitude;
        private Label label6;
        private TextBox txtRange;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btnClean;
        private Button btnFind;
        private GroupBox gbS2;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label2;
        private TextBox txtS2Crown;
        private TextBox txtS2Texture;
        private TextBox txtS2Color;
        private TextBox txtS2Radius;
        private TextBox txtS2Brightness;
        private TextBox txtS2ST;
        private TextBox txtS2Mass;
        private TextBox txtS2Type;
        private GroupBox gbS1;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox txtS1Crown;
        private TextBox txtS1Texture;
        private TextBox txtS1Color;
        private TextBox txtS1Radius;
        private TextBox txtS1Brightness;
        private TextBox txtS1ST;
        private TextBox txtS1Mass;
        private TextBox txtS1Type;
        private Label label25;
        private DataGridView dataGridView2;
        private Button btnShowDetails;
    }
}
