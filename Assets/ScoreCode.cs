using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCode : MonoBehaviour
{
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //follow player movement
        transform.position = Player.transform.position + new Vector3(-5.3f,4,-5);
    }
}