using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListViewGroup : ContentPage
    {
        public PageListViewGroup()
        {
            InitializeComponent();
            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.LoaiHoas;
        }
    }
}