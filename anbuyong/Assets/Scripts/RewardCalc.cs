using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        int hour = playSeconds / 60;
        int t = hour / 60;
        int min = hour % 60;
        int s = playSeconds % 60;
        Debug.Log(t+"시간"+min+"분"+s+"초");

        int g = gold / members;
        int m = gold % members;
        Debug.Log("1인당 "+g+"G, "+"리더 보너스 "+m+"G");


        Debug.Log("경험치 "+);
    }
}
