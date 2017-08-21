using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using FragmentTest.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace FragmentTest.Droid.Activities
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(FirstFragment))]
    public class FirstFragment : MvxFragment<FirstViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.FirstView, container, false);
            return view;
        }
    }
}
