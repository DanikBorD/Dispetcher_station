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
    class Flap
    {
        Connect cnn;
        public UInt16 writeFlap_1;
        public UInt16 readFlap_1;
        public UInt16 statusFlap_1;

        public Flap(Connect cnn)
        {
            this.cnn = cnn;
        }
    }

    private async bool WriteOpen()
    {
        UInt16 dm_position = 5;
        writeOpenFlap_1 = Convert.ToUInt16(1);

        try
        {
            bool result = cnn.plc.WriteCIO(Convert.ToUInt16(dm_position), writeFlap_1);
            if (!result)
            {
                throw new Exception(cnn.plc.LastError);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("WriteDM() error: " + ex.Message);
        }

        return true;
    }

    private async bool WriteClose()
    {
        UInt16 dm_position = 5;
        writeOpenFlap_1 = Convert.ToUInt16(2);

        try
        {
            bool result = cnn.plc.WriteCIO(Convert.ToUInt16(dm_position), writeFlap_1);
            if (!result)
            {
                throw new Exception(cnn.plc.LastError);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("WriteDM() error: " + ex.Message);
        }

        return true;
    }

    public async UInt16 ReadDM()
    {
        UInt16 dm_position = 100;
        readFlap_1 = 0;
        //bool in_2_4;
        //bool in_2_5;
        //bool in_2_6;
        //bool in_2_7;
        //bool in_2_8;

        try
        {
            bool result = this.cnn.plc.ReadDM(dm_position, ref statusFlap_1);
            if (!result)
            {
                throw new Exception(this.cnc.plc.LastError);
            }


            float dmval_f = Convert.ToUInt32(statusFlap_1);


            if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(1)) == Convert.ToUInt16(1)) in_2_0 = true;
            if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(2)) == Convert.ToUInt16(2)) in_2_1 = true;
            if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(4)) == Convert.ToUInt16(4)) in_2_2 = true;
            if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(8)) == Convert.ToUInt16(8)) in_2_3 = true;
            

            if (in_2_0 == true)
            {
                string status = "Полностью открыто";
            }

            if (in_2_1)
            {
                string status = "Полностью закрыто";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("ReadDM() Error: " + ex.Message + ex.Source);
        }
    }
}