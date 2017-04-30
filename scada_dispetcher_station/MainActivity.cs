using Android.App;
using Android.Widget;
using Android.OS;

namespace scada_dispetcher_station
{
    [Activity(Label = "scada_dispetcher_station", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText ip;
        EditText port;
        Button connectBtn;
        bool isSuccessConnect = false;
        Termometr trm;

        ip = FindViewById<EditText>(Resource.Id.IP);
        port = FindViewById<EditText>(Resource.Id.PORT);
        connectBtn = FindViewById<Button>(Resource.Id.connectBtn);

        private Connect cnn = new Connect();

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Connect);
            while(isSuccessConnect)
            {
                connectBtn.Click += delegate
                {
                    string ipText = ip.Text;
                    string portText = port.Text;
                };
                if (!(cnn.IsConnect(ip, port)))
                {
                    bool result = cnn.AlertConnectFalse();
                    if(result)
                    {
                        continue;
                    }
                    else
                    {
                        await DisplayAlert("Уведомление", "Приложение закрывается", "OK");
                        return;
                    }
                }
                isSuccessConnect = true;
                await DisplayAlert("Уведомление", "Соединение прошло успешно!", "OK");
            }
            // Переход к другому экрану
        }

        

    }
}

