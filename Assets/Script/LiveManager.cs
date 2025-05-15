using UnityEngine;
using TMPro;

public class LiveManager : MonoBehaviour
{
    public TextMeshProUGUI liveText;
    private int live;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateLiveText(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateLiveText(int Minuslive)
    {
        live += Minuslive;
        liveText.text = "Live: " + live;
    }
}
