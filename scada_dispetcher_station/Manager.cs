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
using System.Threading;

namespace scada_dispetcher_station
{
    class Manager
    {
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
}