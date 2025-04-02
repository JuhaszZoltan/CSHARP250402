namespace CSHARP250402
{
    public partial class HappyCowsForm : Form
    {
        const string Path = "C:\\Users\\juhas\\source\\repos\\CSHARP250402\\RESOURCES\\hozam.txt";

        public List<Tehen> happyCows = [];

        public HappyCowsForm()
        {
            InitializeComponent();
            cbxNap.SelectedIndex = 2;
            this.Load += HappyCowsFormLoad;
            trbTej.ValueChanged += TrbTejValueChanged;
            btnLekerdezes.Click += BtnLekerdezesClick;
            btnKilepes.Click += BtnKilepesClick;

            lblTej.Text = $"Beállított érték: {trbTej.Value} liter";
        }

        private void BtnLekerdezesClick(object? sender, EventArgs e)
        {
            Tehen? tehen = happyCows.SingleOrDefault(t => t.ID == txtTehenID.Text);
            if (tehen is null) return;

            int tej = tehen.Mennyisegek[cbxNap.SelectedIndex];

            string msgStr = string.Empty;

            if (tej == 0) msgStr = "Nem volt fejés.";
            else if (tej < trbTej.Minimum)
            {
                msgStr = "Az adott napon a mennyiség nem érte el a limitet!";
            }
            else
            {
                msgStr = $"Az adott napon a mennyiség {tej} liter volt.";
            }

            if (trbTej.Minimum <= tej && tej <= trbTej.Maximum)
                trbTej.Value = tej;

            _ = MessageBox.Show(
                caption: "Eredmény",
                text: msgStr,
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);

        }

        private void BtnKilepesClick(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HappyCowsFormLoad(object? sender, EventArgs e)
        {
            using StreamReader sr = new(Path);
            while (!sr.EndOfStream)
            {
                var t = sr.ReadLine().Split(';');
                Tehen thn = new(t[0]);
                if (!happyCows.Contains(thn)) happyCows.Add(thn);
                happyCows[happyCows.IndexOf(thn)].TejRogzit(t[1], int.Parse(t[2]));
            }
        }

        private void TrbTejValueChanged(object? sender, EventArgs e)
        {
            lblTej.Text = $"Beállított érték: {trbTej.Value} liter";
        }
    }
}
