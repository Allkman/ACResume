using ACResume.DAL.DbSettings.Interfaces;

namespace ACResume.DAL.DbSettings
{
    public class MyResumeDbConfig : IMyResumeDbConfig
    {
        public string Database_Name { get; set; }
        public string MyResume_Collection_Name { get; set; }
        public string Connection_String { get; set; }
    }
}
