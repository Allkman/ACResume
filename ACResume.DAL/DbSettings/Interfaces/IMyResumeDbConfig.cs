namespace ACResume.DAL.DbSettings.Interfaces
{
    public interface IMyResumeDbConfig
    {
        string Database_Name { get; set; }
        string MyResume_Collection_Name { get; set; }
        string Connection_String { get; set; }
    }
}
