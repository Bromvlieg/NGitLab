﻿namespace NGitLab.Models
{
    using System;

    public class PipelineQuery
    {
        public PipelineScope? Scope { get; set; }
        public JobStatus? Status { get; set; }
        public string Ref { get; set; }
        public string Sha { get; set; }
        public bool? YamlErrors { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public PipelineOrderBy? OrderBy { get; set; }
        public PipelineSort? Sort { get; set; }
    }
}