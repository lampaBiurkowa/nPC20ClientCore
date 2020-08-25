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
            System.Console.WriteLine($"dostalismy se {package.MessageContent}");
            ResponsePackage responsePackage = new ResponsePackage(package);
            responsePackage.TryHandle();
        }
    }
}