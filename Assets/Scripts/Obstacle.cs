using UnityEngine;

public class Obstacle : Character
{
    private int damageHit; //��駪��͵��prob �ѹ���ٵ� ����Ẻ���ǡѹ�������˹�ҵ����� ��ͧ�յ�ʹ
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
