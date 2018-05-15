using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestSample
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Collection { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Collection = new ObservableCollection<string>
            {
                "XX",
                "XX",
                "XX"
            };

            this.BindingContext = this;
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                Collection[i] = rand.Next(10, 100).ToString();
            }
        }
    }
}
