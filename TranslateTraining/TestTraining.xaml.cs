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
    /// Логика взаимодействия для TestTraining.xaml
    /// </summary>
    public partial class TestTraining : Window
    {
        private int counterWords;
        private int stage;
        public TestTraining()
        {
            InitializeComponent();

            var words = LanguageFiles.GetBaseDictionaryWords();
            //отсюда все настраивается то есть слово на русском и слова для перевода и счетчик и конструктор для принятия счетчика
        }

        private void nextClick(object sender, RoutedEventArgs e)
        {
            
            //if(right){counter++; new TestTraining(counter) }
            //else{new TestTraining(counter) }
        }
    }
}
