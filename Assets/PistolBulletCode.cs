using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBulletCode : MonoBehaviour
{
    public int speed = 10; 
    private Vector2 direction;

    public GameObject BulletTrailEffect;
    private GameObject BulletTrail;
    [SerializeField] private AudioClip[] BulletFiredSoundClips;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePos-(Vector2)transform.position).normalized;
        GameMasterCode.Singleton.PlayRandomSoundFXClip(BulletFiredSoundClips, transform, 1f);
        BulletTrail = Instantiate(BulletTrailEffect, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)direction*speed*Time.deltaTime;

        if (BulletTrail != null)
        {
            BulletTrail.transform.position = transform.position;
        }

        if (transform.position.x >= 50 || transform.position.x <= -50 || transform.position.y >= 50 || transform.position.y <= -50)
            DestroyBullet();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       EnemyCode Enemy = other.gameObject.GetComponent<EnemyCode>();
       if (Enemy != null)
       {
            Destroy(gameObject);
            Enemy.BeatEnemy();
       }
    }
    private void DestroyBullet()
    {
        // Destroy BulletTrail if it exists
        if (BulletTrail != null)
        {
            Destroy(BulletTrail);
        }

        // Destroy the bullet itself
        Destroy(gameObject);
    }
}
