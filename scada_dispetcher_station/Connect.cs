using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace scada_dispetcher_station
{
    [Activity(Label = "CONNECT", MainLauncher = false, Icon = "@drawable/icon")]
    public class Connect : Activity
    {
        EditText ip;
        EditText port;
        Button connectBtn;
        bool isSuccessConnect = true;
        string ipText = "";
        string portText = "";

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Connect);

            while (isSuccessConnect)
            {
                connectBtn.Click += delegate
                {
                    ipText = ip.Text;
                    portText = port.Text;
                };
                if (!(IsConnect(ipText, portText)))
                {
                    Toast.MakeText(this, "Соединение не установлено, попробуйте еще раз", ToastLength.Long);
                    continue;

                }
                Toast.MakeText(this, "Соединение установлено!", ToastLength.Long);
            }

            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }

        

    //public mcOMRON.OmronPLC plc;
    //this.plc = new mcOMRON.OmronPLC(mcOMRON.TransportType.Tcp);     

    public bool IsConnect(string ip, string port)
        {
            bool IsOK = false;
            if (ip == "" || port == "") return IsOK;


            //try
            //{
            //    mcomron.tcpfinscommand tcpcommand = ((mcomron.tcpfinscommand)plc.finscommand);
            //    tcpcommand.settcpparams(ipaddress.parse(ip), convert.toint32(port));

            //    if (!plc.connect())
            //    {
            //        throw new exception(plc.lasterror);
            //    }
            //}
            //catch (exception ex)
            //{
            //    return isok;
            //}

            //try
            //{
            //    if (!plc.finsconnectiondataread(0))
            //    {
            //        throw new exception(plc.lasterror);
            //    }

            //}
            //catch (exception ex)
            //{
            //    return isok;
            //}
            //IsOK = true;

            //return IsOK;
            return true;
        }

    }
}