namespace GPSoft.GPMagic.GPMagicBase.Model.Setting
{
    public interface ISetting
    {
        void Save();
        void Reload();
        void RestoreToDefault();
    }
}
