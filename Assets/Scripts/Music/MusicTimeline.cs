using System;
using UnityEngine;

public class MusicTimeline : MonoBehaviour
{
    public float bpm;
    public int beatsPerLoop;

    public event Action<int> OnBeatPlayed;

    private int currentBeat;

    void Update()
    {
        // Calculate the duration of a single beat in seconds
        float beatDuration = 60f / bpm;

        // Calculate the time since the last beat
        float timeSinceLastBeat = Time.time % beatDuration;
        
        // Determine the current beat based on elapsed time
        int newBeat = (int)(Time.time / beatDuration) % beatsPerLoop;

        // If the beat has changed, invoke the event
        if (newBeat != currentBeat)
        {
            currentBeat = newBeat;
            OnBeatPlayed?.Invoke(currentBeat);
        }
    }
}
