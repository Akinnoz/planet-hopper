using UnityEngine;
using UnityEngine.UI;

public class OxygenSystem : MonoBehaviour
{
    public float maxOxygen = 100f;
    public float oxygen;

    public float drainRate = 5f;

    public Slider oxygenBar;

    void Start()
    {
        oxygen = maxOxygen;
        oxygenBar.maxValue = maxOxygen;
        oxygenBar.value = oxygen;
    }

    void Update()
    {
        oxygen -= drainRate * Time.deltaTime;

        oxygenBar.value = oxygen;

        if (oxygen <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Out of Oxygen!");
        Time.timeScale = 0f;
    }
}