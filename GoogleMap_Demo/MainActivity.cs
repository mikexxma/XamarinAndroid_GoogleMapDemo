using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using System;

namespace GoogleMap_Demo
{
    [Activity(Label = "GoogleMap_Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    { 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            Button bt1 = FindViewById<Button>(Resource.Id.showGoogleMap);
            bt1.Click += Bt1_Click;
        }

        private void Bt1_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(MyMapActivity));
        }
    }
}

