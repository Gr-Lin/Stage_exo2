using System;
using Android.App;
using Android.Runtime;
using Storm.Mvvm;
using Storm.Mvvm.Inject;
using System.Collections.Generic;
using Sky.Activities;
using ViewModelPCL;

[Application]
public class Application : ApplicationBase
{
    public Application(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
    {
    }

    public override void OnCreate()
    {
        base.OnCreate();

        Dictionary<string, Type> views = new Dictionary<string, Type>
        {
            { "Moon", typeof(MoonActivity)},
            { "Sun", typeof(SunActivity)}
        };

        AndroidContainer.CreateInstance<AndroidContainer>(this, views);
    }
}