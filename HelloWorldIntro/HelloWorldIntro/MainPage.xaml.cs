using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace HelloWorldIntro
{
    public partial class MainPage : ContentPage
    {
        private int Count = 0;
        public MainPage()
        {
            InitializeComponent();
            ((Button)FindByName("ClickButton")).Text = "Runtime initialised text.";

        }

        private void ClickButton_Clicked(object sender, EventArgs e)
        {
            Count++;
            ((Button)sender).Text = $"You've clicked {Count} times. ";
        }

       
    }
}
