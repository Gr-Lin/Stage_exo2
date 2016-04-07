using Android.App;
using Android.OS;
using Storm.Mvvm;
using ViewModelPCL.ViewModel;


namespace Sky.Activities
{
    [Activity(Label = "Moon", MainLauncher = false, Icon = "@drawable/icon")]
    public partial class MoonActivity : ActivityBase
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Moon);
            SetViewModel(new MoonViewModel());
        }
    }
}