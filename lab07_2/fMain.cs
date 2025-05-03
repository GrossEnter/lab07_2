using System.Reflection;

namespace lab07_2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            gv.AutoGenerateColumns = false;

            BindSrcPlanet.Add(new Planet
            {
                Name = "Ксар'тул",
                Type = "техно-руїни",
                Control = "хаос",
                WrapStatus = WarpStatus.Storm,
                Faction = "Слово Владики",
                UniqueFeature = "живий метал",
                DangerLevel = 10
            });
            BindSrcPlanet.Add(new Planet
            {
                Name = "Вертракс",
                Type = "Джунглі з мегафлорою",
                Control = "Імперіум",
                WrapStatus = WarpStatus.Normal,
                Faction = "Адептус Механікус",
                UniqueFeature = "Ксенореліквії",
                DangerLevel = 5
            });
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (fPlanet form = new fPlanet())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Planet addedPlanet = form.NewPlanet;
                    BindSrcPlanet.Add(addedPlanet);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (BindSrcPlanet.Current is Planet planet)
            {
                fPlanet form = new fPlanet();

                form.FillFields(planet);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Planet NewPlanet = form.NewPlanet;
                    BindSrcPlanet[BindSrcPlanet.Position] = NewPlanet;
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (BindSrcPlanet.Current == null)
            {
                MessageBox.Show("Спочатку оберіть запис для видалення.", "Увага");
            }
            else
            {
                var result = MessageBox.Show("Ви точно хочете видалити запис?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BindSrcPlanet.RemoveCurrent();
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви дійсно хочете видалити всі записи?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BindSrcPlanet.Clear();
            }
        }
    }
}
