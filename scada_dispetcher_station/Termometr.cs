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

namespace scada_dispetcher_station
{
    class Termometr
    {
        Connect cnn;
        public int temperature;
        public int normalTemperature;
        public int maxDifference;
        public int difference;
        public UInt16 tmpFromPLC;

        public Termometr(Connect cnn)
        {
            this.cnn = cnn;
        }

        private async UInt16 ReadDM()
        {
            UInt16 dm_position = 104;

            try
            {
                bool result = cnn.plc.ReadDM(dm_position, ref tmpFromPLC);
                if (!result)
                {
                    throw new Exception(cnn.plc.LastError);
                }

                messegeList_1.Text = cnn.plc.LastDialog("READ DM");
                messegeList_1.AppendText("DM VALUE: " + dmval.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("ReadDM() Error: " + ex.Message);
            }

            return tmpFromPLC;
        }
    }
}