using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_audio : MonoBehaviour {
    public AudioClip background_intro;
    public AudioClip loop;
    public AudioClip paintingMoving;
    private AudioSource source;
    float vol = 1.0f;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {
        source.PlayOneShot(background_intro, vol);
    }

    // Update is called once per frame
    void Update () {
        if (!source.isPlaying) {
            source.loop = true;
            source.PlayOneShot(loop, vol);
        }
	}
}
