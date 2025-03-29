using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    void Start()
    {
        Init(100); // เริ่มต้นพลังชีวิตที่ 100
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบชนอุปสรรค 
        Obstacle obstacle = collision.gameObject.GetComponent<Obstacle>();
        if (obstacle != null)
        {
            // เมื่อผู้เล่นชนกับอุปสรรค ทำให้ผู้เล่นได้รับดาเมจ
            OnHitWith(obstacle);
            
        }
    }

    public void OnHitWith(Obstacle obstacle)
    {
        // ลดพลังชีวิตของผู้เล่นเมื่อชนกับอุปสรรค
        TakeDamage(obstacle.DamageHit); // ผู้เล่นรับดาเมจจากอุปสรรค
    }
}