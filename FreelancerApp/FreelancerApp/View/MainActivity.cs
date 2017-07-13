using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FreelancerApp.View
{
    [Activity(Label = "FreelancerApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        } // end OnCreate

        #region Fields and Properties

        private    int _sourceAmpPct;
        private    int _thresholdPct;
        private    int _selectedSourceGlyph;
        private    int _selectedOutGlyph;

        private string _selectedSourceName;
        private string _selectedOutName;
        private string _selectedSourceType;
        private string _selectedOutType;
        private string _serviceStatus;
        private string _opStatus;
        private string _navStatus;
        private string _activityName;

        public int SourceAmpPct
        {
            get
            {
                return _sourceAmpPct;
            }
            set
            {
                _sourceAmpPct = value;
            }
        }

        public int ThresholdPct
        {
            get
            {
                return _thresholdPct;
            }
            set
            {
                _thresholdPct = value;
            }
        }

        public int SelectedSourceGlyph
        {
            get
            {
                return _selectedSourceGlyph;
            }
            set
            {
                _selectedSourceGlyph = value;
            }
        }

        public int SelectedOutGlyph
        {
            get
            {
                return _selectedOutGlyph;
            }
            set
            {
                _selectedOutGlyph = value;
            }
        }

        public string SelectedSourceName
        {
            get
            {
                return _selectedSourceName;
            }
            set
            {
                _selectedSourceName = value;
            }
        }

        public string SelectedOutName
        {
            get
            {
                return _selectedOutName;
            }
            set
            {
                _selectedOutName = value;
            }
        }

        public string SelectedSourceType
        {
            get
            {
                return _selectedSourceType;
            }
            set
            {
                _selectedSourceType = value;
            }
        }

        public string SelectedOutType
        {
            get
            {
                return _selectedOutType;
            }
            set
            {
                _selectedOutType = value;
            }
        }

        public string ServiceStatus
        {
            get
            {
                return _serviceStatus;
            }
            set
            {
                _serviceStatus = value;
            }
        }

        public string OpStatus
        {
            get
            {
                return _opStatus;
            }
            set
            {
                _opStatus = value;
            }
        }

        public string ActivityName
        {
            get
            {
                return _activityName;
            }
            set
            {
                _activityName = value;
            }
        }

        public string NavStatus
        {
            get
            {
                return _navStatus;
            }
            set
            {
                _navStatus = value;
            }
        }

        #endregion

    } // end class MainActivity
}

