﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate_BusinessObjects;

namespace Candidate_Services
{
    public interface IJobPostingService
    {
        // Get all Job Posting
        public List<JobPosting> GetJobPostings();
        public JobPosting? GetJobPosting(string postingID);
        // Delete Job Posting By ID
        public bool deleteJobPosting(string postingID);
        // Add new Job Posting
        public bool AddJobPosting(JobPosting jobPosting);
        // Update Job Posting
        public bool UpdateJobPosting(JobPosting jobPosting);
    }
}
