using System.IO;

namespace TranslateTraining
{
    public static class LanguageFiles
    {
        public static string[] GetBaseDictionaryWords() => File.ReadAllLines(Configs.BaseDictionaryFile);

        public static string[] GetLearnedWords() => File.ReadAllLines(Configs.PathToLearnedWordsFile);
        public static string[] GetNotLearnedWords() => File.ReadAllLines(Configs.PathToNotLearnedWordsFile);

        public static int GetWordsCount(string path) => File.ReadAllLines(path).Length;

        public static void ReSaveFile(string path,string[] words)
        {
            File.WriteAllLines(path,words);
        }
    }
}
