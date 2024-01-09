using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform pivot;
    [SerializeField] private GameObject bulletPrefab;

    [SerializeField] private string enemy_tag;

    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, pivot.position, Quaternion.identity);

        bullet.GetComponent<Bullet>().SetBullet(enemy_tag, gameObject.transform.right);
  
    }

}
