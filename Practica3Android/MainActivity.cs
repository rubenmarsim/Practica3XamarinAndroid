using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Practica3Android
{
    [Activity(Label = "Android_Controls_Ruben_Martinez", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnButton = FindViewById<Button>(Resource.Id.btnButton);
            btnButton.Click += delegate { StartActivity(typeof(ButtonActivity)); };

            var btnEditText = FindViewById<Button>(Resource.Id.btnEditText);
            btnEditText.Click += delegate { StartActivity(typeof(EditTextActivity)); };

            var btnCheckBox = FindViewById<Button>(Resource.Id.btnCheckBox);
            btnCheckBox.Click += delegate { StartActivity(typeof(CheckBoxActivity)); };

            var btnRadioButton = FindViewById<Button>(Resource.Id.btnRadioButton);
            btnRadioButton.Click += delegate { StartActivity(typeof(RadioButtonActivity)); };

            var btnToggleButton = FindViewById<Button>(Resource.Id.btnToggleButton);
            btnToggleButton.Click += delegate { StartActivity(typeof(ToggleButtonActivity)); };

            var btnSpinner = FindViewById<Button>(Resource.Id.btnSpinner);
            btnSpinner.Click += delegate { StartActivity(typeof(SpinnerActivity)); };

            var btnDatePicker = FindViewById<Button>(Resource.Id.btnDatePicker);
            btnDatePicker.Click += delegate { StartActivity(typeof(DatePickerActivity)); };

            var btnTimePicker = FindViewById<Button>(Resource.Id.btnTimePicker);
            btnTimePicker.Click += delegate { StartActivity(typeof(TimePickerActivity)); };

            var btnListView = FindViewById<Button>(Resource.Id.btnListView);
            btnListView.Click += delegate { StartActivity(typeof(ListViewActivity)); };

            var btnGridView = FindViewById<Button>(Resource.Id.btnGridView);
            btnGridView.Click += delegate { StartActivity(typeof(GridViewActivity)); };

            var btnWebView = FindViewById<Button>(Resource.Id.btnWebView);
            btnWebView.Click += delegate { StartActivity(typeof(WebViewActivity)); };
        }
    }
}