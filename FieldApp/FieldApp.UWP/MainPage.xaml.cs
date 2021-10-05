using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace FieldApp.UWP
{
    public sealed partial class MainPage
    {

        public const SQLite.SQLiteOpenFlags Flags =
                // open the database in read/write mode
                SQLite.SQLiteOpenFlags.ReadWrite |
                // create the database if it doesn't exist
                SQLite.SQLiteOpenFlags.Create |
                // enable multi-threaded database access
                SQLite.SQLiteOpenFlags.SharedCache;
        public MainPage()
        {
            this.InitializeComponent();


            string _dbLocation = "Agtech360.sqlite";
            string _path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string _fullpath = Path.Combine(_path, _dbLocation);



            LoadApplication(new FieldApp.App(_fullpath));
            //LoadApplication(new FieldApp.App());
        }
    }
}
