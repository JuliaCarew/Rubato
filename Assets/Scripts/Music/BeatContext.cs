using System.Numerics;

public struct BeatContext
{
    public int BeatIndex;
    public int LoopIndex;

    public Vector2 GridPosition;

    public NoteData NoteData;
    public FrequencyType Frequency;

    public CombatSystem CombatSystem;
    public EnemyManager EnemyManager;
}
