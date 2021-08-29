using System;
using System.Threading;
namespace EventsAndDelegates
{
public class Youtuber
{  
    //Define delegate
    public delegate void VideoUploadNotifier<VideoEventArgs>(object source, VideoEventArgs args);    
    //Define event
    public event VideoUploadNotifier<VideoEventArgs> uploadNotifier;

    public void UploadVideo(Video video)
    {        
        Thread.Sleep(3000);

        System.Console.WriteLine($"Uploaded new video {video.Title}....");

        OnVideoUploadComplete( new VideoEventArgs(video.Title));
    }

    protected virtual void OnVideoUploadComplete(VideoEventArgs videoEventArgs)
    {
        if(uploadNotifier != null)
        uploadNotifier(this, videoEventArgs);
    }
}
}