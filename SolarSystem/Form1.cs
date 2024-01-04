using SolarSystem.classes;
namespace SolarSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        controllerSS t = new controllerSS();

        public void configurarHeaders()
        {
            dataGridView1.Columns["Name"].HeaderText = "Galaxy";
            dataGridView1.Columns["Id"].HeaderText = "Solar System Id";
            dataGridView1.Columns["ScientificName"].HeaderText = "Scientific Name";
            dataGridView1.Columns["CommonName"].HeaderText = "Common Name";
            dataGridView1.Columns["SolarSystemType"].HeaderText = "Type";
            dataGridView1.Columns["SolarSystemAge"].HeaderText = "Age";
            dataGridView1.Columns["PlanetCount"].HeaderText = "Planet Count";
            dataGridView1.Columns["InRange"].HeaderText = "In Range";

            for (int i = dataGridView1.Columns["S1Type"].Index; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //long X, Y, Z, Amplitude, Range = 0;
            //try
            //{
            //    X = long.Parse(txtX.Text);
            //    Y = long.Parse(txtY.Text);
            //    Z = long.Parse(txtZ.Text);
            //    Amplitude = long.Parse(txtAmplitude.Text);
            //    Range = long.Parse(txtRange.Text);
            //}catch(Exception ex)
            //{
            //    MessageBox.Show("Incorrectly entered data", "Error", MessageBoxButtons.OK, 
            //        MessageBoxIcon.Error);
            //    return;
            //}

            //if (Range > Amplitude)
            //{
            //    MessageBox.Show("The Amplitude must be higher or equal to Range", "Error", MessageBoxButtons.OK,
            //    MessageBoxIcon.Error);
            //    return;
            //}

            //var (result1, result2) = t.CallStoredProcedure(X, Y, Z, Amplitude, Range);
            //if(result1.Count == 0)
            //{
            //    MessageBox.Show("\"No solar systems were found at the indicated coordinates",
            //        "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            var (result1, result2) = t.CallStoredProcedure();
            dataGridView1.DataSource = result1;
            configurarHeaders();
            definirCor();
            MessageBox.Show($"Total: {result2.TotalRows}\nIn Range: {result2.CountInRange}\n" +
                $"Out of Range: {result2.CountOutOfRange}", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            txtAmplitude.Clear();
            txtRange.Clear();
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            txtS1Brightness.Clear();
            txtS1Color.Clear();
            txtS1Crown.Clear();
            txtS1Mass.Clear();
            txtS1Radius.Clear();
            txtS1ST.Clear();
            txtS1Texture.Clear();
            txtS1Type.Clear();
            limparS2();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txtS1Brightness.Text = dataGridView1.SelectedRows[0].Cells["S1Brightness"].Value.ToString();
                txtS1Color.Text = dataGridView1.SelectedRows[0].Cells["S1Color"].Value.ToString();
                txtS1Crown.Text = dataGridView1.SelectedRows[0].Cells["S1Crown"].Value.ToString();
                txtS1Mass.Text = dataGridView1.SelectedRows[0].Cells["S1Mass"].Value.ToString();
                txtS1ST.Text = dataGridView1.SelectedRows[0].Cells["S1SurfaceTemp"].Value.ToString();
                txtS1Type.Text = dataGridView1.SelectedRows[0].Cells["S1Type"].Value.ToString();
                txtS1Texture.Text = dataGridView1.SelectedRows[0].Cells["S1Texture"].Value.ToString();
                txtS1Radius.Text = dataGridView1.SelectedRows[0].Cells["S1Radius"].Value.ToString();

                if (dataGridView1.SelectedRows[0].Cells["SolarSystemType"].Value.ToString() == "D")
                {
                    txtS2Brightness.Text = dataGridView1.SelectedRows[0].Cells["S2Brightness"].Value.ToString();
                    txtS2Color.Text = dataGridView1.SelectedRows[0].Cells["S2Color"].Value.ToString();
                    txtS2Crown.Text = dataGridView1.SelectedRows[0].Cells["S2Crown"].Value.ToString();
                    txtS2Mass.Text = dataGridView1.SelectedRows[0].Cells["S2Mass"].Value.ToString();
                    txtS2ST.Text = dataGridView1.SelectedRows[0].Cells["S2SurfaceTemp"].Value.ToString();
                    txtS2Type.Text = dataGridView1.SelectedRows[0].Cells["S2Type"].Value.ToString();
                    txtS2Texture.Text = dataGridView1.SelectedRows[0].Cells["S2Texture"].Value.ToString();
                    txtS2Radius.Text = dataGridView1.SelectedRows[0].Cells["S2Radius"].Value.ToString();
                }
                else
                {
                    limparS2();
                }
            }
        }

        public void limparS2()
        {
            txtS2Brightness.Clear();
            txtS2Color.Clear();
            txtS2Crown.Clear();
            txtS2Mass.Clear();
            txtS2ST.Clear();
            txtS2Type.Clear();
            txtS2Texture.Clear();
            txtS2Radius.Clear();
        }

        public void definirCor()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["InRange"].Value.ToString() == "I")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
                }
            }
        }
    }
}
