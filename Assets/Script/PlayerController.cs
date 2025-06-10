using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float horizontalInput;
    private float xRange = 10;

    public GameObject projectilePrefab;
    private AudioSource playerAudio;
    public AudioClip shootSound;
    public GameObject powerupIndicator;
    public bool isPowerup = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Launch a projectile from the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            playerAudio.PlayOneShot(shootSound, 1.0f);
        }
    }
    public void IntricatorActive(bool getPowerUp)
    {
        powerupIndicator.gameObject.SetActive(getPowerUp);
    }
    public void SetPowerUp(bool state)
    {
        isPowerup = state;
        IntricatorActive(isPowerup);
        StartCoroutine(PowerupCountdownRoutine());
    }
    IEnumerator PowerupCountdownRoutine()
    {
        Debug.Log("⚡ Power-up started");
        yield return new WaitForSeconds(7);
        Debug.Log("⚡ Power-up end");
        isPowerup = false;
        IntricatorActive(false);
    }
}
