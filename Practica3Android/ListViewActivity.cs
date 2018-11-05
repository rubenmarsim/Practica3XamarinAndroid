using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Practica3Android
{
    [Activity(Label = "ListViewActivity")]
    public class ListViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListView);

            string[] countries = Resources.GetStringArray(Resource.Array.countries_array);
            IListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListView, countries);
        }
    }
}