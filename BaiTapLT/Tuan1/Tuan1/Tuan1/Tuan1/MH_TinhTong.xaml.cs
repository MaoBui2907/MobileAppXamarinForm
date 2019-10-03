using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MH_TinhTong : ContentPage
    {
        public MH_TinhTong()
        {
            InitializeComponent();
        }

        private void cmdTinhTong_Clicked(object sender, EventArgs e)
        {
            double soA, soB;
            soA = double.Parse(txtA.Text);
            soB = double.Parse(txtB.Text);
            double tong = soA + soB;
            txtTong.Text = tong.ToString();
        }

        private void cmdVeTrangChu_Clicked(object sender, EventArgs e)
        {

        }
    }
}