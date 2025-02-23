namespace ThietKePM_LeHoangVy.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
