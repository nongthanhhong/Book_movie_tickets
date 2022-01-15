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
    public partial class voucher_page : ContentPage
    {
        List<Voucher> voucherList;
        void voucherInit()
        {
            voucherList = new List<Voucher>();
            voucherList.Add(new Voucher { voucherName = "C'TEN - XEM PHIM CHỉ 45K LÚC 10H", voucherImg = "Cten.jpg" });
            voucherList.Add(new Voucher { voucherName = "HSSV TẸT GA 45K SUỐT TUẦN TOÀN HỆ THỐNG", voucherImg = "HSSV.jpg" });
            voucherList.Add(new Voucher { voucherName = "C'MEMBER - NGÀY HỘI THÀNH VIÊN", voucherImg = "Member.jpg" });
            lstVoucher.ItemsSource = voucherList;

        }
        public voucher_page()
        {
            InitializeComponent();
            voucherInit();
        }
    }
}