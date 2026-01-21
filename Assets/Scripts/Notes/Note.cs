using UnityEngine;

public class Note : MonoBehaviour
{
    public NoteData Data;
    private INoteBehaviour behaviour;

    public void Play(BeatContext context)
    {
        behaviour.Execute(context);
    }
}
