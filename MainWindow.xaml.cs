using System;
using System.Windows;

namespace JustPrice
{
    public partial class MainWindow : Window
    {
        

        private void Verification()
        {
            

            if (UserNumber(Int32.Parse(UserBoxNumber.Text)) < numberWin)
            {
                Answer.Text = "C'est plus grand";
                return;
            }
            else if (UserNumber(Int32.Parse(UserBoxNumber.Text)) > numberWin)
            {
                Answer.Text = "C'est plus petit";
                return;
            }
            else if (UserNumber(Int32.Parse(UserBoxNumber.Text)) == numberWin)
            {
                Answer.Text = "VOUS AVEZ REUSSI";
                return;
            }
            else
            {
                Answer.Text = "ERREUR";
            }

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            NumberWin.Content = numberWin;
            Verification();

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private static readonly Random rnd = new Random();

        public static int RandomNumber()
        {
            return rnd.Next(1, 50);
        }

        private int numberWin = RandomNumber();


        public int UserNumber(int nbUser)
        {
            int nbUserBox;
            nbUserBox = Int32.Parse(UserBoxNumber.Text);
            return nbUserBox;
        }
    }
}
