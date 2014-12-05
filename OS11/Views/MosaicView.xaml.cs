using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using OS11.ViewModel;
using Microsoft.Expression.Media.Effects;
using System.Runtime.InteropServices;
using winform = System.Windows.Forms;


namespace OS11.Views
{
    /// <summary>
    /// Interaction logic for MosaicView.xaml
    /// </summary>
    public partial class MosaicView : System.Windows.Controls.UserControl
    {
        struct ImgProperty
        {
            public double zoom;
            public double X, Y;

            public ImgProperty(double z, double x, double y)
            {
                zoom = z;
                X = x; Y = y;
            }
        };

        public BitmapSource imgCopy;
        private Point origin;
        private Point start;
        private Dictionary<string, ImgProperty> imgList;
        public bool notTornPieceGrid;
        public int doNotSelectImage;
        public string constrPathname;
        public bool sampleOrPrev;
        public string myDocsPath;
        public List<string> prevConstrList;
        public List<string> sampleConstrList;

        public MosaicView()
        {
            InitializeComponent();
            imgList = new Dictionary<string, ImgProperty>();

            myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            constrPathname = "";
            doNotSelectImage = 0;
            sampleOrPrev = false;
            //initializeSamplesAndPrev();

            //openPrevReconstruction.ItemBindingGroup.Items.Add

            TransformGroup group = new TransformGroup();
            ScaleTransform xform = new ScaleTransform();
            group.Children.Add(xform);

            TranslateTransform tt = new TranslateTransform();
            group.Children.Add(tt);

            constrImage.RenderTransform = group;

            //leftRotate.Visibility = Visibility.Hidden;
            //rightRotate.Visibility = Visibility.Hidden;
            //zoom.Visibility = Visibility.Hidden;

            notTornPieceGrid = true;

            //if (OS11.ViewModel.MainViewModel.filepath != "")
            //{
            //    doNotSelectImage = 1;
            //    string filepathTorn = MainViewModel.filepath + "\\torn pieces";
            //    string filepathConstr = MainViewModel.filepath + "\\MosaiQed";
            //    Mouse.SetCursor(Cursors.Wait);
            //    AddButton.Visibility = Visibility.Hidden;
            //    AddFoldersButton.Visibility = Visibility.Hidden;
            //    //string[] pathnames = Directory.GetFiles(filepath, "*.*").Where(file => file.ToLower().EndsWith("aspx") || file.ToLower().EndsWith("ascx"));
            //    List<String> pathnames = Directory.GetFiles(filepathTorn, "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg") || file.ToLower().EndsWith("bmp") || file.ToLower().EndsWith("png")).ToList();
            //    List<String> constrPathnames = Directory.GetFiles(filepathConstr, "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg") || file.ToLower().EndsWith("bmp") || file.ToLower().EndsWith("png")).ToList();
            //    addImagesToList(pathnames);
            //    addConstructedImage(constrPathnames[0]);
            //}
            //Mouse.SetCursor(Cursors.Arrow);
            MosaicItBtn.Visibility = Visibility.Hidden;
        }

        private void addConstructedImage(string pathname)
        {
            
        }

        private void addImagesToList(List<string> pathnames)
        {
            foreach (string pathname in pathnames)
            {
                if ((!pathname.EndsWith("jpg")) && (!pathname.EndsWith("jpeg")) && (!pathname.EndsWith("bmp") && (!pathname.EndsWith("png"))))
                {
                    continue;
                }
                if (imgList.ContainsKey(pathname) == true)
                {
                    continue;
                }
                else
                {
                    try
                    {
                        BitmapImage ba = new BitmapImage(new Uri(pathname));
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                ImgProperty imgproperty = new ImgProperty(1, 0, 0);
                imgList.Add(pathname, imgproperty);

                AddToTornListView(pathname);
            }
            if (imgList.Count > 1 && sampleOrPrev == false)
            {
                MosaicItBtn.Visibility = Visibility.Visible;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Multiselect = true;
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".jpg"; // Default file extension
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png"; // Filter files by extension 

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                Mouse.SetCursor(Cursors.Wait);
                List<string> pathnames = dlg.FileNames.ToList<string>();

                addImagesToList(pathnames);
            }
            Mouse.SetCursor(Cursors.Arrow);
           
        }

        private void AddToTornListView(string pathname)
        {
            if ((!pathname.EndsWith("jpg")) && (!pathname.EndsWith("jpeg")) && (!pathname.EndsWith("bmp") && (!pathname.EndsWith("png"))))
            {
                return;
            }
            try
            {
                BitmapImage ba = new BitmapImage(new Uri(pathname));
            }
            catch (Exception)
            {
                return;
            }

            Grid tornPieceGrid = new Grid();
            //tornPieceGrid.MouseLeftButtonDown += new MouseButtonEventHandler(tornPieceGrid_MouseLeftButtonDown);
            tornPieceGrid.Height = 120;
            tornPieceGrid.Width = 115;
            tornPieceGrid.Tag = pathname;

            UserControl removeButton = new UserControl();
            removeButton.Width = 10;
            removeButton.Height = 10;
            removeButton.Content = "";
            removeButton.BorderThickness = new Thickness(0);
            //removeButton.MouseDown += new MouseButtonEventHandler(removeButton_Click);
            //removeButton.MouseEnter += new MouseEventHandler(remove_MouseEnter);
            //removeButton.MouseLeave += new MouseEventHandler(remove_MouseLeave);
            removeButton.Tag = tornPieceGrid;
            //removeButton.Focus();

            //var brush = new ImageBrush();

            //brush = (ImageBrush)removeImage.Background;
            //removeButton.Background = brush;
            removeButton.HorizontalAlignment = HorizontalAlignment.Right;
            removeButton.VerticalAlignment = VerticalAlignment.Top;
            removeButton.Margin = new Thickness(0, 0, 0, 0);
            tornPieceGrid.Children.Add(removeButton);
            var brush1 = new ImageBrush();
            brush1.ImageSource = new BitmapImage(new Uri(pathname));
            //brush1.Stretch = Stretch.Uniform;
           // tornPieceGrid.Background = brush1;

            InputImageListBox.Items.Add(brush1);
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            Window settingsWin = new settingsWindow();
            
            settingsWin.ShowDialog();
        }
    }
}
