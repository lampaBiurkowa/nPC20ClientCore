using CapsBallShared;
using nDSSH;

namespace CapsBallCore
{
    public static class RequestCaller
    {
        public static void RequestJoinGame()
        {
            RequestPackage package = new RequestPackage(RequestCommand.JOIN_GAME);
            System.Console.WriteLine("no jedziemy");
            Sender.Send(package.GetRawData());
        }
    }
}
