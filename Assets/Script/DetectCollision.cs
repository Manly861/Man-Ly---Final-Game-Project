using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public LiveManager liveManager;
    public int pointValue;
    private AudioSource objectAudio;
    public AudioClip rockHitSound;
    public AudioClip animalHitSound;

    public ParticleSystem explosionParticle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        liveManager = FindObjectOfType<LiveManager>();
        objectAudio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHitBySmallRock()
    {
        if (CompareTag("Obstacle"))
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            scoreManager.UpdateScore(pointValue);
            objectAudio.PlayOneShot(rockHitSound, 1.0f);
            AudioSource.PlayClipAtPoint(rockHitSound, Camera.main.transform.position);
        }
        else if (CompareTag("Animal"))
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            liveManager.UpdateLiveText(-1);
            AudioSource.PlayClipAtPoint(animalHitSound, Camera.main.transform.position);
        }   
        Destroy(gameObject);    
    }   
    
}