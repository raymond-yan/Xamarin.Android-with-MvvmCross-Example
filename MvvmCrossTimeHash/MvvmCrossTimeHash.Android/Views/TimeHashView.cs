using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCrossTimeHash.ViewModels;

namespace MvvmCrossTimeHash.Droid.Views
{
    [Activity(Label = "TimeHashView", MainLauncher = true)]
    public class TimeHashView : MvxActivity<TimeHashViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Time_Hash);
            // Create your application here
        }
    }
}