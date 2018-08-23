using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Speech.Tts;
using System.Collections.Generic;
using Android.Content;

namespace XamarinApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, TextToSpeech.IOnInitListener
    {
        static readonly List<string> phoneNumbers = new List<string>();

        public void OnInit([GeneratedEnum] OperationResult status)
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var phoneNumber = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            var translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
            var textView = FindViewById<TextView>(Resource.Id.TranslatedPhone);
            var historyButton = FindViewById<Button>(Resource.Id.HistoryButton);

            var textToSpeech = new TextToSpeech(this, this, "com.google.android.tts");
            textToSpeech.SetLanguage(Java.Util.Locale.Default);

            translateButton.Click += (sender, e) =>
            {
                var result = Translator.ToNumber(phoneNumber.Text);
                textView.Text = result ?? string.Empty;

                phoneNumbers.Add(result);
                historyButton.Enabled = true;

                if (!string.IsNullOrEmpty(result)) textToSpeech.Speak(textView.Text, QueueMode.Flush, null);
            };

            historyButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(HistoryActivity));
                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };
        }
    }
}