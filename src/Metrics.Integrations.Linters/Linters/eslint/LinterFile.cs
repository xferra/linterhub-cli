﻿namespace Metrics.Integrations.Linters.eslint
{
    public class LinterFile : LinterFileModel.File
    {
        public int ErrorCount { get; set; }

        public int WarningCount { get; set; }
    }
}
