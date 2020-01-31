using Android.Content;
using Android.Support.V4.Hardware.Fingerprint;

using XamarinBase.Interfaces;

namespace WeatherChecker5000.Droid.Managers
{
    class MgrAuthentication : IBiometricAuthentication
    {
        public bool IsDeviceCapable(out int errCode)
        {
            errCode = 0;
            return true;
        }

        public bool GetAuthentication()
        {
            return true;
        }
    }
}