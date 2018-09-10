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

namespace BookingSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            PerformGeneralApplicationSetup();
            InitializeComponent();
        }

        /// <summary>
        /// Actions to perform before the visual loading of the application
        /// </summary>
        public void PerformGeneralApplicationSetup()
        {

        }

        #region Button Clicks
        /// <summary>
        /// Opens a new NewGameWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Opens a new LoadGameWindow 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Opens a new EditModeWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMode_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Closes the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        /// <summary>
        /// Actions performed upon closing of this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowClosing_Event(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show($"Why you no wanna book no more?", $"Click OK to Exit", MessageBoxButton.OK);
        }
    }


}
