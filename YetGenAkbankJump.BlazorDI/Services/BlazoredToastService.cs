namespace YetGenAkbankJump.BlazorDI.Services
{
    public class BlazoredToastService : IToasterService
    {
        private readonly IToasterService _toastService;

        public BlazoredToastService(IToasterService toastService)
        {
            _toastService = toastService;
        }

        public void ShowInfo(string message)
        {
            _toastService.ShowInfo(message);
        }

        public void ShowSuccess(string message)
        {
            _toastService.ShowSuccess(message);
        }

        public void ShowWarning(string message)
        {
            _toastService.ShowWarning(message);
        }
    }
}
