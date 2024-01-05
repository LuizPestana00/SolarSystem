using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolarSystem.classes;

namespace SolarSystem
{
    public partial class PlanetDetailsForm : Form
    {
        private long PlanetId;
        private string? Common;
        private string? Scien;
        private int DiskCount;
        private int SateliteCount;
        private decimal AtmosphereRadius;
        object crust;
        object core;

        controllerSS c = new controllerSS();
        public PlanetDetailsForm(long planetId, string common, string scien,
            int diskCount, int sateliteCount, decimal atmosphereRadius)
        {
            InitializeComponent();
            this.PlanetId = planetId;
            this.Common = common;
            this.Scien = scien;
            this.DiskCount = diskCount;
            this.SateliteCount = sateliteCount;
            this.AtmosphereRadius = atmosphereRadius;
        }

        private void PlanetDetailsForm_Load(object sender, EventArgs e)
        {
            txtId.Text = PlanetId.ToString();
            txtCommon.Text = Common;
            txtScien.Text = Scien;
            if (SateliteCount == 0)
                btnSatelite.Enabled = false;

            if (DiskCount == 0)
                btnDisks.Enabled = false;

            if (AtmosphereRadius == 0)
                btnAtmosphere.Enabled = false;

            crust = c.Crust(PlanetId);
            if (crust == null)
                btnCrust.Enabled = false;

            core = c.Core(PlanetId);
            if(core == null)
                btnCore.Enabled = false;
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
