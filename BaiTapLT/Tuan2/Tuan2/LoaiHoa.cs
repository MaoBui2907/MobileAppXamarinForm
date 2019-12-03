using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan2
{
    class LoaiHoa:List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai) 
        {
            TenLoai = tenloai;    
        }
        public IList<LoaiHoa> LoaiHoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cúc") 
                {
                    new hoa { TenHoa="Đón xuân", Gia=50000, Hinh="cuc_9.jpg", MoTa="ADADA"},
                    new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc_2.jpg", MoTa = "DSDS" }
                },
                new LoaiHoa("Hoa cưới")
                {
                    new hoa { TenHoa="Dây tơ hồng", Gia=5000, Hinh="cuoi_1.jpg", MoTa="ERER"},
                    new hoa { TenHoa="Cầu thủy tiên", Gia=4000, Hinh="cuoi_2.jpg", MoTa="343443"}
                }
            };
            LoaiHoas = l;
        }

    }
}
