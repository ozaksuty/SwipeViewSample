using System.ComponentModel;
using Xamarin.Forms;

namespace SwipeViewSample
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Forms.SetFlags("SwipeView_Experimental");
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        private void SwipeView_SwipeStarted(object sender, SwipeStartedEventArgs e)
        {

        }

        private void SwipeView_SwipeEnded(object sender, SwipeEndedEventArgs e)
        {

        }

        private void SwipeView_SwipeChanging(object sender, SwipeChangingEventArgs e)
        {

        }

        private void SwipeItem_Invoked(object sender, System.EventArgs e)
        {

        }
    }
}
