using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivityX = 2f; // ������㹡����ع���¢��
    public float sensitivityY = 2f; // ������㹡����ع���ŧ
    public Transform playerBody;    // �������ҧ�ԧ��ѧ��ҧ�ͧ����Ф� (���� GameObject ����ͧ��������ع)

    private float xRotation = 0f;   // �纡����ع���᡹ X (���-ŧ)

    void Update()
    {
        // �Ѻ��ҡ����ع�������ǹ͹ (����-���)
        float mouseX = Input.GetAxis("Mouse X") * sensitivityX;
        // �Ѻ��ҡ����ع�������ǵ�� (���-ŧ)
        float mouseY = Input.GetAxis("Mouse Y") * sensitivityY;

        // ��ع��Ǽ����� (player) ��ǹ͹ (᡹ Y) ���¢��
        playerBody.Rotate(Vector3.up * mouseX);  // ��ع��Ǽ����蹵���������͹���ͧ������᡹ X

        // �ӹǳ�����ع���᡹ X (���-ŧ) ���ͨӡѴ�����ع�������Թ -90 �֧ 90 ͧ��
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // �ӡѴ�����ع���᡹ X

        // ��ع���ͧ���᡹ X (���-ŧ)
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}