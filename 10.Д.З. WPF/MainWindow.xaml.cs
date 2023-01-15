using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
using Example_1051;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

   
    public partial class MainWindow : Window
    {

        string[] splitString { get; set; }
        string stringReplace;

        public MainWindow()
        {
            InitializeComponent();            
        } 

        private void btnClickSplit(object sender, RoutedEventArgs e)
        {
            splitString = Program.GetArrayOfUserString(txtStringSplit.Text);
            
            logListSplit.ItemsSource = splitString;           
                      
   
            logListSplit.Items.Refresh();                      
        }
        private void btnClickReplace(object sender, RoutedEventArgs e)
        {

            stringReplace = Program.ReverseWords(txtStringReplace.Text);

            LabelReplace.Content = stringReplace;
        }

    }


    class Program
    {       

        /// <summary>
        /// Метод разделения пользовательского текста в массив
        /// </summary>
        /// <param name="userString">первое число</param>
        public static string[] GetArrayOfUserString(string userString)
        {
            string[] array = userString.Split(' ');
            return array;
        }

        public static string ReverseWords(string userString)
        {
            string reverseString = null;
            string[] array1 = GetArrayOfUserString(userString);
            int k = 1;
            for (int i = 0; i < array1.Length; i++)
            {
                if (i > array1.Length - k)
                {
                    break;
                }
                else
                {
                    string temp = array1[i];                    //создал переменную для промежуточного хранения значения
                    array1[i] = array1[array1.Length - k];      //поменял местами текущую с противоположной
                    array1[array1.Length - k] = temp;
                    k++;
                }
            }
            for (int i = 0; i < array1.Length; i++)
            {
                reverseString = reverseString + " " + array1[i];                
            }

            return reverseString;
        }
    }
}
