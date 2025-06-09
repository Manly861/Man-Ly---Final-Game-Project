using UnityEngine;
using TMPro;

public class MissingRockCounting : MonoBehaviour
{
    public TextMeshProUGUI missingText;
    public int amount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateMissingText(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateMissingText(int amounttoAdd)
    {
        amount += amounttoAdd;
        missingText.text = "Missing: " + amount + " / 3";
    }
}
