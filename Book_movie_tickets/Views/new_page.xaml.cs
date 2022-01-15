using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Book_movie_tickets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class new_page : ContentPage
    {
        List<New> newList;
        void newInit()
        {
            newList = new List<New>();
            newList.Add(new New { newName = "C'TEN - XEM PHIM CHỉ 45K LÚC 10H", newImg = "Cten.jpg" });
            newList.Add(new New { newName = "HSSV TẸT GA 45K SUỐT TUẦN TOÀN HỆ THỐNG", newImg = "HSSV.jpg" });
            newList.Add(new New { newName = "C'MEMBER - NGÀY HỘI THÀNH VIÊN", newImg = "Member.jpg" });
            lstNew.ItemsSource = newList;

        }
        public new_page()
        {
            InitializeComponent();
            newInit();
        }
    }
}