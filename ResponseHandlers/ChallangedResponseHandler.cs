using System;

namespace CapsBallCore
{
    public class ChallangedResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 1;

        public static event Action<string> Challanged;

        public void Handle(ResponsePackage responsePackage)
        {
            string teamName = responsePackage.Parameters[0];
            System.Console.WriteLine(teamName);
            Challanged?.Invoke(teamName);
        }
    }
}
