using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBase.Interfaces
{
    public interface IBiometricAuthentication
    {
        bool IsDeviceCapable(out int errCode);

        bool GetAuthentication();
    }
}
