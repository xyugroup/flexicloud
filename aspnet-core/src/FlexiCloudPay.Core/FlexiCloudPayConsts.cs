using FlexiCloudPay.Debugging;

namespace FlexiCloudPay
{
    public class FlexiCloudPayConsts
    {
        public const string LocalizationSourceName = "FlexiCloudPay";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "09be1078bbef4d0c9d78152ed9c77822";
    }
}
