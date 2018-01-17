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
using System.Windows.Shapes;

namespace TranslateTraining
{
    /// <summary>
    /// Логика взаимодействия для TranslateWindow.xaml
    /// </summary>
    public partial class TranslateWindow : Window
    {
        private TextTranslator translator;
        public TranslateWindow()
        {
            InitializeComponent();
            translator = new TextTranslator();
            foreach(var language in translator.GetLanguages())
            {
                languageFrom.Items.Add(language);
                languageTo.Items.Add(language);
            }
        }

        private void TranslateTextButtonClick(object sender, RoutedEventArgs e)
        {
            string text;
            TextRange reader = new TextRange(textToTranslate.Document.ContentStart, textToTranslate.Document.ContentEnd);
            text = reader.Text;
            if (text != null)
            {
                if(languageFrom.SelectedItem!=null && languageTo.SelectedItem != null)
                {
                    translatedText.Text = translator.Translate(text,translator.GetLangPair(languageFrom.SelectedItem as string,languageTo.SelectedItem as string));
                }
            }
        }

        private void ReplaceLanguagesButtonClick(object sender, RoutedEventArgs e)
        {
           if (languageFrom.SelectedItem != null && languageTo.SelectedItem != null)
            {
                string language = languageFrom.SelectedItem as string;
                languageFrom.SelectedItem = languageTo.SelectedItem;
                languageTo.SelectedItem = language;
            }
        }
    }
}
