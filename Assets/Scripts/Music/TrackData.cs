using UnityEngine;

[CreateAssetMenu(menuName = "Rubato/Track Data")]
public class TrackData : ScriptableObject
{
    [Header("Music")]
    public float bpm;
    public int beatsPerLoop;
    public int loopCount;

    [Header("Grid Rules")]
    public int gridWidth;
    public int gridHeight;
    public int maxNotesPerColumn;

    [Header("Enemy Waves")]
    public EnemyWaveData[] enemyWaves;
}

[System.Serializable]
public class EnemyWaveData
{
    public int spawnBeat;
    public EnemyData[] enemies;
}