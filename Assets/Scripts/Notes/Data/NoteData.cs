using UnityEngine;

[CreateAssetMenu(menuName = "Rubato/Note Data")]
public class NoteData : ScriptableObject
{
    [Header("Identity")]
    public string noteName;
    public NoteType type;

    [Header("Combat")]
    public int damage;
    public float range;
    public int duration;

    [Header("Music")]
    public FrequencyType frequency;
}
