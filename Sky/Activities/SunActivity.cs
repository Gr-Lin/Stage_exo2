using Android.App;
using Android.OS;
using Storm.Mvvm;
using ViewModelPCL.ViewModel;

namespace Sky.Activities
{
    [Activity(Label = "Sky", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class SunActivity : ActivityBase
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Sun);
            SetViewModel(new SunViewModel());
        }
    }
}