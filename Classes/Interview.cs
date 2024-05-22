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
        private string _interviewDate; // date of the interview
        private string _interviewTime; // time of the interview
        private string _interviewLocation; // location of the interview  
        private string _interviewResult; // accepted / rejected

        private Person _person; // the person who was interviewed


        public Interview(int interviewID, string interviewDate, string interviewTime, string interviewLocation, string interviewResult, Person person)
        {
            _interviewID = interviewID;
            _interviewDate = interviewDate;
            _interviewTime = interviewTime;
            _interviewLocation = interviewLocation;
            _interviewResult = interviewResult;
            _person = person;
        }


        public int InterviewID
        {
            get { return _interviewID; }
            set { _interviewID = value; }
        }
        public string InterviewDate
        {
            get { return _interviewDate; }
            set { _interviewDate = value; }
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
        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }




    }
}
