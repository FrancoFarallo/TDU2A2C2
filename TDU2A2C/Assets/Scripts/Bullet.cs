using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 5f;
    public Vector3 direction;
    public float speed = 1;
    public MeshRenderer mesh;

    void Start()
    {
        Destroy(gameObject, lifeTime); // Destruir después de 5 segundos
    }

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Destruir enemigo
            Destroy(gameObject); // Destruir la bala
        }
    }
}
