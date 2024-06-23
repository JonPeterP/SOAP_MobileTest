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


namespace SOAP_Mobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView text1;
        Button btnSubmit;
        EditText edit1;
        ImageView imgView1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            btnSubmit = FindViewById<Button>(Resource.Id.button1);
            btnSubmit.Click += BtnSubmitOnClick;

            text1 = FindViewById<TextView>(Resource.Id.textView1);
            edit1 = FindViewById<EditText>(Resource.Id.editText1);
            imgView1 = FindViewById<ImageView>(Resource.Id.imageView1);

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
            //text1.setText("Button Clicked");

            //com.daehosting.webservices.TemperatureConversions tempC = new com.daehosting.webservices.TemperatureConversions();
            //text1.Text = tempC.CelsiusToFahrenheit(decimal.Parse(edit1.Text)).ToString();


            // Create an instance of the service client
            var client = new CountryInfoService.CountryInfoService();

            // Specify the country ISO code
            string countryISOCode = edit1.Text.ToString() ?? "PH"; // Example: US for the United States

            try
            {
                //string flagUrl = client.CountryFlag(countryISOCode);

                string flagUrl = client.CountryFlag(countryISOCode);
                text1.Text = flagUrl;


                var imageBitmap = GetImageBitmapFromUrl(flagUrl);
                imgView1.SetImageBitmap(imageBitmap);

                // Display the result
                // Console.WriteLine($"The flag URL for {countryISOCode} is: {flagUrl}");
            }
            
            catch (Exception ex)
            {
                text1.Text = ($"An unexpected error occurred: {ex.Message}");
            }

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

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}
