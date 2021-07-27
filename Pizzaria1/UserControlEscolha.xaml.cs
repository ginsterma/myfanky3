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

namespace Pizzaria1
{
    /// <summary>
    /// Interação lógica para UserControlEscolha.xam
    /// </summary>
    public partial class UserControlEscolha : UserControl
    {
        Question[] questions = new Question[3];
        Question atMoment;
        public UserControlEscolha()
        {
            InitializeComponent();
            questions[0] = new Question("Was heißt DHCP?", "Dynamtic Host Connect Protocol");
            questions[1] = new Question("Welche Farbe hat der Himmel", "blau");
            questions[2] = new Question("Welche Farbe hat das Gras", "grün");

            atMoment = questions[0];
            txtbl.Text = atMoment.TakeQuestion();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            atMoment = questions[0];
            txtbl.Text = atMoment.TakeAnswer();
        }
    }
    class Question
    {
        string question;
        public string TakeQuestion()
        {
            return question;
        }

        string answer;
        public string TakeAnswer()
        {
            return answer;

        }

        DateTime last;
        int countCorrect = 0;
        int countIncorrect = 0;

        public Question(string qu, string aw)
        {
            question = qu;
            answer = aw;
            last = DateTime.Now;
        }
    }
}
