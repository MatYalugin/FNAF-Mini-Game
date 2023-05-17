using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
    public float maxRotationAngle = 45.0f;

    private float currentRotation = 0.0f;

    void Update()
    {
        // Получаем значение оси горизонтального вращения мыши
        float mouseX = Input.GetAxis("Mouse X");

        // Вычисляем новый угол поворота
        currentRotation += mouseX * rotationSpeed;

        // Ограничиваем угол поворота в заданных пределах
        currentRotation = Mathf.Clamp(currentRotation, -maxRotationAngle, maxRotationAngle);

        // Применяем поворот по оси Y
        transform.rotation = Quaternion.Euler(0, currentRotation, 0);
    }
}
