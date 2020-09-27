using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    public float speed = 2.0f;
    public float bulletSpeed = 6.0f;
    public GameObject bulletPrefab;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("PlayerBall");
        InvokeRepeating("LaunchBullet", 2.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDirection = (player.transform.position - transform.position).normalized;
        rb.AddForce(playerDirection * speed);

    }

    private void LaunchBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 5), bulletPrefab.transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = (player.transform.position - bullet.transform.position).normalized * bulletSpeed;
    }
}
