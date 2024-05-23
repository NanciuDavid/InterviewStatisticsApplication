using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECTWAP.Classes
{
    internal class AnalysisResult
    {

        private String department; // department of the analysis
        private int _totalInterviews; // total number of interviews
        private int _totalAccepted; // total number of accepted interviews
        private int _totalRejected; // total number of rejected interviews
        private double _acceptanceRate; // acceptance rate of the interviews
        private double _rejectionRate; // rejection rate of the interviews


        public AnalysisResult(int totalInterviews, int totalAccepted, int totalRejected, double acceptanceRate, double rejectionRate)
        {
            _totalInterviews = totalInterviews;
            _totalAccepted = totalAccepted;
            _totalRejected = totalRejected;
            _acceptanceRate = acceptanceRate;
            _rejectionRate = rejectionRate;
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
