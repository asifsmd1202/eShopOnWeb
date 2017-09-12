namespace ApplicationCore.Interfaces
{
    /// <summary>
    /// This type elimitnate the need depend directily on the ASP.NET Core logging types.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAppLogger<T>
    {
        void LogWarning(string message, params object[] args);
    }
}
