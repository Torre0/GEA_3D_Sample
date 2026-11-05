using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName;
    public int level;
    public float attack;
    public bool isBoss;

    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log(playerName);
        Debug.Log(level);
        Debug.Log(attack);
        Debug.Log(isBoss);
    }
}
