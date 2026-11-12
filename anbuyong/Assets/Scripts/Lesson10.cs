using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }

    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 3;
        string text = "";
        for(int row = 1; row <= height; row++)
        {
            for(int col = 0; col < row; col++)
            {
                text += "*";
            }
            text += "\n";
        }
        Debug.Log(text);
    }

    [ContextMenu("뒤집힌 계단")]
    void ReverseStairs()
    {
        int height = 4;
        string text = "";
        for(int row = height; row > 0; row--)
        {
            for(int col = 0; col < row; col++)
            {
                text += "*";
            }
            text += "\n";
        }
        Debug.Log(text);
    }

    [ContextMenu("오른쪽 계단")]
    void RightStairs()
    {
        int height = 4;
        string text = "";
        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = row;
            for (int i = 0; i < spaceCount; i++)
            {
                text += " ";
            }
            for (int i = 0; i < starCount; i++)
            {
                text += "*";
            }
            text += "\n";
        }
        Debug.Log(text);
    }

    [ContextMenu("트리")]
    void Tree()
    {
        int height = 4;
        string text = "";
        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = 2 * row - 1;
            for (int i = 0; i < spaceCount; i++)
            {
                text += " ";
            }
            for (int i = 0; i < starCount; i++)
            {
                text += "*";
            }
            text += "\n";
        }
        Debug.Log(text);
    }
}