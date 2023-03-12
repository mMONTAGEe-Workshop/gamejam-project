using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody bulletPrefab;  // префаб объекта пули
    public Transform bulletSpawnPoint;  // точка, откуда вылетают пули
    public float bulletSpeed = 20f;  // скорость пули
    public float fireRate = 0.1f;       // Частота стрельбы в секундах
    private float nextFireTime = 0f;    // Время следующего разрешенного выстрела
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Rigidbody bulletInstance = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bulletInstance.velocity = bulletSpawnPoint.forward * bulletSpeed;
            Destroy(bulletInstance.gameObject, 3f);
        }
    }
}