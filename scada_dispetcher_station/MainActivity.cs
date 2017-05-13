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

        Button changeBtn;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            InitTimer();

            Manager manager = new Manager();

            //changeBtn = FindViewById<Button>(Resource.Layout.changeTemperatureBtn);
            changeBtn.Click += delegate
            {
                //Intent intent = new Intent(this, typeof(Setting));
                //StartActivity(intent);
            };

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

