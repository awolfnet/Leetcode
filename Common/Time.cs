using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Time:IDisposable
    {
        private DateTime _starttime;
        private DateTime _endtime;
        private DateTime _established;

        public Time()
        {
            
        }

        ~Time()
        {

        }

        public void Dispose()
        {
            
        }

        public void Start()
        {
            _starttime = DateTime.Now;
        }

        public void End()
        {
            _endtime = DateTime.Now;
        }

        public DateTime Established()
        {
            return _established;
        }
    }
}
