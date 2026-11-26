public class Monster
{
    public string name;
    public int hp;
    public int attack;
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;
    }

    public bool IsDead()
    {
        return hp <= 0;
    }
}
