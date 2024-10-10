using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    public GameObject Player;
    public float speed = 0;

    public GameObject EnemyDeathEffect;
    [SerializeField] private AudioClip[] EnemyDeathSoundClips;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
	void Update () 
	{
        speed = GameMasterCode.EnemySpeed;
        transform.position = Vector3.MoveTowards(transform.position,Player.transform.position,speed*Time.deltaTime);
	}

    public void BeatEnemy()
    {
        //Play Sound + Spawn Paritcle System
        GameMasterCode.Singleton.PlayRandomSoundFXClip(EnemyDeathSoundClips, transform, 1f);
        Instantiate(EnemyDeathEffect, transform.position, transform.rotation);

        //Destroy after the effect
        Destroy(gameObject);

        GameMasterCode.score++;
    }


}
