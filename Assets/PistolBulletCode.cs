using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBulletCode : MonoBehaviour
{
    public int speed = 3; 
    private Vector2 destination;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 destination;       //create a vector called mousePos
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);           //change the value of mousePos
        //Vector2 direction = mousePos - (Vector2)transform.position;
        //direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)transform.forward*speed*Time.deltaTime;
    }
}
