using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSample.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MagicBox : ContentView
	{

        public static readonly BindableProperty TextProperty =
          BindableProperty.Create("Text", typeof(string), typeof(MagicBox), "XX");

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public MagicBox ()
		{
			InitializeComponent ();
            this.BindingContext = this;
		}
	}
}