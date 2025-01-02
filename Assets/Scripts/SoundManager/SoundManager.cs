using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip ShootingSound;
    public AudioClip GameOverSound;
    public AudioClip SpawnSound;
    public AudioClip PlayerWalking;
    public AudioSource audioSource;


    // Start is called before the first frame update
    public static SoundManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayShootingSound()
    {
        audioSource.PlayOneShot(ShootingSound);
        

    }


    public void PlayGameOverSound()

    {

        audioSource.PlayOneShot(GameOverSound);

    }

    public void PlayPlayerWalkingSound()

    {

        audioSource.PlayOneShot(PlayerWalking);

    }



}
