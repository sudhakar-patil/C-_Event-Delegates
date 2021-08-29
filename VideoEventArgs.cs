using System;

namespace EventsAndDelegates
{

public class VideoEventArgs: EventArgs
{
    public string VideoTitle {get; private set;}

    public VideoEventArgs(string title)
    {
        this.VideoTitle = title;
    }
}

}
