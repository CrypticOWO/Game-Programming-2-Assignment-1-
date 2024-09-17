using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    public GameObject Player;
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
	void Update () 
	{
	    transform.position = Vector3.MoveTowards(transform.position,Player.transform.position,1*Time.deltaTime);
	}

    public void BeatEnemy()
    {
        DestroyImmediate(GameMasterCode.Singleton.EnemyPrefab,true);
    }
}
