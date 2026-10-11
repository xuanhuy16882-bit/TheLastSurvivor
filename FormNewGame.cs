using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLastSurvivor;

namespace FormMainMenu
{
    public partial class FormNewGame : Form
    {
        public FormNewGame()
        {
            InitializeComponent();
        }

        private void FormNewGame_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            string ten = txtPlayerName.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhân vật!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            GameData.PlayerName = ten;

            FormStageSelect form = new FormStageSelect();

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            string ten = txtPlayerName.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhân vật!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            GameData.PlayerName = ten;

            FormStageSelect form = new FormStageSelect();

            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
