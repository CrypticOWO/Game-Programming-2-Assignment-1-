using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBulletCode : MonoBehaviour
{
    public int speed = 10; 
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePos-(Vector2)transform.position).normalized;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)direction*speed*Time.deltaTime;

        if (transform.position.x >= 50 || transform.position.x <= -50 || transform.position.y >= 50 || transform.position.y <= -50)
            Destroy(gameObject);
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
}
