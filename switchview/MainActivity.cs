using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace switchview
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Switch _switch, _switch2, _switch3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            _switch = FindViewById<Switch>(Resource.Id.switch1);
            _switch2 = FindViewById<Switch>(Resource.Id.switch2);
            _switch3 = FindViewById<Switch>(Resource.Id.switch3);

            _switch.CheckedChange += _switch_CheckedChange;
            _switch2.CheckedChange += _switch_CheckedChange;
            _switch3.CheckedChange += _switch_CheckedChange;
        }


        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu, menu);

            return true;
        }
        private void _switch_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (sender == null) return;
            int _id = (sender as Switch).Id;
            switch (_id)
            {
                case (Resource.Id.switch1):
                    Toast.MakeText(this, "this is switch1", ToastLength.Short).Show();
                    break;
                case (Resource.Id.switch2):
                    Toast.MakeText(this, "this is switch2", ToastLength.Short).Show();
                    break;
                case (Resource.Id.switch3):
                    Toast.MakeText(this, "this is switch3", ToastLength.Short).Show();
                    break;
                default:
                    break;
            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


    }
}