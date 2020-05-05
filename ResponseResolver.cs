using System.Collections.Generic;
using System.Linq;

namespace CapsBallCore
{
    public static class ResponseResolver
    {
        static Dictionary<IResponseHandler, string> resolver = new Dictionary<IResponseHandler, string>();
        const string UNDEFINED_ID = "undefined";

        static ResponseResolver()
        {
            //resolver.Add(new CreateTeamRequestHandler(), "addforce");
        }

        public static string HandlerToString(IResponseHandler handler) =>
            resolver.ContainsKey(handler) ? resolver[handler] : UNDEFINED_ID;

        public static IResponseHandler StringToHandler(string command) =>
            resolver.Where(p => p.Value == command).FirstOrDefault().Key;
    }
}
