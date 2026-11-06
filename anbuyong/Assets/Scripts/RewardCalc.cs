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
        Debug.Log("플레이 시간 "+t + "시간 " + min + "분 " + s + "초 ");

        int g = gold / members;
        int m = gold % members;
        Debug.Log("1인당 " + g + "G, " + "리더 보너스 " + m + "G");

        float epk = kills * expPerKill * expRate;
        int ki = (int)epk;
        int exp = kills * expPerKill;
        Debug.Log("경험치 " + ki + " (기본 " + exp + ")");
        
        int level = ki / 100 + 1;
        int nextexp = 100 - ki % 100;
        Debug.Log("Lv " + level + ", " + "다음 레벨까지 " + nextexp);

        float to = (float)totalDamage / hits;
        Debug.Log("평균 데미지 " + to);
    }
}
