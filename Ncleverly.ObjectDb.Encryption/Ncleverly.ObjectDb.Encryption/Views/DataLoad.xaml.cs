using Ncleverly.ObjectDb.Encryption.Models;
using Ncleverly.ObjectDb.Encryption.Services;
using Realms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ncleverly.ObjectDb.Encryption.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataLoad : ContentPage
    {
        Realm RealmInstance;
        bool firstLoad = true;
        public DataLoad()
        {
            InitializeComponent();
            RealmInstance = Realm.GetInstance();
            Results.Text += "This will change to show the recieved and written data" + Environment.NewLine;
    }

        async void LoadDataClicked(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                Results.Text = "";
                firstLoad = false;
            }

            Results.Text += "Starting to get new Users" + Environment.NewLine;


            var userService = new RandomUsersService();

            var userResult = await userService.GetRandomUsers();
            Results.Text += $"Got {userResult.Results.Count()} Users" + Environment.NewLine;

            Stopwatch watch = new Stopwatch();
            watch.Start();
            RealmInstance.Write(() =>
            {
                var peopleBefore = RealmInstance.All<Result>();
                Results.Text += $" curr Before save DB Total Users: {peopleBefore.Count()}"+Environment.NewLine;
                
                foreach (var user in userResult.Results)
                {
                    if(peopleBefore.Any(x=>x.Email == user.Email))
                    {
                        RealmInstance.Add(user, update: true);
                    }
                    RealmInstance.Add(user);
                }
            });
            watch.Stop();
            Results.Text += $"Total Time to write: {watch.ElapsedMilliseconds} ms" + Environment.NewLine;
            var people = RealmInstance.All<Result>();
            Results.Text +=  $" curr DB Total Users: {people.Count()}" + Environment.NewLine;

        }
    }
}