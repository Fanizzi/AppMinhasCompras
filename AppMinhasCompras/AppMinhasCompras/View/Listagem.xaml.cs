using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMinhasCompras.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listagem : ContentPage
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void ToolbarItem_ClickedNovo (object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NovoProduto());
            }
            catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK"); 
            }
        }

        private void ToolbarItem_ClickedSomar(object sender, EventArgs e)
        {

        }
    }
}