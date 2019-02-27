using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /*
         <Button Text="Stack" Clicked="GoPaginaStack" ></Button>
        <Button Text="Grid" Clicked="GoPaginaGrid" ></Button>
        <Button Text="Absolute" Clicked="GoPaginaAbsolute" ></Button>
        <Button Text="Relative" Clicked="GoPaginaRelative" ></Button>
        <Button Text="Scroll" Clicked="GoPaginaScroll" ></Button>
        */

        private void GoPaginaStack(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }

        private void GoPaginaGrid(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }

        private void GoPaginaAbsolute(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }

        private void GoPaginaRelative(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }

        private void GoPaginaScroll(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }

    }
}
