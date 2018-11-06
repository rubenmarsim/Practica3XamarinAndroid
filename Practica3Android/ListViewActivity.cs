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
        private List<string> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListView);
            mListView = FindViewById<ListView>(Resource.Id.listView1);

            mItems = new List<string>();
            mItems.Add("Bob");
            mItems.Add("Tom");
            mItems.Add("Jim");
            mItems.Add("Ruben");
            mItems.Add("Marc");
            mItems.Add("Sergi");
            mItems.Add("Emenejildo");
            mItems.Add("Anacleto");
            mItems.Add("Pepe");
            mItems.Add("Luis");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);

            mListView.Adapter = adapter;
        }
    }
}