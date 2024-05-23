
/*
 * 
 * using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PROIECTWAP.Classes;

namespace PROIECTWAP
{
    public partial class PieChartControl : Control
    {
        private static string dbFilePath = "DemoDB.db";
        private static SqliteDataAccess dataAccess = new SqliteDataAccess(dbFilePath);

        private PieChartCategory[] _data;
        public PieChartCategory[] Data
        {
            get { return _data; }
            set
            {
                if (_data == value)
                    return;

                _data = value;

                //trigger the Paint event
                Invalidate();
            }
        }

        public PieChartControl()
        {
            InitializeComponent();

            //redraws if resized
            ResizeRedraw = true;

            //Default data
            Data = new[]
            {
                new PieChartCategory("Category 1", 20, Color.Red),
                new PieChartCategory("Category 2", 80, Color.Blue)
            };
        }
    }
}

*/