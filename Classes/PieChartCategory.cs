using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECTWAP.Classes
{
    internal class PieChartCategory
    {
        //name and acceptance rate
        public string Department { get; set; }
        public double AcceptanceRate { get; set; }

        public Color color { get; set; }

        public PieChartCategory(string department, float acceptanceRate , Color color)
        {
            Department = department;
            AcceptanceRate = acceptanceRate;
            this.color = color;
        }
    }
}
