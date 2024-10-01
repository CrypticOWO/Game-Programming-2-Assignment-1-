using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCode : MonoBehaviour
{
    public float Timer = 0.6f;
    public ParticleSystem PS;

    // Start is called before the first frame update
    void Start()
    {
        PS.Emit(1);
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
