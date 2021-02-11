using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public static class TempStorage
    {
        private static List<Submissions> submissions = new List<Submissions>();
        public static IEnumerable<Submissions> Submissions => submissions;
        public static void AddSubmission(Submissions submission)
        {
            submissions.Add(submission);
        }
    }
}
