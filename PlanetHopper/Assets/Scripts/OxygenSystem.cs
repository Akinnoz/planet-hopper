using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OxygenSystem : MonoBehaviour
{
    public float maxOxygen = 300f;
    public float oxygen;

    public float drainRate = 5f;

    public Slider oxygenBar;

    bool isGameOver = false;

    void Start()
    {
        oxygen = maxOxygen;
        oxygenBar.maxValue = maxOxygen;
        oxygenBar.value = oxygen;
    }

    void Update()
    {
        if (isGameOver) return;

        oxygen -= drainRate * Time.deltaTime;

        oxygenBar.value = oxygen;

        if (oxygen <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isGameOver = true;

        Debug.Log("Out of Oxygen!");

        SceneManager.LoadScene("LoseScene");
    }
}
