using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheLastSurvivor
{
    public partial class FormStageSelect : Form
    {
        Color mauNut = Color.FromArgb(35, 35, 35);
        Color mauHover = Color.FromArgb(110, 25, 25);

        public FormStageSelect()
        {
            InitializeComponent();

            CaiDatGiaoDien();
            CaiDatSuKien();
        }

        private void CaiDatGiaoDien()
        {
            this.ClientSize = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.BackColor = Color.FromArgb(15, 15, 15);

            pnlStage.BackColor =
                Color.FromArgb(15, 15, 15);

            lblTitle.ForeColor = Color.White;

            btnStage1.Enabled = true;

            btnStage2.Enabled = false;
            btnStage3.Enabled = false;
            btnStage4.Enabled = false;
            btnStage5.Enabled = false;
            btnStage6.Enabled = false;
            btnStage7.Enabled = false;
            btnStage8.Enabled = false;
            btnStage9.Enabled = false;
            btnStage10.Enabled = false;

            CaiDatButton(btnStage1);
        }
        private void FormStageSelect_Load(
    object sender,
    EventArgs e)
        {
        }
        private void btnBack_Click(
    object sender,
    EventArgs e)
        {
            FormMainMenu formMainMenu =
                new FormMainMenu();

            formMainMenu.Show();

            this.Close();
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
                11,
                FontStyle.Bold
            );

            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += Button_MouseEnter;
            btn.MouseLeave += Button_MouseLeave;
        }

        private void CaiDatSuKien()
        {
        }

        private void Button_MouseEnter(
            object sender,
            EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && btn.Enabled)
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

            if (btn != null && btn.Enabled)
            {
                btn.BackColor = mauNut;

                btn.FlatAppearance.BorderColor =
                    Color.FromArgb(80, 80, 80);
            }
        }

        private void btnStage1_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Bắt đầu STAGE 1 - THE HOUSE",
                "STAGE 1"
            );
        }
    }
}