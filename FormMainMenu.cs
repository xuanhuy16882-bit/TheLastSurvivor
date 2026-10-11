using FormMainMenu;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheLastSurvivor
{
    public partial class FormMainMenu : Form
    {
        Color mauNut = Color.FromArgb(35, 35, 35);
        Color mauHover = Color.FromArgb(110, 25, 25);

        public FormMainMenu()
        {
            InitializeComponent();

            CaiDatGiaoDien();
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void CaiDatGiaoDien()
        {
            this.BackColor = Color.FromArgb(15, 15, 15);

            pnlMain.BackColor =
                Color.FromArgb(15, 15, 15);

            lblTitle.ForeColor = Color.White;

            lblSubTitle.ForeColor =
                Color.FromArgb(170, 40, 40);

            CaiDatButton(btnNewGame);
            CaiDatButton(btnContinue);
            CaiDatButton(btnHowtoPlay);
            CaiDatButton(btnSettings);
            CaiDatButton(btnExit);

            lblVersion.ForeColor = Color.Gray;
        }

        private void CaiDatButton(Button btn)
        {
            btn.BackColor = mauNut;
            btn.ForeColor = Color.White;

            btn.FlatStyle = FlatStyle.Flat;

            btn.FlatAppearance.BorderSize = 1;

            btn.FlatAppearance.BorderColor =
                Color.FromArgb(80, 80, 80);

            btn.Font = new Font(
                "Arial",
                12,
                FontStyle.Bold
            );

            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += Button_MouseEnter;
            btn.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(
            object sender,
            EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                btn.BackColor = mauHover;

                btn.FlatAppearance.BorderColor =
                    Color.FromArgb(170, 40, 40);
            }
        }

        private void Button_MouseLeave(
            object sender,
            EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                btn.BackColor = mauNut;

                btn.FlatAppearance.BorderColor =
                    Color.FromArgb(80, 80, 80);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            FormNewGame form = new FormNewGame();
            form.ShowDialog();
        }

        private void btnContinue_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show("CONTINUE");
        }

        private void btnSelectStage_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show("SELECT STAGE");
        }

        private void btnSettings_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show("SETTINGS");
        }

        private void btnExit_Click(
            object sender,
            EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn thoát game không?",
                "EXIT",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            FormHowToPlay form = new FormHowToPlay();
            form.ShowDialog();
        }
    }
}