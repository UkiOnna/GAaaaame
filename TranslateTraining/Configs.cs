using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TranslateTraining
{
    public static class Configs
    {
        public const string DIRECTORY_NAME = "TranslatorFiles";

        public const string BASE_DICTIONARY_FILENAME = "BaseDictionary.txt";
        public const string LEARNED_WORDS_FILENAME = "LearnedWords.txt";
        public const string NOT_LEARNED_WORDS_FILENAME = "NotLearnedWords.txt";

        public static string UsedDrive { get; set; }
        public static string PathToDirectory { get; set; }

        public static string BaseDictionaryFile { get; set; }
        public static string PathToLearnedWordsFile { get; set; }
        public static string PathToNotLearnedWordsFile { get; set; }

        private static bool HasWriteAccessToFolder(string folderPath)
        {
            try
            {
                // Attempt to get a list of security permissions from the folder. 
                // This will raise an exception if the path is read only or do not have access to view the permissions. 
                System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }
        private static bool SetAutorunValue(bool autorun)
        {
            string name = AppDomain.CurrentDomain.FriendlyName;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, Directory.GetCurrentDirectory() + name);
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        private static void InstallMeOnStartUp()
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                Assembly curAssembly = Assembly.GetExecutingAssembly();
                key.SetValue(curAssembly.GetName().Name, curAssembly.Location);
            }
            catch { }
        }

        public static void InitFiles()
        {
            foreach(var drive in DriveInfo.GetDrives())
            {
                if (HasWriteAccessToFolder(drive.Name))
                {
                    UsedDrive = drive.Name;
                    break;
                }
            }

            if (!Directory.Exists(UsedDrive + @"\" + DIRECTORY_NAME))
            {
                Directory.CreateDirectory(UsedDrive + @"\" + DIRECTORY_NAME);
            }
            PathToDirectory = UsedDrive + @"\" + DIRECTORY_NAME;

            if (!File.Exists(PathToDirectory + @"\" + BASE_DICTIONARY_FILENAME))
            {
                File.Copy(Directory.GetCurrentDirectory() + @"\" + BASE_DICTIONARY_FILENAME, PathToDirectory + @"\" + BASE_DICTIONARY_FILENAME);
            }
            BaseDictionaryFile = PathToDirectory + @"\" + BASE_DICTIONARY_FILENAME;
            if (!File.Exists(PathToDirectory + @"\" + LEARNED_WORDS_FILENAME))
            {
                File.Create(PathToDirectory + @"\" + LEARNED_WORDS_FILENAME);
            }
            PathToLearnedWordsFile = PathToDirectory + @"\" + LEARNED_WORDS_FILENAME;
            if (!File.Exists(PathToNotLearnedWordsFile + @"\" + NOT_LEARNED_WORDS_FILENAME))
            {
                File.Copy(BaseDictionaryFile,PathToDirectory + @"\" + NOT_LEARNED_WORDS_FILENAME);
            }
            PathToNotLearnedWordsFile = PathToDirectory + @"\" + NOT_LEARNED_WORDS_FILENAME;
        }
    }
}
