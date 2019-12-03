using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListViewHoa : ContentPage
    {

        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        public PageListViewHoa()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "cuc_9.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam" });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 40000, Hinh = "cuc_2.jpg", MoTa = "Hoa cúc vàng, cam, lá măng" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 30000, Hinh = "cuc_3.jpg", MoTa = "Hoa cúc tím" });
            lsvHoa.ItemsSource = Hoas;
        }
    }
}