using UnityEngine;

public class MinusFieldHP : Obstacle
{
    private void Start() //�� Start ����١�ͧ�������ʴ��� ��������������١
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Awake() //�� Start ����١�ͧ�������ʴ��� ��������������١
    {

        Init(50);
        DamageHit = 20;
        healthBar.SetMaxHealth(100);

    }
}
