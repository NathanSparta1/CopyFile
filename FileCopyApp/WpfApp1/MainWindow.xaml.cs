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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        
        public string DestinationPath2 { get; set; }
        public string DestinationPath3 { get; set; }
        public string DestinationPath4 { get; set; }

       

        public MainWindow()
        {
            InitializeComponent();
        }


        private void ClearBTNClick(object sender, RoutedEventArgs e)
        {
            FileNameTB.Text = "";
            SourceTB.Text = "";
            DestinationTB.Text = "";
            DestinationTB2.Text = "";
            DestinationTB3.Text = "";
            DestinationTB4.Text = "";
            
        }

        private void Destination1BTNClick(object sender, RoutedEventArgs e)
        {

            SourcePath = System.IO.Path.Combine(SourceTB.Text, FileNameTB.Text);
            DestinationPath = System.IO.Path.Combine(DestinationTB.Text, FileNameTB.Text);

            

            if (System.IO.Directory.Exists(SourceTB.Text) == true && System.IO.Directory.Exists(DestinationTB.Text) == true
                && System.IO.File.Exists(SourcePath))
            {
                if (SourcePath != DestinationPath)
                {

                    File.Copy(SourcePath, DestinationPath, true);
                    MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied");
                }

            }

            else if (System.IO.File.Exists(SourcePath) == false)
            {
                MessageBox.Show("File or source path doesnt exist :(");
            }

            else if(System.IO.Directory.Exists(SourceTB.Text) == false)
            {
                MessageBox.Show("Source Path doesnt exist :(");
            }

            else if (System.IO.Directory.Exists(DestinationTB.Text) == false)
            {
                MessageBox.Show("Destination Path doesnt exist :(");
            }
            else
            {
                MessageBox.Show("Copy unsuccessful, check entry again");
            }





            
        }
        
                private void Destination2Copy(object sender, RoutedEventArgs e)
                {
                    SourcePath = System.IO.Path.Combine(SourceTB.Text, FileNameTB.Text);
                    DestinationPath = System.IO.Path.Combine(DestinationTB2.Text, FileNameTB.Text);

                    if (System.IO.Directory.Exists(SourceTB.Text) == true && System.IO.Directory.Exists(DestinationTB2.Text) == true
                       && System.IO.File.Exists(SourcePath))
                    {
                     if (SourcePath != DestinationPath)
                        {
                        File.Copy(SourcePath, DestinationPath, true);
                        MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied");
                        }
                    }

                    else if (System.IO.File.Exists(SourcePath) == false)
                    {
                        MessageBox.Show("File or source path doesnt exist :(");
                    }

                    else if (System.IO.Directory.Exists(SourceTB.Text) == false)
                    {
                        MessageBox.Show("Source Path doesnt exist :(");
                    }

                    else if (System.IO.Directory.Exists(DestinationTB2.Text) == false)
                    {
                        MessageBox.Show("Destination Path doesnt exist :(");
                    }
            else
            {
                MessageBox.Show("Copy unsuccessful, check entry again");
            }

            
                }

          private void Destination3Copy(object sender, RoutedEventArgs e)
          {
                    SourcePath = System.IO.Path.Combine(SourceTB.Text, FileNameTB.Text);
                    DestinationPath = System.IO.Path.Combine(DestinationTB3.Text, FileNameTB.Text);

            if (System.IO.Directory.Exists(SourceTB.Text) == true && System.IO.Directory.Exists(DestinationTB3.Text) == true
               && System.IO.File.Exists(SourcePath))
            {
                if (SourcePath != DestinationPath)
                {
                    File.Copy(SourcePath, DestinationPath, true);
                    MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied");
                }
            }

            else if (System.IO.File.Exists(SourcePath) == false)
            {
                MessageBox.Show("File or source path doesnt exist :(");
            }

            else if (System.IO.Directory.Exists(SourceTB.Text) == false)
            {
                MessageBox.Show("Source Path doesnt exist :(");
            }

            else if (System.IO.Directory.Exists(DestinationTB3.Text) == false)
            {
                MessageBox.Show("Destination Path doesnt exist :(");
            }
            
            else
            {
                MessageBox.Show("Copy unsuccessful, check entry again");
            }

                
          }

        private void Destination4Copy(object sender, RoutedEventArgs e)
        {
            SourcePath = System.IO.Path.Combine(SourceTB.Text, FileNameTB.Text);
            DestinationPath = System.IO.Path.Combine(DestinationTB4.Text, FileNameTB.Text);

            if (System.IO.Directory.Exists(SourceTB.Text) == true && System.IO.Directory.Exists(DestinationTB4.Text) == true
               && System.IO.File.Exists(SourcePath))
            {
                if (SourcePath != DestinationPath)
                {
                    File.Copy(SourcePath, DestinationPath, true);
                    MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied");
                }
            }

            else if (System.IO.File.Exists(SourcePath) == false)
            {
                MessageBox.Show("File doesnt exist :(");
            }

            else if (System.IO.Directory.Exists(SourceTB.Text) == false)
            {
                MessageBox.Show("Source Path doesnt exist :(");
            }

            else if (System.IO.Directory.Exists(DestinationTB4.Text) == false)
            {
                MessageBox.Show("Destination Path doesnt exist :(");
            }

            else
            {
                MessageBox.Show("Copy unsuccessful, check entry again");
            }

            
        }

        private void CopyAllBTNClick(object sender, RoutedEventArgs e)
        {
            SourcePath = System.IO.Path.Combine(SourceTB.Text, FileNameTB.Text);
            DestinationPath = System.IO.Path.Combine(DestinationTB.Text, FileNameTB.Text);
            DestinationPath2 = System.IO.Path.Combine(DestinationTB2.Text, FileNameTB.Text);
            DestinationPath3 = System.IO.Path.Combine(DestinationTB3.Text, FileNameTB.Text);
            DestinationPath4 = System.IO.Path.Combine(DestinationTB4.Text, FileNameTB.Text);

            if (System.IO.Directory.Exists(SourceTB.Text) == true && System.IO.File.Exists(SourcePath))
            {
                if (SourcePath != DestinationPath || SourcePath != DestinationPath2 || SourcePath != DestinationPath3 || SourcePath != DestinationPath4)
                {
                    if (System.IO.Directory.Exists(DestinationTB.Text) == true)
                    {
                        File.Copy(SourcePath, DestinationPath, true);
                        MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied to " + $"{DestinationTB.Text}");
                    }
                    if (System.IO.Directory.Exists(DestinationTB2.Text) == true)
                    {
                        File.Copy(SourcePath, DestinationPath2, true);
                        MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied to " + $"{DestinationTB2.Text}");
                    }
                    if (System.IO.Directory.Exists(DestinationTB3.Text) == true)
                    {
                        File.Copy(SourcePath, DestinationPath3, true);
                        MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied to " + $"{DestinationTB3.Text}");
                    }

                    if (System.IO.Directory.Exists(DestinationTB4.Text) == true) 
                    {
                        File.Copy(SourcePath, DestinationPath4, true);
                        MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied to " + $"{DestinationTB4.Text}");
                    }

                    

                    //MessageBox.Show($"{FileNameTB.Text}" + " " + "Succefully Copied to all Destinations");
                }
            }

            else if (System.IO.File.Exists(SourcePath) == false)
            {
                MessageBox.Show("File or source path doesnt exist :(");
            }

            else if (System.IO.Directory.Exists(SourceTB.Text) == false)
            {
                MessageBox.Show("Source Path doesnt exist :(");
            }

            else if (System.IO.Directory.Exists(DestinationTB4.Text) == false
                || System.IO.Directory.Exists(DestinationTB3.Text) == false
                || System.IO.Directory.Exists(DestinationTB2.Text) == false
                || System.IO.Directory.Exists(DestinationTB.Text) == false)
            {
                MessageBox.Show("One of the Destination Paths doesnt exist :(");
            }

            else
            {
                MessageBox.Show("Copy unsuccessful, check entry again");
               
            }

                
            }

        
        private void CopyFilesToAll(object sender, RoutedEventArgs e)
        {
            SourcePath = System.IO.Path.Combine(SourceTB.Text, FileNameTB.Text);

            DirectoryInfo sourceDir = new DirectoryInfo(SourcePath);
            DirectoryInfo[] dirs = sourceDir.GetDirectories();
            

            if (Directory.Exists(SourcePath))
            {
                string[] files = Directory.GetFiles(SourcePath);

                
                
                foreach(string s in files)
                {
                    string fileName = System.IO.Path.GetFileName(s);

                    DestinationPath = System.IO.Path.Combine(DestinationTB.Text, fileName);
                    DestinationPath2 = System.IO.Path.Combine(DestinationTB2.Text, fileName);
                    DestinationPath3 = System.IO.Path.Combine(DestinationTB3.Text, fileName);
                    DestinationPath4 = System.IO.Path.Combine(DestinationTB4.Text, fileName);

                    if (Directory.Exists(DestinationTB.Text) == true) { File.Copy(s, DestinationPath, true); }

                    if (Directory.Exists(DestinationTB2.Text) == true) { File.Copy(s, DestinationPath2, true);  }
                    
                    if (Directory.Exists(DestinationTB3.Text) == true) { File.Copy(s, DestinationPath3, true); }

                    if (Directory.Exists(DestinationTB4.Text) == true) { File.Copy(s, DestinationPath4, true); }


                }
                
                //string[] folder = Directory.GetDirectories(SourcePath);

           // copy sub directories too
           
/*
                foreach (DirectoryInfo subDir  in dirs)
                {
                    string folderName = System.IO.Path.GetDirectoryName(subDir.Name);

                    DestinationPath = System.IO.Path.Combine(DestinationTB.Text, folderName);
                    DestinationPath2 = System.IO.Path.Combine(DestinationTB.Text, folderName);
                    DestinationPath3 = System.IO.Path.Combine(DestinationTB.Text, folderName);
                    DestinationPath4 = System.IO.Path.Combine(DestinationTB.Text, folderName);

                    //Directory.CreateDirectory(SourcePath);

                    

                    

                    string tempPath = System.IO.Path.Combine(DestinationTB.Text, subDir.Name);
                    string tempPath2 = System.IO.Path.Combine(DestinationTB2.Text, subDir.Name);
                    string tempPath3 = System.IO.Path.Combine(DestinationTB3.Text, subDir.Name);
                    string tempPath4 = System.IO.Path.Combine(DestinationTB4.Text, subDir.Name);

                    //File.Copy(subDir.FullName,tempPath,true);


    

                    

                }
*/

                MessageBox.Show("Done");

            }
            else 
            { 
                MessageBox.Show("Copy failed, check entries are correct");
                
            }
        }
        
    }

}


