using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterCode : MonoBehaviour
{
    public static GameMasterCode Singleton;
    public static int score = 0;
    public GameObject EnemyPrefab;
    //public GameObject ItemPrefab;
    public float EnemyTimer = 0;
    //public float ItemTimer = 30;

    // Start is called before the first frame update
    void Start()
    {
        Singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyTimer -= Time.deltaTime;
        //ItemTimer -= Time.deltaTime;

        if (EnemyTimer <= 0)
        {
            //Vector3 where = new Vector3(Random.Range(-45f, 45f), Random.Range(-45f, 45f), 0);
            Vector3 where = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
            Instantiate(EnemyPrefab, where, Quaternion.identity);
            EnemyTimer = 1;
        }
        //if (ItemTimer <= 0)
        {
            //Vector3 where = new Vector3(Random.Range(-30f, 30f), Random.Range(-30f, 30f), 0);
            //Instantiate(ItemPrefab, where, Quaternion.identity);
            //ItemTimer = 30;
        }
    }
}
