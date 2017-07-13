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

namespace FreelancerApp
{
    public class DeviceEntity
    {
        private string _deviceName;
        private string _deviceType;
        private int _deviceGlyph; // = Resource.Drawable.ExampleGlyph;

        public string DeviceName
        {
            get
            {
                return _deviceName;
            }
            set
            {
                _deviceName = value;
            }
        }

        public string DeviceType
        {
            get
            {
                return _deviceType;
            }
            set
            {
                _deviceType = value;
            }
        }

        public int DeviceGlyph
        {
            get
            {
                return _deviceGlyph;
            }
            set
            {
                _deviceGlyph = value;
            }
        }

    } // end class DeviceEntity
}