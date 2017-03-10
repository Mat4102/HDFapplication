using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDFapp.Models;
using HDFapp.Views;
using Xamarin.Forms;

namespace HDFapp.ViewModels
{
    public class MasterPageCs : ContentPage
    {
        public ListView ListView { get { return ListPic; } }
        //public List<MasterPageItem> IMasterPageItems_ { get; set; }
       // public List<MasterPageItem> Iaa { get; set; }
          ListView ListPic;


        public MasterPageCs()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
          // Iaa.Add(new MasterPageItem
            {
                Title = "Recherche Partenaire",
                IconSource = "location.png",
                TargetType = typeof(LoginPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Inscription",
                IconSource = "login.png",
                TargetType = typeof(LoginPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Help +",
                IconSource = "plus.png",
                TargetType = typeof(LoginPage)
            });

            ListPic = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var imageCell = new ImageCell();
                    imageCell.SetValue(TextCell.TextColorProperty, Color.White);
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "WithImage");
                    return imageCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Padding = new Thickness(0, 40, 0, 0);
            Icon = "hamburger.png";
            Title = "Picardie cursus";
            BackgroundColor = Color.FromHex("#1c1b1b");
           
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
					ListPic
				}
                
            };
        }
    }
}
