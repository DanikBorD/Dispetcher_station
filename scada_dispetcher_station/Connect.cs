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

            return IsOK;
        }
        public async void AlertConnectFalse()
        {
            DisplayAlert("Уведомление", "Соединение прошло неудачно", "OK");                 !!!!!!!!!!!!!!!!!!!!!!!
            //bool result = DisplayAlert("Соединение прошло неудачно", "Вы хотите повторить?", "Да", "Нет");
            //await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Повторить" : "Отменить"), "OK");
            //return result;
        }
    }
}