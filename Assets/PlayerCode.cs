using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCode : MonoBehaviour
{
    public Rigidbody2D RB;

    [SerializeField] private AudioClip DeathSoundClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0,0);
        
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = 5;  
        }
        else if (Input.GetKey(KeyCode.A))
        {
            vel.x = -5;  
        }
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = 5;  
        }
        else if (Input.GetKey(KeyCode.S))
        {
            vel.y = -5;  
        }

        RB.velocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       EnemyCode Enemy = other.gameObject.GetComponent<EnemyCode>();
       if (Enemy != null)
       {
            //Death Sound
            GameMasterCode.Singleton.PlaySoundFXClip(DeathSoundClip, transform, 1f);
       }
    }
}
