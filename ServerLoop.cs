using nDSSH;

namespace CapsBallCore
{
    public class ServerLoop
    {
        public ServerLoop(string serverAddress, int port)
        {
            SessionData.Initialize(serverAddress, port);
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