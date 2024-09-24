using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolCode : MonoBehaviour
{
    public GameObject Player;
    private List<Transform> bullets;  // List to store bullets
    public Transform bodyPrefab;        //variable to store the body

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        bullets = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //follow player movement
        transform.position = Player.transform.position + new Vector3(0,0,-5);

        //rotate to mouse movement
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    //Function to make the ship shoot
    void Shoot()
    {
        //Make the bullet
        Transform bullet = Instantiate(this.bodyPrefab);
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg;
        bullet.transform.rotation = Quaternion.Euler(0,0,angle);
        float offsetDistance = 0.75f;
        Vector3 bulletPosition = transform.position + transform.right * offsetDistance;
        bullet.position = new Vector2(bulletPosition.x, bulletPosition.y);
        bullets.Add(bullet);
    }
}
