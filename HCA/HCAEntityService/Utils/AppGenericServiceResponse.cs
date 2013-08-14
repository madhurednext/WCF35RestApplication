using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
namespace HCAEntityService.Utils
{
     [DataContract]
    public class AppGenericServiceResponse<T>
    {
           [DataMember]
        public string Status;
        [DataMember]
        public string DurationMillis;
        [DataMember]
        public string ErrorCode;
        [DataMember]
        public T Data;
        private Stopwatch watch;

        public AppGenericServiceResponse()
        {
            watch = new Stopwatch();
            watch.Start();
        }

        public bool SetDataAndStopWatch(T data)
        {
            Data = data;
            if (watch != null)
            {
                watch.Stop();
                DurationMillis = watch.ElapsedMilliseconds.ToString();

            }
            return true;
        }


    }
}