using UnityEngine;

public class MinusFieldHP : Obstacle
{
    private void Start() //มี Start ที่ลูกของแม่ไม่แสดงละ แม่เสียสละให้ลูก
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Awake() //มี Start ที่ลูกของแม่ไม่แสดงละ แม่เสียสละให้ลูก
    {

        Init(50);
        DamageHit = 20;
        healthBar.SetMaxHealth(100);

    }
}
