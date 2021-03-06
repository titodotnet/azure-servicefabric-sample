﻿using Quartz;
using System;
using System.Reflection;

namespace TimeTriggerService
{
    [JobInfo(CronExpression = "0 0/1 * 1/1 * ? *", Name = "SampleJob2")]
    public class SampleJob2 : IJob
    {
        private ILogger logger;
        public SampleJob2(ILogger loggerParam)
        {
            this.logger = loggerParam;
        }
        public void Execute(IJobExecutionContext context)
        {
            this.logger.WriteLine($"SampleJob2 executed from {Assembly.GetExecutingAssembly().FullName} : {DateTime.Now} .....");
        }
    }
}
