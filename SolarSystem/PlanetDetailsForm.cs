using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging.Abstractions;
using SolarSystem.classes;

namespace SolarSystem
{
    public partial class PlanetDetailsForm : Form
    {
        private long PlanetId;
        object crust;
        object core;
        object composition;

        controllerSS c = new controllerSS();

        DataGridViewRow row;
        public PlanetDetailsForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
            this.PlanetId = (long)row.Cells[1].Value;
        }

        private void PlanetDetailsForm_Load(object sender, EventArgs e)
        {
            dataGridView2.Focus();
            txtSSName.Text = valorTextBox(row.Cells[0].Value);
            txtId.Text = PlanetId.ToString();
            txtScien.Text = valorTextBox(row.Cells[2].Value);
            txtCommon.Text = valorTextBox(row.Cells[3].Value);
            txtRadius.Text = valorTextBox(row.Cells[4].Value);
            txtMass.Text = valorTextBox(row.Cells[5].Value);
            txtDensity.Text = valorTextBox(row.Cells[6].Value);
            txtGravity.Text = valorTextBox(row.Cells[7].Value);
            txtAtmRadius.Text = (row.Cells[8].Value == null) ? "0" : row.Cells[8].Value.ToString();
            txtAtmTexture.Text = valorTextBox(row.Cells[9].Value);
            txtDistance.Text = valorTextBox(row.Cells[10].Value);
            txtAxis.Text = valorTextBox(row.Cells[11].Value);
            txtOrbitAngle.Text = valorTextBox(row.Cells[12].Value);
            txtDayDuration.Text = valorTextBox(row.Cells[13].Value);
            txtOrbitalPeriod.Text = valorTextBox(row.Cells[14].Value);
            txtAvgTemp.Text = valorTextBox(row.Cells[15].Value);
            txtTempVariation.Text = valorTextBox(row.Cells[16].Value);
            txtCoreType.Text = valorTextBox(row.Cells[17].Value);
            txtCoreTexture.Text = valorTextBox(row.Cells[18].Value);
            txtPlanetType.Text = valorTextBox(row.Cells[19].Value);
            txtDisk.Text = valorTextBox(row.Cells[20].Value);
            txtSatelite.Text = valorTextBox(row.Cells[21].Value);

            if (txtSatelite.Text == "0") 
                btnSatelite.Enabled = false;

            if(txtDisk.Text == "0")
                btnDisks.Enabled = false;

            if(txtAtmRadius.Text == "0")
                btnAtmosphere.Enabled = false;

            crust = c.Crust(PlanetId);
            if (crust == null)
                btnCrust.Enabled = false;

            core = c.Core(PlanetId);
            if (core == null)
                btnCore.Enabled = false;

            composition = c.Composition(PlanetId);
            if(composition == null)
                btnComposition.Enabled = false;

            //txtId.Text = PlanetId.ToString();
            //txtSSName.Text = Common;
            //txtScien.Text = Scien;
            //if (SateliteCount == 0)
            //    btnSatelite.Enabled = false;

            //if (DiskCount == 0)
            //    btnDisks.Enabled = false;

            //if (AtmosphereRadius == 0)
            //    btnAtmosphere.Enabled = false;
        }

        public string valorTextBox(object value)
        {
            if (value == null || value.ToString() == "")
                return "Unkonwn";
            else
                return value.ToString();
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = c.Satelites(PlanetId);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lblShow.Text = "Showing: Satelites";
        }

        private void btnDisks_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = c.Disks(PlanetId);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lblShow.Text = "Showing: Disks";
        }

        private void btnComposition_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = c.Composition(PlanetId);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblShow.Text = "Showing: Planet Composition";
        }

        private void btnAtmosphere_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = c.Atmosphere(PlanetId);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblShow.Text = "Showing: Planet Atmosphere Composition";
        }

        private void btnCrust_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = crust;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblShow.Text = "Showing: Planet Crust Composition";
        }

        private void btnCore_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = core;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblShow.Text = "Showing: Planet Core Composition";
        }
    }
}
