using CapsBallShared;
using System.Collections.Generic;
using System.Linq;

namespace CapsBallCore
{
    public static class ResponseResolver
    {
        const string UNDEFINED_ID = "undefined";

        static Dictionary<IResponseHandler, string> resolver = new Dictionary<IResponseHandler, string>()
        {
            { new AdminAddedResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.ADMIN_ADDED) },
            { new GetTeamResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.GET_TEAM) },
            { new GameStartedResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.GAME_STARTED) },
            { new JoinedTeamResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.JOINED_TEAM) },
            { new SendFootballerResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.SEND_FOOTBALLER) },
            { new SendGameStateResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.SEND_GAME_STATE) }
        };
        

        public static string HandlerToString(IResponseHandler handler) =>
            //resolver.Where(p => p.Key.GetType() == handler.GetType()).FirstOrDefault().Value;
            resolver.ContainsKey(handler) ? resolver[handler] : UNDEFINED_ID;

        public static IResponseHandler StringToHandler(string command) =>
            resolver.Where(p => p.Value == command).FirstOrDefault().Key;
    }
}
