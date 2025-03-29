using UnityEngine;

public class Obstacle : Character
{
    private int damageHit; //ตั้งชื่อตามprob มันเป็นสูตร ชื่อแบบเดียวกันเป๊ะแต่ตัวหน้าตัวเล็ก ต้องมีตลอด
    public int DamageHit
    {
        get
        {
            return damageHit;
        }
        set
        {
            damageHit = value;
        }
    }
}
