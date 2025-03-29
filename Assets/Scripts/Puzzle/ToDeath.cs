using UnityEngine;

public class ToDeath : Obstacle
{
    private void Start() //มี Start ที่ลูกของแม่ไม่แสดงละ แม่เสียสละให้ลูก
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Awake() //มี Start ที่ลูกของแม่ไม่แสดงละ แม่เสียสละให้ลูก
    {

        Init(50);
        DamageHit = 200;
        healthBar.SetMaxHealth(100);

    }
}
