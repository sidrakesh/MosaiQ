using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OS11
{
    /// <summary>
    /// Interaction logic for statisticsWindow.xaml
    /// </summary>
    public partial class statisticsWindow : Window
    {
        public statisticsWindow()
        {
            InitializeComponent();
            numRunsTextBox.Text = ""+OS11.Properties.Settings.Default.numRuns;
            totalRunTimeTextBox.Text = "" + OS11.Properties.Settings.Default.totalRunTime;
            avgRunTimeTextBox.Text = "" + OS11.Properties.Settings.Default.avgRunTime;
            lastRunTimeTextBox.Text = "" + OS11.Properties.Settings.Default.lastRunTime;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            OS11.Properties.Settings.Default.numRuns = 0;
            TimeSpan ts = new TimeSpan(0);

            OS11.Properties.Settings.Default.totalRunTime = ts;
            OS11.Properties.Settings.Default.avgRunTime = ts;
            OS11.Properties.Settings.Default.lastRunTime = ts;

            OS11.Properties.Settings.Default.Save();

            numRunsTextBox.Text = "" + OS11.Properties.Settings.Default.numRuns;
            totalRunTimeTextBox.Text = "" + OS11.Properties.Settings.Default.totalRunTime;
            avgRunTimeTextBox.Text = "" + OS11.Properties.Settings.Default.avgRunTime;
            lastRunTimeTextBox.Text = "" + OS11.Properties.Settings.Default.lastRunTime;
        }
    }
}
