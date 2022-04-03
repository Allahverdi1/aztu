using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class MeetingSchedule
    {
        List<Meeting> _meetingList = new List<Meeting>();
        
        
        public  bool IsExistsMeetingByName(string str)
        {
            foreach (var item in _meetingList)
            {
                if(item.Name.Contains(str))
                {
                    return true;
                }
            }
            return false;
        }

        public void SetMeeting(Meeting meeting)
        {
            _meetingList.Add(meeting);
            if ((_meetingList.Contains(meeting.FullName) && _meetingList.Contains(meeting.From));
            {

                throw new AlreadyExsitsException("var");
            }

        }

















    }
}
