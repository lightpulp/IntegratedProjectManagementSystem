using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Staff
{

    public static class TimerManager
    {
        public class TimerEntry
        {
            public DateTime TimeIn { get; set; }
            public System.Windows.Forms.Timer Timer { get; set; }
        }

        private static readonly Dictionary<int, TimerEntry> ActiveTimers =
            new Dictionary<int, TimerEntry>();

        // --------------------------
        // SAFE START (always creates entry)
        // --------------------------
        public static void StartTimer(int empId)
        {
            // Overwrite if exists (safe)
            if (ActiveTimers.ContainsKey(empId))
            {
                ActiveTimers[empId].Timer.Stop();
                ActiveTimers.Remove(empId);
            }

            ActiveTimers[empId] = new TimerEntry
            {
                TimeIn = DateTime.Now,
                Timer = new System.Windows.Forms.Timer() { Interval = 1000 }
            };

            ActiveTimers[empId].Timer.Start();
        }

        // --------------------------
        // Check if employee has an active timer
        // --------------------------
        public static bool HasActiveTimer(int empId)
        {
            return ActiveTimers.ContainsKey(empId);
        }

        // --------------------------
        // SAFE GET Stored Time In
        // --------------------------
        public static DateTime GetTimeIn(int empId)
        {
            if (!ActiveTimers.ContainsKey(empId))
                return DateTime.MinValue; // prevents crash

            return ActiveTimers[empId].TimeIn;
        }

        // --------------------------
        // SAFE ELAPSED TIME
        // --------------------------
        public static TimeSpan GetElapsed(int empId)
        {
            if (!ActiveTimers.ContainsKey(empId))
                return TimeSpan.Zero; // prevents crash

            return DateTime.Now - ActiveTimers[empId].TimeIn;
        }

        // --------------------------
        // SAFE STOP
        // --------------------------
        public static void StopTimer(int empId)
        {
            if (ActiveTimers.ContainsKey(empId))
            {
                ActiveTimers[empId].Timer.Stop();
                ActiveTimers.Remove(empId);
            }
        }
    }
}
