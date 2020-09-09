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
            { new BonusAddedResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.BONUS_ADDED) },
            { new BulletTriggeredResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.BULLET_TRIGGERED) },
            { new GetTeamResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.GET_TEAM) },
            { new GameStartedResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.GAME_STARTED) },
            { new ImpulseAppliedResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.IMPULSE_APPLIED) },
            { new JoinedTeamResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.JOINED_TEAM) },
            { new SendBallStateResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.SEND_BALL_STATE) },
            { new SendFootballerStateResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.SEND_FOOTBALLER_STATE) },
            { new SendGameStateResponseHandler(), CommandsTranslator.ResponseToString(ResponseCommand.SEND_GAME_STATE) }
        };
        

        public static string HandlerToString(IResponseHandler handler) =>
            resolver.ContainsKey(handler) ? resolver[handler] : UNDEFINED_ID;

        public static IResponseHandler StringToHandler(string command) =>
            resolver.Where(p => p.Value == command).FirstOrDefault().Key;
    }
}
