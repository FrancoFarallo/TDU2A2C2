using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Bullet bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Fire1 es el clic izquierdo del mouse o Ctrl en el teclado
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector3 direction = (firePoint.position - transform.position).normalized;
        direction.y = 0;
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.direction = direction;
    
    }
}
