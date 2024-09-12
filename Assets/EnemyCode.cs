using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    public GameObject Player;
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
	void Update () 
	{
		// face the target
		//transform.LookAt(Player);

		//get the distance between the chaser and the target
		float distance = Vector3.Distance(transform.position,Player.transform.position);

		//move towards it at rate speed.
		transform.position += transform.forward * speed * Time.deltaTime;	
	}

    public void BeatEnemy()
    {
        Destroy(GameMasterCode.Singleton.EnemyPrefab);
    }
}
