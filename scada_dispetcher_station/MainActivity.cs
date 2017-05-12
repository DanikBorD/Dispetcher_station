using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Threading;

namespace scada_dispetcher_station
{
    [Activity(Label = "scada_dispetcher_station", MainLauncher = false, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Termometr trmInside;
        Termometr trmTop;
        Termometr trmFan;
        Termometr trmStreet;
        Flap flapIndide;
        Flap flapStreet;
        Button changeBtn;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            InitTimer();

            trmInside = new Termometr(1);
            trmTop = new Termometr(2);
            trmFan = new Termometr(3);
            trmStreet = new Termometr(4);
            flapIndide = new Flap(1);
            flapStreet = new Flap(2);
            changeBtn = FindViewById<Button>(Resource.Layout.changeTemperatureBtn);


            // Переход к другому экрану
        }

        public static void InitTimer()
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(AgainstActions);
            // создаем таймер

            Timer timer = new Timer(tm, num, 0, 2000);
        }

        public static void AgainstActions(object obj)
        {

        }



    }
}

