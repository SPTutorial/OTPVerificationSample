using System;
using System.Collections.Generic;
using System.Text;

namespace OTPVerificationSample
{
    public interface IHashService
    {
        string GenerateHashkey();
        void StartSMSRetriverReceiver();
    }
}
