using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivityX = 2f; // ความไวในการหมุนซ้ายขวา
    public float sensitivityY = 2f; // ความไวในการหมุนขึ้นลง
    public Transform playerBody;    // ตัวแปรอ้างอิงไปยังร่างของตัวละคร (หรือ GameObject ที่ต้องการให้หมุน)

    private float xRotation = 0f;   // เก็บการหมุนในแนวแกน X (ขึ้น-ลง)

    void Update()
    {
        // รับค่าการหมุนเมาส์ในแนวนอน (ซ้าย-ขวา)
        float mouseX = Input.GetAxis("Mouse X") * sensitivityX;
        // รับค่าการหมุนเมาส์ในแนวตั้ง (ขึ้น-ลง)
        float mouseY = Input.GetAxis("Mouse Y") * sensitivityY;

        // หมุนตัวผู้เล่น (player) ในแนวนอน (แกน Y) ซ้ายขวา
        playerBody.Rotate(Vector3.up * mouseX);  // หมุนตัวผู้เล่นตามการเคลื่อนที่ของเมาส์ในแกน X

        // คำนวณการหมุนในแนวแกน X (ขึ้น-ลง) เพื่อจำกัดการหมุนไม่ให้เกิน -90 ถึง 90 องศา
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // จำกัดการหมุนในแนวแกน X

        // หมุนกล้องในแนวแกน X (ขึ้น-ลง)
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}