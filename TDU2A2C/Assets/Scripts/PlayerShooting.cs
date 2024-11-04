using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
    public Bullet bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public List<BulletdataSO> bulletsData;
    private int index = 0;
    public HUDManager HUDManager;
    private float currentTime;
    public float specialAttackCD = 5f;
    public int specialAttackCount = 3;
    public float timeBetweenBullets = 0.2f;
    private bool canSpecialAttack = true;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Fire1 es el clic izquierdo del mouse o Ctrl en el teclado
        {
            Vector3 direction = (firePoint.position - transform.position).normalized;
            Shoot(index, direction);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            index--;
            if (index < 0)
            {

                index = bulletsData.Count - 1;

            }
            HUDManager.ChangeColor(bulletsData[index].color);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            index++;
            if (index > bulletsData.Count - 1)
            {

                index = 0;
            }
            HUDManager.ChangeColor(bulletsData[index].color);
        }
        if (Input.GetMouseButtonDown(1) && canSpecialAttack)
        {

            SpecialAttack();

        }
        if (currentTime > specialAttackCD) {


            currentTime = 0;
            canSpecialAttack = true;
        }
        if (!canSpecialAttack) { 
        
            currentTime += Time.deltaTime;

        }
    }

    void Shoot(int bulletIndex, Vector3 direction)
    {

        
        direction.y = 0;
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.lifeTime = bulletsData[bulletIndex].lifetime;
        bullet.speed = bulletsData[bulletIndex].speed;
        bullet.mesh.material = bulletsData[bulletIndex].material;
        bullet.direction = direction;

    }

    void SpecialAttack()
    {

        StartCoroutine(SpecialAttackExcecute());

        canSpecialAttack = false;


    }

    private IEnumerator SpecialAttackExcecute()
    {
        int indexS = index;

        Vector3 direction = (firePoint.position - transform.position).normalized;

        for (int i = 0; i < bulletsData.Count; i++)
        {



            yield return new WaitForSeconds(timeBetweenBullets);
            Shoot(indexS, direction);

        }

    }
}
