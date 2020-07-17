using System;

namespace Friday.StatisticsSystem
{
    internal class UnionCodeInfo
    {
        public event Action<string, DateTime, string, string> DataCompleted;

        private string _codeOne;
        private string _codeTwo;

        public DateTime Time { get; set; }

        public string Index { get; set; }

        public string CodeOne 
        {
            get => _codeOne;
            set
            {
                _codeOne = value;
                if (_codeTwo != null)
                    DataCompleted?.BeginInvoke(Index, Time, _codeOne, _codeTwo, null, null);
            }
        }

        public string CodeTwo 
        {
            get => _codeTwo;
            set
            {
                _codeTwo = value;
                if (_codeOne != null)
                    DataCompleted?.BeginInvoke(Index, Time, _codeOne, _codeTwo, null, null);
            }
        }
    }
}
