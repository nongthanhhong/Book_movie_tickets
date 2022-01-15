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
            newList.Add(new New {
                newName = "[THE CONJURING: MA XUI QUỶ KHIẾN] - HÉ LỘ TRAILER CHÍNH THỨC CHO PHẦN TIẾP THEO", 
                newImg = "conjuring.jpg",
                newDetail="Hẹn hò ra rạp từ tháng 9/2020, song do ảnh hưởng của COVID-19, cho tới tận mùa hè năm nay, khán giả thế giới mới được thưởng thức phần tiếp theo..."});
            newList.Add(new New { 
                newName = "[THÁM TỬ LỪNG DANH CONAN: VIÊN ĐẠN ĐỎ] - GIẢI MÃ THƯƠNG HIỆU CONAN", 
                newImg = "conan.jpg",
                newDetail="Lần đầu ra mắt năm 1994, Conan giữ nguyên sức hấp dẫn sau hơn hai thập kỷ, là một trong những thương hiệu anime/manga nổi tiếng bậc nhất trên thế giới.."});
            lstNew.ItemsSource = newList;

        }
        public new_page()
        {
            InitializeComponent();
            newInit();
        }
    }
}