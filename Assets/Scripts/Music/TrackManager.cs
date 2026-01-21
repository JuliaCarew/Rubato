using UnityEngine;

public class TrackManager : MonoBehaviour
{
    public TrackData CurrentTrack { get; private set;}
    public int RemainingLoops;

    public void StartTrack(TrackData trackData, int loops)
    {
        CurrentTrack = trackData;
        RemainingLoops = loops;
        // Additional logic to start playing the track
    }
    public void StopTrack()
    {
        CurrentTrack = null;
        RemainingLoops = 0;
        // Additional logic to stop playing the track
    }

}
