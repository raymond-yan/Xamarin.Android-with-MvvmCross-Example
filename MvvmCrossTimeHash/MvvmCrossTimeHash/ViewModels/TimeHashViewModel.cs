using MvvmCross.Core.ViewModels;
using MvvmCrossTimeHash.Services;
using System.Threading;
using System.Threading.Tasks;

namespace MvvmCrossTimeHash.ViewModels
{
    public class TimeHashViewModel : MvxViewModel
    {
        readonly ITimeHashGenerator _generator;

        public TimeHashViewModel(ITimeHashGenerator generator) => _generator = generator;

        public override void Start()
        {
            TimeInterval = 5;
            base.Start();
        }

        private const int MAX_INTERVAL = 60;
        private const int MIN_INTERVAL = 1;

        int _timeInterval;

        public int TimeInterval
        {
            get
            {
                return _timeInterval;
            }

            set
            {
                if (value > MAX_INTERVAL)
                {
                    _timeInterval = MAX_INTERVAL;
                }
                else if (value < MIN_INTERVAL)
                {
                    _timeInterval = MIN_INTERVAL;
                }
                else
                {
                    _timeInterval = value;
                }
                RaisePropertyChanged(() => TimeInterval);
                GenerateHash();
            }
        }

        string _timeHash;

        public string TimeHash
        {
            get { return _timeHash; }
            set
            {
                _timeHash = value;
                RaisePropertyChanged(() => TimeHash);
            }
        }

        int _timeProgress;

        public int TimeProgress
        {
            get { return _timeProgress; }
            set
            {
                _timeProgress = value;
                RaisePropertyChanged(() => TimeProgress);
            }
        }

        CancellationTokenSource _cts;
        void GenerateHash()
        {
            if (_cts != null)
                _cts.Cancel();
            _cts = new CancellationTokenSource();
            RunTimer(_cts.Token);
        }

        async Task RunTimer(CancellationToken token)
        {
            TimeProgress = TimeInterval;
            while (true)
            {
                await Task.Delay(1000, token);
                if (--TimeProgress <= 0)
                {
                    TimeProgress = TimeInterval;
                    TimeHash = _generator.GenerateHash();
                }
            }
        }
    }
}
