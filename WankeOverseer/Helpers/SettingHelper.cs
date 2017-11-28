using System;
using System.Diagnostics;
using WankeOverseer.Entities;
using System.IO;
using System.Text;

namespace WankeOverseer.Helpers
{
    public class SettingHelper
    {
        internal static string settingPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\wankeoverseer-settings.ini";
        public static void WriteSettings(WankeSettings settings, string password)
        {
            try
            {
                string json = JsonHelper.Serialize(settings);
                var wSettings = EncryptHelper.EncryptRC4(json, password);
                Debug.WriteLine("WriteSettings " + json);
                File.WriteAllText(settingPath, wSettings, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public static WankeSettings ReadSettings(string password)
        {
            try
            {
                var txt = File.ReadAllText(settingPath, Encoding.UTF8);
                var json = EncryptHelper.DecryptRC4(txt, password);
                Debug.WriteLine("ReadSettings " + json);
                var wSettings = JsonHelper.Deserialize<WankeSettings>(json);
                return wSettings;
            }
            catch
            {
                return null;
            }
        }
        public static bool ExistSettings()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\wankeoverseer-settings.ini";
                Debug.WriteLine(path);
                return File.Exists(path);
            }
            catch
            {
                return false;
            }
        }
        public static bool DeleteSettings()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\wankeoverseer-settings.ini";
                File.Delete(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static WankeSettings ReadOldSettings()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\imt-wanke-settings.ini";
                var txt = System.IO.File.ReadAllText(path);
                var json = EncryptHelper.DecryptDES(txt, "hahasetr");
                Debug.WriteLine("ReadSettings " + json);
                var wSettings = JsonHelper.Deserialize<WankeSettings>(json);
                return wSettings;
            }
            catch
            {
                return null;
            }
        }
        public static bool DeleteOldSettings()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\imt-wanke-settings.ini";
                File.Delete(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
