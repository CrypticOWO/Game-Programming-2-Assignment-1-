using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2.5f;

    public GameObject EnemyDeathEffect;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        speed = 2.5f;
    }

    // Update is called once per frame
	void Update () 
	{
	    transform.position = Vector3.MoveTowards(transform.position,Player.transform.position,speed*Time.deltaTime);
	}

    public void BeatEnemy()
    {
        // Spawn GameObject
        Instantiate(EnemyDeathEffect, transform.position, transform.rotation);

        // Destroy after the effect
        Destroy(gameObject);

        GameMasterCode.score++;
    }


}
