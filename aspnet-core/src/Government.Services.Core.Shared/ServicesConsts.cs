using Government.Services.Debugging;

namespace Government.Services
{
    public class ServicesConsts
    {
        public const string LocalizationSourceName = "Services";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c4c2875aac1a44aaa2ba8e0d4fd672a1";
    }
}

