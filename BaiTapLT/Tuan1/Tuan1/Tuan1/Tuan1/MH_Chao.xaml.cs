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
    public partial class MH_Chao : ContentPage
    {
        public MH_Chao()
        {
            InitializeComponent();
        }

        private void cmdChao_Clicked(object sender, EventArgs e)
        {
            string Hoten = txtHoTen.Text;
            DisplayAlert(title: "Chào", message: "Chào bạn " + Hoten, cancel: "Thoát");
        }
    }
}