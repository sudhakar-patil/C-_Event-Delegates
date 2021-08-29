using System;
namespace EventsAndDelegates
{
public class Subscriber
{
    public Subscriber()
    {
        
    }

    public void OnVideoUpload(object source, VideoEventArgs args)
    {
        System.Console.WriteLine($"Notification: New video uploaded {args.VideoTitle}");
    }
}
}