﻿namespace template_dotnet6_api.Configurations
{
    public class QuartzSetting
    {
        public bool EnableQuartz { get; set; }
        public Dictionary<string, string> Jobs { get; set; }
    }
}