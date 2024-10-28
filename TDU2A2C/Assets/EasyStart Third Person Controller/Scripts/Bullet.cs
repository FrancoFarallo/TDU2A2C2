using UnityEngine;

public class HeroBullet : MonoBehaviour
{
    public float velocity = 30f;
    private Vector3 speed;

    void Start()
    {
        speed = transform.forward * velocity;
        Destroy(gameObject, 5f); // Destroy the bullet after 5 seconds
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Destroy the enemy
        }
    }
}
