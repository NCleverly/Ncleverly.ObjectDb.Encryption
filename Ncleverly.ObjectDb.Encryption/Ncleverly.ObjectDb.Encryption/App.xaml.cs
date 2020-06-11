using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ncleverly.ObjectDb.Encryption.Services;
using Ncleverly.ObjectDb.Encryption.Views;
using System.Security.Cryptography;
using Realms;
using Xamarin.Essentials;

namespace Ncleverly.ObjectDb.Encryption
{
    public partial class App : Application
    {
        public Realm RealmInstance;

        public App()
        {
            InitializeComponent();

            //guidance fro sqlcipher creator.
            //https://discuss.zetetic.net/t/sqlcipher-performance-optimization/14

            if (string.IsNullOrWhiteSpace(SecureStorage.GetAsync("storagekey").Result))
            {
                var bytes = new byte[64]; // byte size
                using (var crypto = new RNGCryptoServiceProvider())
                    crypto.GetBytes(bytes);

                SecureStorage.SetAsync("storagekey",Convert.ToBase64String(bytes)).Wait();

                var config = new RealmConfiguration("Mine.realm");
                config.EncryptionKey = bytes;
                RealmInstance = Realm.GetInstance(config);  // will create/open encrypted realm "Mine.realm"
            }
            MainPage = new DataLoad();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
