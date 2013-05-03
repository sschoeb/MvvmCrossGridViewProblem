using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace GridViewBug.Droid
{
    [Activity(Label = "GridViewBug.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}