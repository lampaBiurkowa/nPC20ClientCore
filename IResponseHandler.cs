namespace CapsBallCore
{
    public interface IResponseHandler
    {
        int ParamsRequiredCount { get; }
        void Handle(ResponsePackage responsePackage);
    }
}
