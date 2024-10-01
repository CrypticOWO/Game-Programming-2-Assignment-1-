using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCode : MonoBehaviour
{
    public ParticleSystem Effect;
    private float particleLength = 0;

    // Start is called before the first frame update
    void Start()
    {
        Effect.Play();    
        particleLength = Effect.main.duration;
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy after the effect
        Destroy(Effect.gameObject, particleLength);
    }
}
