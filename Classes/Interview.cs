using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECTWAP.Classes
{
    [Serializable]
   
        public class Interview
        {
            public int ID { get; set; }
            public string Duration { get; set; }
            public string Time { get; set; }
            public string Location { get; set; }
            public string Result { get; set; }

            public Interview(int id, string duration, string time, string location, string result)
            {
                ID = id;
                Duration = duration;
                Time = time;
                Location = location;
                Result = result;
            }

        //parameter less constructor
        public Interview()
        { }
        }

    }

