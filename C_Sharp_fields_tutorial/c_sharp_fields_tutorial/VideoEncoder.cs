using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace c_sharp_fields_tutorial
{
    class VideoEncoder
    {
        //1 - Define a deligate
        //2 - Define a event based on the deligate
        //3 - Raise the event
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty); //same as following lines
            //if(VideoEncoded != null)
            //{
            //    VideoEncoded(this, EventArgs.Empty);
            //}
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

       
    }
}
