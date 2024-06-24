using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Widget;
using Xamarin.Essentials;
//using System.Drawing;
using System.Net;
using Android.Graphics;
using Java.Security.Interfaces;
using Android.Content;


namespace SOAP_Mobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView text1;
        Button btnSubmit;
        EditText edit1;
        ImageView imgView1;
        int score;
        private static Random _random = new Random();

        private string currentQuestion;
        CountryCodes cc;
        string[] countryCodes;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            score = 0;
            cc = new CountryCodes();
            countryCodes = cc.GetCountryCodes();
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            btnSubmit = FindViewById<Button>(Resource.Id.button1);
            btnSubmit.Click += BtnSubmitOnClick;

            text1 = FindViewById<TextView>(Resource.Id.textView1);
            edit1 = FindViewById<EditText>(Resource.Id.editText1);
            imgView1 = FindViewById<ImageView>(Resource.Id.imageView1);
            text1.Text = "Score: " + score.ToString();
            GameRound();
        }

        private void GameRound()
        {

            int randomNumber = GenerateRandomNumber(0, countryCodes.Length);
            var client = new CountryInfoService.CountryInfoService();

            string flagUrl = client.CountryFlag(countryCodes[randomNumber]);

            var imageBitmap = GetImageBitmapFromUrl(flagUrl);
            imgView1.SetImageBitmap(imageBitmap);
            currentQuestion = countryCodes[randomNumber];


        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void BtnSubmitOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            

            if (cc.CheckAnswer(edit1.Text.ToUpper(), currentQuestion))
            {
                score++;
                DisplayToast("Correct");
            }
            else
            {
                DisplayToast("Wrong");
            }
            text1.Text = "Score: " + score.ToString();
            GameRound();

            //com.daehosting.webservices.TemperatureConversions tempC = new com.daehosting.webservices.TemperatureConversions();

        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }

        private void DisplayToast(string msg)
        {
            Context context = Application.Context;
            //string text = "Hello toast!";
            ToastLength duration = ToastLength.Short;

            var toast = Toast.MakeText(context, msg, duration);
            toast.Show();
        }


        // Method to generate a random number within a specified range
        public static int GenerateRandomNumber(int min, int max)
        {
            // Ensure that min is less than or equal to max
            if (min > max)
            {
                throw new ArgumentException("min should be less than or equal to max");
            }

            return _random.Next(min, max + 1); // max + 1 because Next upper bound is exclusive
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}
