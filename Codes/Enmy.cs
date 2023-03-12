using UnityEngine;

public class Enmy : MonoBehaviour
{
    public Transform player; // Ссылка на объект игрока
    public float speed = 5f; // Скорость движения врага

    void Update()
    {
        // Вычисляем направление движения врага к игроку
        Vector3 direction = player.position - transform.position;
        direction.Normalize(); // Нормализуем вектор направления

        // Поворачиваем врага в направлении игрока
        transform.rotation = Quaternion.LookRotation(direction);

        // Двигаем врага в направлении игрока с заданной скоростью
        transform.position += direction * speed * Time.deltaTime;
    }
}