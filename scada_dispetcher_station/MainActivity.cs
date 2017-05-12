using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace scada_dispetcher_station
{
    [Activity(Label = "scada_dispetcher_station", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Termometr trmInside = new Termometr(1);
        Termometr trmTop = new Termometr(2);
        Termometr trmFan = new Termometr(3);
        Termometr trmStreet = new Termometr(4);
        Flap flapIndide = new Flap(1);
        Flap flapStreet = new Flap(2);

        //ip = FindViewById<EditText>(Resource.Layout.ip);
        //port = FindViewById<EditText>(Resource.Layout.port);
        //connectBtn = FindViewById<Button>(Resource.Layout.connectBtn);

        private Connect cnn = new Connect();

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Connect);
            
            // Переход к другому экрану
        }

        

    }
}

