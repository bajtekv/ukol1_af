using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;
using System.Threading;

namespace ukol1_af
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            SetCulture();
            BindingContext = new ViewModel();
            InitializeComponent();
        }
        private void SetCulture()
        {
            CultureInfo czechCulture = new CultureInfo("cs-CZ");
            CultureInfo.DefaultThreadCurrentCulture = czechCulture;
        }
    }
}
