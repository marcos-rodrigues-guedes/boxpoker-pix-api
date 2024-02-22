using boxpoker.network.Core;

namespace boxpoker.network.Session
{
    public class SessionManager
    {
        private static SessionManager? _instance;
        private AuthResponse? _sessionObject;
        private DateTime _expirationTime;

        private SessionManager() {
            _expirationTime = DateTime.MinValue;
        }

        public static SessionManager Instance
        {
            get
            {
                _instance ??= new SessionManager();
                return _instance;
            }
        }

        public AuthResponse? SessionObject
        {
            get { return _sessionObject; }
            set {
                if (value != null) {
                    _expirationTime = DateTime.Now.Add(TimeSpan.FromSeconds(value.ExpiresIn));
                }
                _sessionObject = value;
            }
        }

        public bool IsTokenValid()
        {
            return DateTime.Now < _expirationTime;
        }

    }
}