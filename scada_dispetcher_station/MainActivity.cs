﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace scada_dispetcher_station
{
    [Activity(Label = "scada_dispetcher_station", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private EditText ip;
        private EditText port;
        private Button connectBtn;
        private Connect cnn = new Connect();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

