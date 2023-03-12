using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float sensitivity = 100f;   // чувствительность мыши
    public Transform Player;           // трансформ игрока
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   // скрываем курсор мыши
    }

    void Update()
    {
        // получаем данные о перемещении мыши
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // поворачиваем камеру по вертикали
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // поворачиваем игрока по горизонтали
        Player.Rotate(Vector3.up * mouseX);
    }
}