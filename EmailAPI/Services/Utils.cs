﻿using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace EmailAPI.Services
{
    public static class Utils
    {
        //[Obsolete("Do not use this in Production code!!!", true)]
        public static void DisableCertificateValidation()
        {
            // Disabling certificate validation can expose you to a man-in-the-middle attack
            // which may allow your encrypted message to be read by an attacker
            // https://stackoverflow.com/a/14907718/740639
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (
                    object s,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors
                )
                {
                    return true;
                };
        }
    }
}
