namespace Metrics.Integrations.Linters.Phpmetrics
{
    using System;
    using System.Collections.Generic;

    public class LintResult : ILinterResult, ILinterModel
    {
        public List<File> FilesList { get; set; }
    }
}