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
using Android.Bluetooth;
using System.Collections.Generic;
using System.Linq;


namespace SOAP_Mobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView text1;
        Button btnSubmit, btnSubmit2, btnSubmit3;
        EditText edit1;
        ImageView imgView1;
        int score;
        private static Random _random = new Random();

        private string currentQuestion;
        CountryCodes cc;
        string[] countryCodes;
        Button[] btnChoices;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            btnChoices = new Button[3];
            score = 0;
            cc = new CountryCodes();
            countryCodes = cc.GetCountryCodes();
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            btnSubmit = FindViewById<Button>(Resource.Id.button1);
            btnSubmit2 = FindViewById<Button>(Resource.Id.button2);
            btnSubmit3 = FindViewById<Button>(Resource.Id.button3);

            btnSubmit.Click += BtnSubmitOnClick;
            btnSubmit2.Click += BtnSubmitOnClick;
            btnSubmit3.Click += BtnSubmitOnClick;
            btnChoices[0] = btnSubmit;
            btnChoices[1] = btnSubmit2;
            btnChoices[2] = btnSubmit3;

            text1 = FindViewById<TextView>(Resource.Id.textView1);
            edit1 = FindViewById<EditText>(Resource.Id.editText1);
            imgView1 = FindViewById<ImageView>(Resource.Id.imageView1);
            text1.Text = "Score: " + score.ToString();

            // Find the Exit button
            Button exitButton = FindViewById<Button>(Resource.Id.exitButton);

            // Set up the click event handler
            exitButton.Click += (sender, e) =>
            {
                // Exit the app
                Finish();
            };

            GameRound();
        }

        private void GameRound()
        {

            string[] choices = new string[3];
            int randomNumber = GenerateRandomNumber(0, countryCodes.Length);
            var client = new CountryInfoService.CountryInfoService();

            string flagUrl = client.CountryFlag(countryCodes[randomNumber]);

            var imageBitmap = GetImageBitmapFromUrl(flagUrl);
            imgView1.SetImageBitmap(imageBitmap);
            currentQuestion = countryCodes[randomNumber];
            var randomNumber2 = 0;

            //var test = client.ListOfCountryNamesByCode();
            ////Console.WriteLine(String.Join(" ", test.ToArray()));

            choices[0] = client.CountryName(currentQuestion);
            do
            {
                randomNumber = GenerateRandomNumber(0, countryCodes.Length);
                choices[1] = client.CountryName(countryCodes[randomNumber]);
                randomNumber2 = GenerateRandomNumber(0, countryCodes.Length);
                choices[2] = client.CountryName(countryCodes[randomNumber2]);

            } while (countryCodes[randomNumber] == currentQuestion || countryCodes[randomNumber2] == currentQuestion || countryCodes[randomNumber2] == countryCodes[randomNumber]);
          

            ArrayShuffler.Shuffle(choices);

            int i = 0;
            foreach (Button btn in btnChoices)
            {
                btn.Text = choices[i];
                i++;
            }
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
            var obj = (Button)sender;

            if (cc.CheckAnswer(obj.Text.ToUpper(), currentQuestion))
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
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;
            byte[] imageBytes = null;
            using (var webClient = new WebClient())
            {
                try
                {
                    imageBytes = webClient.DownloadData(url);
                }
                catch
                {
                    GameRound();
                }
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

        private static int GenerateRandomNumber(int min, int max)
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
