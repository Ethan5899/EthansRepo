using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
    public GameObject prefab;
    public float bulletSpeed = 5.0f;
    public float LifeSpan = 3.0f;
    public float shootDelay = 1.0f;
    private float timer = 0f;
    public float shootRange = 5;
	// Use this for initialization
	void Start () {
        timer += Time.deltaTime;
        timer = shootDelay;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= shootDelay)
        {
            Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
            Vector2 shootDirection = new Vector2(playerPos.x - transform.position.x, playerPos.y - transform.position.y);
            if (shootDirection.magnitude <= shootRange)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition.x += shootDirection.x * 0.2f;
                spawnPosition.y += shootDirection.y * 0.2f;

                GameObject EnemyBullet = (GameObject)Instantiate(prefab, spawnPosition, Quaternion.identity);
                //apply the velocity in the shoot direction
                EnemyBullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
                Destroy(EnemyBullet, LifeSpan);
                timer = 0;
            }
        }
	}
}
