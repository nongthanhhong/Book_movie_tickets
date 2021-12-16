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
    public partial class buy_ticket : ContentPage
    {
        
        public buy_ticket()
        {
            InitializeComponent();
            createRapChieu();
        }
        
        List<Model.RapChieu> lst_rapchieu = new List<Model.RapChieu>();
        void createRapChieu()
        {
            lst_rapchieu.Add(new Model.RapChieu
            {
                dia_chi = "25b Hai Bà Trung, Vĩnh Ninh, Thành phố Huế, Thừa Thiên Huế",
                ten_rap = "Cinestar Huế",
                Img = "cineHue.jfif",
                phone_num = "0123456789"
            });
            lst_rapchieu.Add(new Model.RapChieu
            {
                dia_chi = "25b Hai Bà Trung, Vĩnh Ninh, Thành phố Huế, Thừa Thiên Huế",
                ten_rap = "Cinestar Huế",
                Img = "cineHue.jfif",
                phone_num = "0123456789"
            });
            lst_rapchieu.Add(new Model.RapChieu
            {
                dia_chi = "25b Hai Bà Trung, Vĩnh Ninh, Thành phố Huế, Thừa Thiên Huế",
                ten_rap = "Cinestar Huế",
                Img = "cineHue.jfif",
                phone_num = "0123456789"
            });
            Coll_rapchieu.ItemsSource = lst_rapchieu;
        }

        private void Coll_rapchieu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedRap = e.CurrentSelection[0] as Model.RapChieu;
            if (selectedRap != null)
            {
                Navigation.PushAsync(new Views.ListFilm(selectedRap));

            }
        }
    }
}