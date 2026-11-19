using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        List<int> criticals = new List<int>();
        int Sum = 0;
        foreach (int damage in damages)
        {
            if(damage >= criticalLine)
            {
                criticals.Add(damage);
            }
            Sum += damage;
        }
        Debug.Log("총 데미지 " + Sum);
        Debug.Log("치명타 " + criticals.Count + " 회");
        Debug.Log("치명타 " + criticals);
    }
}
