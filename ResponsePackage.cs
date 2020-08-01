using nDSSH;
using System.Collections.Generic;
using CapsBallShared;

namespace CapsBallCore
{
    public class ResponsePackage : CommandPackage
    {
        IResponseHandler handler;

        public ResponsePackage(IResponseHandler handler, List<string> parameters)
        {
            this.handler = handler;
            Parameters = parameters;
        }

        public ResponsePackage(IResponseHandler handler) => this.handler = handler;

        public ResponsePackage(Package package)
        {
            System.IO.File.WriteAllText("jd.txt", package.MessageContent);
            string[] basicComponents = package.MessageContent.Split(COMMAND_SPLIT_CHAR);
            System.IO.File.WriteAllText("jd2.txt", basicComponents[0]);
            handler = ResponseResolver.StringToHandler(basicComponents[0]);
        
            if (basicComponents.Length == 1)
                Parameters = new List<string>();
            else
                Parameters = new List<string>(basicComponents[1].Split(new string[] { PARAMETER_SPLIT_TEXT }, System.StringSplitOptions.None));
        }

        public ResponsePackage(string rawData)
        {
            string[] components = rawData.Split(COMMAND_SPLIT_CHAR);
            handler = ResponseResolver.StringToHandler(components[0]);

            if (components.Length == 1)
                Parameters = new List<string>();
            else
                Parameters = new List<string>(components[1].Split(new string[] { PARAMETER_SPLIT_TEXT }, System.StringSplitOptions.None));
        }

        public override string GetRawData()
        {
            string rawData = ResponseResolver.HandlerToString(handler) + COMMAND_SPLIT_CHAR;

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

        public bool TryHandle()
        {
            if (Parameters.Count < handler.ParamsRequiredCount)
                return false;

            handler.Handle(this);
            return true;
        }
    }
}