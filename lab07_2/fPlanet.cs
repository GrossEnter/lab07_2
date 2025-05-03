using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab07_2
{
    public partial class fPlanet : Form
    {
        public Planet NewPlanet { get; private set; }
        public fPlanet()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string type = txtType.Text;
            string control = txtControl.Text;
            string warpStatus = txtWarpStatus.Text;
            string faction = txtFaction.Text;
            string unuqueFeauters = txtUniqueFeauters.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(control) ||
                string.IsNullOrWhiteSpace(warpStatus) || string.IsNullOrWhiteSpace(faction) || string.IsNullOrWhiteSpace(unuqueFeauters))
                {
                    MessageBox.Show("Заповніть всі обов’язкові поля.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            if (!int.TryParse(txtDangerLevel.Text, out int dangerLevel))
            {
                MessageBox.Show("Невірний формат в полі 'рівень небезпеки'.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewPlanet = new Planet(name, type, control, warpStatus, faction, unuqueFeauters, dangerLevel);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void FillFields(Planet planet)
        {
            txtName.Text = planet.Name;
            txtType.Text = planet.Type;
            txtControl.Text = planet.Control;
            txtFaction.Text = planet.Faction;
            txtUniqueFeauters.Text = planet.UniqueFeature;
            txtDangerLevel.Text = planet.DangerLevel.ToString();
        }
    }
}
