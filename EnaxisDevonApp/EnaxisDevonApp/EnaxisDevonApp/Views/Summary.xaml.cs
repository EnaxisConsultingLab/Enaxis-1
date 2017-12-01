
using EnaxisDevonApp.ViewModels;
using EnaxisDevonApp.ViewModels.Data;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace EnaxisDevonApp.Views
{
    public partial class Summary : ContentPage
    {
        public Summary()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //your code here;
            var service = new PIWebApiService();

            var results = await service.DownloadWebData("https://pi.dvnhackathon.com/piwebapi/streams/P0jyMYLmgLIU6nZDex9wsupAunECAAT1NJU09GVFBJLTAwMVxGUkFDLlVGTDo6U0tJRCAjNzcuR0VMX0JSRUFLRVJfQUNUSVZF/value");
            lblJsonResut.Text = results;

            //ViewModels.Data.Point result = JsonConvert.DeserializeObject<ViewModels.Data.Point>(results);
            //this.BindingContext = result;


        }
    }
}