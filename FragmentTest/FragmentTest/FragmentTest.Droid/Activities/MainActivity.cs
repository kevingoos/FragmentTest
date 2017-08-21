using Android.App;
using Android.OS;
using FragmentTest.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace FragmentTest.Droid.Activities
{
    [Activity(Label = "Fragment View")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}