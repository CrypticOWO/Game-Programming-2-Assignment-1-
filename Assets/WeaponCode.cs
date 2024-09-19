using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCode : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //follow mouse movement
        //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,5);
        transform.position = Player.transform.position + new Vector3(0,0,-5);

        //rotate to mouse movement
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
       EnemyCode Enemy = other.gameObject.GetComponent<EnemyCode>();
       if (Enemy != null)
       {
            Enemy.BeatEnemy();
       }
    }
}
