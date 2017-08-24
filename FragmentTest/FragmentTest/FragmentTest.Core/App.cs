using FragmentTest.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace FragmentTest.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<StartViewModel>();
        }
    }
}
