using GISA.ChangeDataCapture.MessageBroker.Contracts;
using GISA.ChangeDataCapture.Worker.Contracts;

namespace GISA.ChangeDataCapture.Members.Application.Services
{
    public class MemberObserverService : IChangeDataCaptureObserver
    {
        private readonly IChangeDataCaptureNotification _changeDataCaptureNotification;

        public MemberObserverService(IChangeDataCaptureNotification changeDataCaptureNotification)
        {
            _changeDataCaptureNotification = changeDataCaptureNotification;
        }

        public void Update<T>(T notification)
        {
            _changeDataCaptureNotification
                .PublishAsync(notification).ConfigureAwait(false);
        }
    }
}
