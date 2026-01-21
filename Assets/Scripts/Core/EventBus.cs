using System;
using UnityEngine;

public static class EventBus 
{
    public static Action<int> OnBeat;
    public static Action OnLoopEnd;
}
