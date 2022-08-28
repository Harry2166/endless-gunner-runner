using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float timeStart = 0f;
    public int per_second_increment = 30;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject collectibleBulletPrefab;
    public int bulletCount = 5;
    private int countBullet = 5;
    public bool isCollected = false;
    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Fire1") && bulletCount > 0)
        {
            Shoot();
            isCollected = false;
        }

        timeStart += Time.deltaTime;
        if (timeStart >= per_second_increment && countBullet > 3)
        {
            timeStart = 0f;
            countBullet -= 1;
        }

        if(bulletCount == 0 && isCollected == false)
        {
            isCollected = true;
            StartCoroutine(putBackBulletCount());
        }
    }
    void Shoot(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletCount -= 1;
    }

    IEnumerator putBackBulletCount()
    {
        yield return new WaitForSeconds(5);
        bulletCount = countBullet;

    }

}
