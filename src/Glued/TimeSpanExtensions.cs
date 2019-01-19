using System;

namespace Glued
{
    public static class TimeSpanExtensions
    {
        public static TimeSpan Second(this int value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this int value)
        {
            return TimeSpan.FromSeconds(value);
        }
    }
}
