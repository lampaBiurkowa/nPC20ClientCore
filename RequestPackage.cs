using CapsBallShared;
using nDSSH;
using System.Collections.Generic;

namespace CapsBallCore
{
    public class RequestPackage : CommandPackage
    {
        public string Nick { get; private set; }
        public RequestCommand Command { get; private set; }

        public RequestPackage(RequestCommand command, List<string> parameters)
        {
            Nick = CachedData.Nick;
            Command = command;
            Parameters = parameters;
        }

        public RequestPackage(RequestCommand command)
        {
            Nick = CachedData.Nick;
            Command = command;
        }

        public override string GetRawData()
        {
            string rawData = Nick + COMMAND_SPLIT_CHAR + CommandsTranslator.RequestToString(Command) + COMMAND_SPLIT_CHAR;

            for (int i = 0; i < Parameters.Count; i++)
            {
                if (Parameters[i].Contains(PARAMETER_SPLIT_TEXT))
                    return ERROR_TEXT; //params cannot contain split text cause it would harm the communication

                rawData += Parameters[i];
                if (i != Parameters.Count - 1)
                    rawData += PARAMETER_SPLIT_TEXT;
            }

            return rawData;
        }
    }
}