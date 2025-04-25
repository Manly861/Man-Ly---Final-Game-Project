using UnityEngine;

public class RollingRock : MonoBehaviour
{
    public float speed = 20f;
    private float rolling = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        transform.Rotate(Vector3.forward,  speed * rolling * Time.deltaTime);
    }
}
