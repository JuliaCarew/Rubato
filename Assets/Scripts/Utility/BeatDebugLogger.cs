using UnityEngine;

public class BeatDebugLogger : MonoBehaviour
{
    void OnEnable() => EventBus.OnBeat += Log;
    void OnDisable() => EventBus.OnBeat -= Log;

    void Log(int beat)
    {
        Debug.Log($"Beat {beat}");
    }
}
