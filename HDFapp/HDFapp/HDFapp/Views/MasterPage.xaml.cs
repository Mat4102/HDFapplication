using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDFapp.Models;
using HDFapp.ViewModels;
using Xamarin.Forms;

namespace HDFapp.Views
{
    public partial class MasterPage : ContentPage
    {
       // public ListView ListView { get { return ListViewMenu; } }
       //private MasterPageCs test;
        
        public MasterPage()
        {
          InitializeComponent();
        //test= new MasterPageCs();
          // test.Iaa.Add(new MasterPageItem
          //  {
          //      Title = "connexion1",
          //      IconSource = "location.png",
          //      TargetType = typeof(LoginPage)
          //  });
          //  test.Iaa.Add(new MasterPageItem
          //  {
          //      Title = "inscription",
          //      IconSource = "location.png",
          //      TargetType = typeof(LoginPage)
          //  });
           
          //var test =  new  MasterPageCs();
         // test.ListView.ItemsSource = masterPageItems;
           // ListPic.ItemsSource = test.Iaa;
        }
    }
}
