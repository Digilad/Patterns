using System;
using System.Collections.Generic;

namespace Patterns.Behavioural
{
    /// <summary>
    /// Observer
    /// Наблюдатель
    /// https://proglib.io/p/behavioral-patterns/
    /// </summary>

    public class Observer
    {
        public void Using()
        {
            var john = new JobSeeker("John");
            var jane = new JobSeeker("Jane");
            var jobPosting = new JobPosting();
            jobPosting.Attach(john);
            jobPosting.Attach(jane);
            jobPosting.AddJob(new JobPost("Developer"));
            jobPosting.AddJob(new JobPost("Tester"));
        }
    }

    public class JobPost
    {
        string title;

        public JobPost(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }
    }

    public class JobSeeker
    {
        string name;

        public JobSeeker(string name)
        {
            this.name = name;
        }

        public void OnJobPosted(JobPost job)
        {
            Console.WriteLine($"Hello {name}. The new job offer: {job.GetTitle()}");
        }
    }

    public class JobPosting
    {
        List<JobSeeker> jobSeekers = new List<JobSeeker>();

        private void Notify(JobPost jobPosting)
        {
            foreach(var jobSeeker in jobSeekers)
            {
                jobSeeker.OnJobPosted(jobPosting);
            }
        }

        public void Attach(JobSeeker jobSeeker)
        {
            jobSeekers.Add(jobSeeker);
        }

        public void AddJob(JobPost jobPosting)
        {
            Notify(jobPosting);
        }
    }
}
