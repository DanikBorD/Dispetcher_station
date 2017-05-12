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
    class Flap
    {
        Connect cnn;
        public int NumberOfFlap;
        public UInt16 writeOpenFlap = Convert.ToUInt16(1);
        public UInt16 writeCloseFlap = Convert.ToUInt16(2);
        public UInt16 readFlap;
        public UInt16 statusFlap;

        public Flap(Connect cnn, int numberOfFlap)
        {
            this.cnn = cnn;
            this.NumberOfFlap = numberOfFlap;
        }

        private Task<bool> WriteOpen()
        {
            UInt16 dm_position = 5;

            if (NumberOfFlap == 2)
            {
                writeOpenFlap = Convert.ToUInt16(4);
            }
            

            try
            {
                bool result = cnn.plc.WriteCIO(Convert.ToUInt16(dm_position), writeOpenFlap);
                if (!result)
                {
                    throw new Exception(cnn.plc.LastError);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("WriteDM() error: " + ex.Message);            !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }

            return true;
        }

        private Task<bool> WriteClose()
        {
            UInt16 dm_position = 5;
            if (NumberOfFlap == 2)
            {
                writeOpenFlap = Convert.ToUInt16(8);
            }

            try
            {
                bool result = cnn.plc.WriteCIO(Convert.ToUInt16(dm_position), writeCloseFlap);
                if (!result)
                {
                    throw new Exception(cnn.plc.LastError);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("WriteDM() error: " + ex.Message);                  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }

            return true;
        }

        public Task<UInt16> ReadDM()
        {
            UInt16 dm_position = 100;

            if(NumberOfFlap == 2)
            {
                dm_position = 102;
            }
            readFlap = 0;
            bool in_2_0 = false;
            bool in_2_1 = false;
            bool in_2_2 = false;
            bool in_2_3 = false;

            try
            {
                bool result = this.cnn.plc.ReadDM(dm_position, ref statusFlap);
                if (!result)
                {
                    throw new Exception(this.cnc.plc.LastError);
                }

                if ((Convert.ToUInt16(statusFlap) & Convert.ToUInt16(1)) == Convert.ToUInt16(1)) in_2_0 = true;
                if ((Convert.ToUInt16(statusFlap) & Convert.ToUInt16(2)) == Convert.ToUInt16(2)) in_2_1 = true;
                if ((Convert.ToUInt16(statusFlap) & Convert.ToUInt16(4)) == Convert.ToUInt16(4)) in_2_2 = true;
                if ((Convert.ToUInt16(statusFlap) & Convert.ToUInt16(8)) == Convert.ToUInt16(8)) in_2_3 = true;


                if (in_2_0)
                {
                    string status = "��������� �������";
                }

                if (in_2_1)
                {
                    string status = "��������� �������";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ReadDM() Error: " + ex.Message + ex.Source);              !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }
    }

    
}