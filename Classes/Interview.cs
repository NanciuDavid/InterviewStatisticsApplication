using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECTWAP.Classes
{
    internal class Interview
    {

        private int _interviewID; // unique identifier for the interview
        private string _interviewDuration; // date of the interview
        private string _interviewTime; // time of the interview
        private string _interviewLocation; // location of the interview  
        private string _interviewResult; // accepted / rejected

        private Person _person; // the person who was interviewed


        public Interview(int interviewID, string interviewDuration, string interviewTime, string interviewLocation, string interviewResult)
        {
            _interviewID = interviewID;
            _interviewDuration = interviewDuration;
            _interviewTime = interviewTime;
            _interviewLocation = interviewLocation;
            _interviewResult = interviewResult;
        }


        public int InterviewID
        {
            get { return _interviewID; }
            set { _interviewID = value; }
        }
        public string InterviewDuration
        {
            get { return _interviewDuration; }
            set { _interviewDuration = value; }
        }
        public string InterviewTime
        {
            get { return _interviewTime; }
            set { _interviewTime = value; }
        }
        public string InterviewLocation
        {
            get { return _interviewLocation; }
            set { _interviewLocation = value; }
        }
        public string InterviewResult
        {
            get { return _interviewResult; }
            set { _interviewResult = value; }
        }




    }
}
