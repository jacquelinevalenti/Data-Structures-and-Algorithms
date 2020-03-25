using System;
using System.Collections.Generic;
using System.Linq;

namespace HiCal
{
    class Program
    {
        /* original problem: https://www.interviewcake.com/question/csharp/merging-ranges?course=fc1&section=array-and-string-manipulation
         * 
         * Write a method MergeRanges() that takes a list of multiple meeting time ranges and returns a list of condensed ranges.
         * For example, given:
         * [Meeting(0, 1), Meeting(3, 5), Meeting(4, 8), Meeting(10, 12), Meeting(9, 10)]
         * your method would return:
         * [Meeting(0, 1), Meeting(3, 8), Meeting(9, 12)]
         * Do not assume the meetings are in order. The meeting times are coming from multiple teams.
         * Write a solution that's efficient even when we can't put a nice upper bound on the numbers representing our time ranges.
         * Here we've simplified our times down to the number of 30-minute slots past 9:00 am.
         * But we want the method to work even for very large numbers, like Unix timestamps.
         * In any case, the spirit of the challenge is to merge meetings where StartTime and EndTime don't have an upper bound.
         * 
         */
        public static void Main(string[] args)
        {
            var meeting1 = new Meeting(1, 5);  // meeting from 10:00 – 10:30 am
            var meeting2 = new Meeting(2, 3);  // meeting from 12:00 – 1:30 pm
            var meeting3 = new Meeting(8, 10);
            var meeting4 = new Meeting(10, 12);
            var meeting5 = new Meeting(6, 7);
            // 9:00 = 0, 9:30 = 1, 10:00 = 2, 10:30 = 3, etc.
            List<Meeting> meetings = new List<Meeting>();
            meetings.Add(meeting1);
            meetings.Add(meeting2);
            meetings.Add(meeting3);
            meetings.Add(meeting4);
            meetings.Add(meeting5);
            var mergedMeetings = MergeRanges(meetings);
            foreach (Meeting meeting in mergedMeetings)
            {
                Console.WriteLine(meeting);
            }
        }

        public static List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            // sort all meetings by start time
            List<Meeting> sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime)).OrderBy(m => m.StartTime).ToList();

            // walk through meetings and see if they can be combined
            // create a new list of merged meetings
            List<Meeting> mergedMeetings = new List<Meeting>();
            // add the first meeting in sortedmeetings to mergedmeetings
            mergedMeetings.Add(sortedMeetings[0]);
            

            foreach (var meeting in sortedMeetings)
            {
                // store the most recently added meeting in a variable
                var lastMergedMeeting = mergedMeetings.Last();

                if (meeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    if (meeting.EndTime > lastMergedMeeting.EndTime)
                    {
                        lastMergedMeeting.EndTime = meeting.EndTime;
                    }
                }

                else
                {
                    mergedMeetings.Add(meeting);
                }
            }
            return mergedMeetings; 
        }
    }

    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }
}
