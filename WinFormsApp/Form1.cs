namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public List<int> Tippek = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //lblEredmenyek.Text += ((CheckBox)sender).Text;
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                Tippek.Add(Convert.ToInt32(box.Text));
                if (Tippek.Count() == 6)
                {
                    btnSorsol.Enabled = true;
                    Kapcsol(false);
                }
            }
            else
            {
                Tippek.Remove(Convert.ToInt32(box.Text));
                if (Tippek.Count() == 5)
                {
                    btnSorsol.Enabled = false;
                    Kapcsol(true);
                }
            }
            lblEredmenyek.Text = "Tippjeid: " + String.Join("; ", Tippek.OrderBy(x=>x));
        }

        private void Kapcsol(bool kapcs)
        {
            foreach (var box in panel.Controls)
            {
                if (!((CheckBox)box).Checked)
                {
                    ((CheckBox)box).Enabled = kapcs;
                };
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEredmenyek.Text = string.Empty;
            btnSorsol.Enabled = false;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 5; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Text = ((i + 1) + (j * 9)).ToString();
                    box.AutoSize = true;
                    box.Location = new System.Drawing.Point(i * 40, j * 40);
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    panel.Controls.Add(box);
                }

        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            Random rnd = new Random();
            do
            {
                set.Add(rnd.Next(1, 46));
            } while (set.Count() != 6);

            lblEredmenyek.Text = "Tippjeid: " + String.Join("; ", Tippek) + Environment.NewLine;
            lblEredmenyek.Text += "Kisorsolt sz�mok: " + String.Join("; ", set) + Environment.NewLine;
            lblEredmenyek.Text += "Eltal�lt�l: " + set.Intersect(Tippek).Count() + " db-ot (" + String.Join("; ", set.Intersect(Tippek)) + ")";

        }
    }
}