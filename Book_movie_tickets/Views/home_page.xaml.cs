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
    public partial class home_page : ContentPage
    {
        public home_page()
        {
            InitializeComponent();
            createMovieColection();
        }

        List<Model.Movies> movieList = new List<Model.Movies>();

        void createMovieColection()
        {
            movieList.Add(new Model.Movies { Title = "Fast & Furious 9" , Poster= "FastFurious9.jfif", });
            movieList.Add(new Model.Movies { Title = "NOBITA VÀ MẶT TRĂNG PHIÊU LƯU KÝ", Poster= "Doremon.jpg" });
            movieList.Add(new Model.Movies { Title = "Mission Impossible 6", Poster= "MissionImpossible6.jpg" });
            
            collection_movie.ItemsSource = movieList;
        }

        private void collection_movie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMovie = e.CurrentSelection[0] as Model.Movies;
            if (selectedMovie != null)
            {
                Navigation.PushAsync(new Views.MovieDetail(selectedMovie));

            }
        }

        private void movie_news_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}