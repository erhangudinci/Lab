using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    public class RadioClass
    {
        private int volym;
        private string onOff;
        private int frequencySetting;
        public static int instanceCount;

        public int Volym
        {
            get { return volym; }
            set
            {
                var validVolym = value != null && value <= 15 && value >= 0;
                if (validVolym)
                    volym = value;
                else
                {
                    Console.WriteLine("vNågot gick fel.");
                }
            }
        }
        public string OnOff
        {
            get { return onOff; }
            set
            {
                onOff = value;
            }
        }
        public int FrequencySetting
        {
            get { return frequencySetting; }
            set
            {
                var validFrequencySetting = value != null && value >= 3 && value <= 30000;
                if (validFrequencySetting)
                    frequencySetting = value;
                else
                    Console.WriteLine( "Något gick fel");
            }
        }
        static RadioClass()
        {
            instanceCount = 909;
        }
        public RadioClass()
        {
            Volym = 0;
            OnOff = "off";
            FrequencySetting = 3;
            instanceCount++;
        }
        public RadioClass(int volym, int frequencySetting,string onOff = "off") : this()
        {
            Volym = volym;
            FrequencySetting = frequencySetting;
            OnOff = onOff;
            
        }
        public RadioClass(int instanceCount): this()
        {
            //instanceCount = 0;
        }
        public override string ToString() => $"Volym: {Volym} on/off: {OnOff} FrequencySetting: {FrequencySetting}";
    }
}
