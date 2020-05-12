using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDevWeek6Lab
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<string> strList = new List<string>();
        public static MainPage Instance;
        public MainPage()
        {
            InitializeComponent();
            strList.Add("Grani cheering you on to farm harder.");
            strList.Add("Image2");
            strList.Add("Image3");
            strList.Add("Image4");
            BindingContext = new SwipeCommandPageViewModel();
            Instance = this;
        }

    }
}
