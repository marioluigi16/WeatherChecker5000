using Foundation;
using LocalAuthentication;
using System;
using UIKit;

namespace WeatherChecker5000.iOS.Managers
{
    static class Strings
    {
        public const string RequirePasscode = "";
        public const string RequireTouchID = "";
        public const string RequireFaceID = "";
        public const string UnlockWithPasscode = "";
        public const string UnlockWithTouchID = "";
        public const string UnlockWithFaceID = "";
        public const string PleaseAuthenticateToProceed = "";
    }

    static class SvgLibrary
    {
        public const string LockIcon = "";
        public const string TouchIdIcon = "";
        public const string FaceIdIcon = "";
    }


    class AuthBiometrics
    {
        private enum LocalAuthType
        {
            None,
            Passcode,
            TouchId,
            FaceId
        }

        public static string GetLocalAuthLabelText()
        {
            var localAuthType = GetLocalAuthType();
            switch (localAuthType)
            {
                case LocalAuthType.Passcode:
                    return Strings.RequirePasscode;
                case LocalAuthType.TouchId:
                    return Strings.RequireTouchID;
                case LocalAuthType.FaceId:
                    return Strings.RequireFaceID;
                default:
                    return string.Empty;
            }
        }

        public static string GetLocalAuthIcon()
        {
            var localAuthType = GetLocalAuthType();
            switch (localAuthType)
            {
                case LocalAuthType.Passcode:
                    return SvgLibrary.LockIcon;
                case LocalAuthType.TouchId:
                    return SvgLibrary.TouchIdIcon;
                case LocalAuthType.FaceId:
                    return SvgLibrary.FaceIdIcon;
                default:
                    return string.Empty;
            }
        }

        public static string GetLocalAuthUnlockText()
        {
            var localAuthType = GetLocalAuthType();
            switch (localAuthType)
            {
                case LocalAuthType.Passcode:
                    return Strings.UnlockWithPasscode;
                case LocalAuthType.TouchId:
                    return Strings.UnlockWithTouchID;
                case LocalAuthType.FaceId:
                    return Strings.UnlockWithFaceID;
                default:
                    return string.Empty;
            }
        }
        public static bool IsLocalAuthAvailable => GetLocalAuthType() != LocalAuthType.None;
        public static void Authenticate(Action onSuccess, Action onFailure)
        {
            var context = new LAContext();
            NSError AuthError;
            if (context.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out AuthError)
                || context.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthentication, out AuthError))
            {
                var replyHandler = new LAContextReplyHandler((success, error) =>
                {
                    if (success)
                    {
                        onSuccess?.Invoke();
                    }
                    else
                    {
                        onFailure?.Invoke();
                    }
                });
                context.EvaluatePolicy(LAPolicy.DeviceOwnerAuthentication, Strings.PleaseAuthenticateToProceed, replyHandler);
            }
        }

        private static LocalAuthType GetLocalAuthType()
        {
            var localAuthContext = new LAContext();
            NSError AuthError;
            if (localAuthContext.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthentication, out AuthError))
            {
                if (localAuthContext.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out AuthError))
                {
                    if (GetOsMajorVersion() >= 11 && localAuthContext.BiometryType == LABiometryType.TypeFaceId)
                    {
                        return LocalAuthType.FaceId;
                    }
                    return LocalAuthType.TouchId;
                }
                return LocalAuthType.Passcode;
            }
            return LocalAuthType.None;
        }

        private static int GetOsMajorVersion()
        {
            return int.Parse(UIDevice.CurrentDevice.SystemVersion.Split('.')[0]);
        }
    }
}