using Android.App;
using Android.OS;
using FragmentTest2.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace FragmentTest2.Droid.Activities
{
    [Activity(Label = "Fragment Activity")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}