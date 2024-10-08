using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMasterCode : MonoBehaviour
{
    public static GameMasterCode Singleton;
    public static int score = 0;
    public TextMeshPro Text;
    public GameObject EnemyPrefab;
    //public GameObject ItemPrefab;
    public float EnemyTimer = 0;
    //public float ItemTimer = 30;

    [SerializeField] private AudioSource soundFXObject;

    // Start is called before the first frame update
    void Start()
    {
        Singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Score: "+score;

        EnemyTimer -= Time.deltaTime;
        //ItemTimer -= Time.deltaTime;

        if (EnemyTimer <= 0)
        {
            Vector3 where = new Vector3(Random.Range(-45f, 45f), Random.Range(-45f, 45f), 0);
            Instantiate(EnemyPrefab, where, Quaternion.identity);
            EnemyTimer = 0.25f;
        }
        //if (ItemTimer <= 0)
        {
            //Vector3 where = new Vector3(Random.Range(-30f, 30f), Random.Range(-30f, 30f), 0);
            //Instantiate(ItemPrefab, where, Quaternion.identity);
            //ItemTimer = 30;
        }
    }

    public void PlayRandomSoundFXClip(AudioClip[] audioClip, Transform spawnTransform, float volume)
    {

        //Assign Index
        int rand = Random.Range(0, audioClip.Length);

        //Spawn Gameobject
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        //Assign Audio Clip
        audioSource.clip = audioClip[rand];

        //Assign Volume
        audioSource.volume = volume;  

        //Play Sound
        audioSource.Play();

        //Length of Cound Clip
        float clipLength = audioSource.clip.length;

        //Destroy
        Destroy(audioSource.gameObject, clipLength);
    }
}
