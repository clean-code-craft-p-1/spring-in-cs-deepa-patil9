using System;
using System.Collections;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public float average { get; set; }
        public float max { get; set; }
        public float min { get; set; }
    }

    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            var stats = new Stats();
            if (numbers.Count == 0)
            {
                stats.average = float.NaN;
                stats.max = float.NaN;
                stats.min = float.NaN;
            }
            else
            {
                stats.average = numbers.Average();
                stats.max = numbers.Max();
                stats.min = numbers.Min();
            }
            return stats;
        }
    }
}
