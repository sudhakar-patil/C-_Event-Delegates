using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("\"Short Video\"");
            Youtuber youtuber = new Youtuber();

            Subscriber subscriber = new Subscriber();
            
            youtuber.uploadNotifier += subscriber.OnVideoUpload;

            youtuber.UploadVideo(video);        

        }
    }
}
