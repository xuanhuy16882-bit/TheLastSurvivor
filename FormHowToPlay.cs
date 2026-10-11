using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLastSurvivor
{
    public partial class FormHowToPlay : Form
    {
        public FormHowToPlay()
        {
            InitializeComponent();
            lblTitle.Text = "HOW TO PLAY";

            lblControls.Text =
                "DI CHUYỂN\n" +
                "W A S D       Di chuyển nhân vật\n\n" +

                "CHUỘT          Xoay hướng nhân vật\n\n" +

                "LEFT CLICK     Bắn súng\n" +
                "R              Nạp đạn\n" +
                "V              Đánh cận chiến\n" +
                "E              Tương tác / nhặt đồ\n\n" +

                "SINH TỒN\n" +
                "• Tiêu diệt zombie\n" +
                "• Thu thập đạn và vật phẩm\n" +
                "• Sử dụng giáp để giảm sát thương\n" +
                "• Tìm Supply Box\n" +
                "• Hoàn thành từng Stage";

            this.Text = "THE LAST SURVIVOR - HOW TO PLAY";
        }

        private void FormHowToPlay_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblControls_Click(object sender, EventArgs e)
        {
            
        }
    }
}
