using FieldApp.Helper;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace FieldApp.Model
{
    public class User : INotifyPropertyChanged
    {

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                onPropertyChanged("Id");
            }
        }


        //public string Password {  get; set; }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                onPropertyChanged("Password");
            }
        }

        private string confPassword;
        [Ignore]
        public string ConfPassword
        {
            get { return confPassword; }
            set
            {
                confPassword = value;
                onPropertyChanged("ConfPassword");
            }
        }


        private string email;        

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                onPropertyChanged("Email");
            }
        }

        [MaxLength(8)]
        public string access_token { get; set; }
        public int UserID { get; set; }
        public int ExpiresIn { get; set; }
        public bool FirstLogin { get; set; }
        public String SubscriptionStatus { get; set; }
        public DateTime subscriptionEndDate { get; set; }
        public String UserName { get; set; }
        public bool? IsSystemAdmin { get; set; }



        //functions**********************************************
        public static bool CreateUser(User user)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<User>();
                    int rows = conn.Insert(user);

                    var users = GetUsers();
                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }



        }


        public static async Task<bool> Authenticate(User user)
        {
            try
            {
                var client = new System.Net.Http.HttpClient();
                string encodedusername = System.Net.WebUtility.UrlEncode(user.Email);
                string encodedpassword = System.Net.WebUtility.UrlEncode(user.Password);
                var url = GenerateAuthenticationURL(encodedusername,encodedpassword);

                var response = await client.GetAsync(url);
                string contactsJson = await response.Content.ReadAsStringAsync();

                return true;

                //UserToken TheUserToken = new UserToken();
                //if (contactsJson != "Invalid Username or Password.")
                //{
                //    lblLoading.Text = "Authenticated Successfully";
                //    //Converting JSON Array Objects into generic list  
                //    TheUserToken = JsonConvert.DeserializeObject<UserToken>(contactsJson);
                //    string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "GFARMSQLite.db3");

                //    var db = new SQLiteConnection(dbPath);
                //    db.Insert(TheUserToken);
                //    this.IsLoggedIN = true;
                //    if (loadform == true)
                //    {
                //        form1.Show();
                //    }
                //    else
                //    {


                //        if (result == true)
                //        {
                //            App.Current.MainPage.DisplayAlert("Success", "Data has been loaded successfuly from Server", "Ok");
                //        }
                //    }



                //}
                //else if (contactsJson == "Invalid Username or Password.")
                //{

                //}
            }
            catch (Exception ex)
            {

            }


            return false;

        }

        public static List<User> GetUsers()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    //doesnt matter if table is already created
                    conn.CreateTable<User>();

                    List<User> _users = conn.Table<User>().ToList();

                    return _users;
                }
            }
            catch (Exception ex)
            {
                return new List<User>();
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public static string GenerateAuthenticationURL(string user, string pass)
        {
            string url = string.Format(Constants.FIELD_API + "GET/Authenticate?Username={0}&Password={1}", user, pass);

            return url;
        }

    }
}
