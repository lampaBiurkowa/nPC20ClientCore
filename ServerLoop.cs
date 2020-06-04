using nDSSH;
using System;

namespace CapsBallCore
{
    public class ServerLoop
    {
        public event Action Ready;

        public ServerLoop(string serverAddress, int port)
        {
            SessionData.Ready += onReady;
            Receiver.Received += onReceived;
            SessionData.Initialize(serverAddress, port);
        }

        void onReady()
        {
            Ready?.Invoke();
        }

        public void Update()
        {
            SessionData.Update();
        }

        void onReceived(Package package)
        {
            ResponsePackage responsePackage = new ResponsePackage(package);
            if (checkIfFakeClient(responsePackage))
                return;

            responsePackage.TryHandle();
        }

        static bool checkIfFakeClient(ResponsePackage package)
        {
            return false;
        }
    }
}