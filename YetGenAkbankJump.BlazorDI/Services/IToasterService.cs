namespace YetGenAkbankJump.BlazorDI.Services
{
    public interface IToasterService
    {
        void ShowSuccess(string message);
        void ShowWarning(string message);
        void ShowInfo(string message);
    }
}
