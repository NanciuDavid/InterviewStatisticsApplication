using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECTWAP.Classes
{
    [Serializable]
    public class AnalysisResult
    {

        private String _department; // department of the analysis
        private int _totalInterviews; // total number of interviews
        private int _totalAccepted; // total number of accepted interviews
        private int _totalRejected; // total number of rejected interviews
        private double _acceptanceRate; // acceptance rate of the interviews
        private double _rejectionRate; // rejection rate of the interviews


        public AnalysisResult() { }
        public AnalysisResult(string department, int totalInterviews, int totalAccepted, int totalRejected, double acceptanceRate, double rejectionRate)
        {
            _department = department;
            _totalInterviews = totalInterviews;
            _totalAccepted = totalAccepted;
            _totalRejected = totalRejected;
        }


        public String Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public int TotalInterviews
        {
            get { return _totalInterviews; }
            set { _totalInterviews = value; }
        }
        public int TotalAccepted
        {
            get { return _totalAccepted; }
            set { _totalAccepted = value; }
        }
        public int TotalRejected
        {
            get { return _totalRejected; }
            set { _totalRejected = value; }
        }
        public double AcceptanceRate
        {
            get { return _acceptanceRate; }
            set { _acceptanceRate = value; }
        }
        public double RejectionRate
        {
            get { return _rejectionRate; }
            set { _rejectionRate = value; }
        }

    }
}
