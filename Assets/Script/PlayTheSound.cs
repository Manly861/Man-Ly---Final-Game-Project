using UnityEngine;

public class PlayTheSound : MonoBehaviour
{
    public AudioSource backGroundAudio;
    public LiveManager liveManager;
    public AudioClip backGroundMusic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backGroundAudio = GetComponent<AudioSource>();
        liveManager = GetComponent<LiveManager>();
        backGroundAudio.clip = backGroundMusic;
        backGroundAudio.loop = true;
        backGroundAudio.Play();
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
