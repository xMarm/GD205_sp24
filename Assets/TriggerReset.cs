using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReset : MonoBehaviour
{
    AudioSource deadAudioPlayer;
    public AudioClip deadAudioClip;
    Vector3 startPos;
// Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        deadAudioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        transform.position = startPos;
        deadAudioPlayer.PlayOneShot(deadAudioClip, 0.9f);
    }
}
