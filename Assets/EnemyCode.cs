using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2.5f;

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
        Destroy(gameObject);
        GameMasterCode.score++;
    }
}
