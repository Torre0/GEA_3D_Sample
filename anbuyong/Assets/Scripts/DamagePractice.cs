using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack, defense;
    public bool isCritical, targetIsBoss;

    [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defense < 1 ? 1 : attack - defense;

        if (isCritical)
           damage = damage * 2;

        if (targetIsBoss)
            damage = damage / 2;

        Debug.Log(damage);
    }
}
