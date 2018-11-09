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
using Practica3Android.Adapter;

namespace Practica3Android
{
    [Activity(Label = "GridViewActivity")]
    public class GridViewActivity : Activity
    {
        string[] array_character =
        {
            "a","b","c","d","e","f","g"
        };
        List<string> lstResult = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.GridView);
            SetupList();
            GridView gridView = FindViewById<GridView>(Resource.Id.gridView1);
            var gridViewAdapter = new GridViewAdapter(lstResult, this);
            gridView.Adapter = gridViewAdapter;
        }
        private void SetupList()
        {
            foreach (var item in array_character)
                lstResult.Add(item);
        }
    }
}