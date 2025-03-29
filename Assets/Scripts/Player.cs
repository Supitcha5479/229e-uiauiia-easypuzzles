using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    void Start()
    {
        Init(100); // ������鹾�ѧ���Ե��� 100
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ��Ǩ�ͺ���ػ��ä 
        Obstacle obstacle = collision.gameObject.GetComponent<Obstacle>();
        if (obstacle != null)
        {
            // ����ͼ����蹪��Ѻ�ػ��ä �������������Ѻ�����
            OnHitWith(obstacle);
            
        }
    }

    public void OnHitWith(Obstacle obstacle)
    {
        // Ŵ��ѧ���Ե�ͧ����������ͪ��Ѻ�ػ��ä
        TakeDamage(obstacle.DamageHit); // �������Ѻ������ҡ�ػ��ä
    }
}