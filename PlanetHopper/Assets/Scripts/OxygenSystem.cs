using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OxygenSystem : MonoBehaviour
{
    public float maxOxygen = 300f;
    public float oxygen;

    public float drainRate = 5f;

    public Slider oxygenBar;

    public Image warningOverlay;
    //public AudioSource warningSound;

    public float warningLevel = 60f;

    bool isGameOver = false;

    void Start()
    {
        oxygen = maxOxygen;

        oxygenBar.maxValue = maxOxygen;
        oxygenBar.value = oxygen;

        warningOverlay.color = new Color(1, 0, 0, 0);
    }

    void Update()
    {
        if (isGameOver) return;

        oxygen -= drainRate * Time.deltaTime;

        oxygenBar.value = oxygen;

        // เตือนตอน oxygen ต่ำ
        if (oxygen <= warningLevel)
        {
            FlashWarning();

            //if (!warningSound.isPlaying)
                //warningSound.Play();
        }

        if (oxygen <= 0)
        {
            GameOver();
        }
    }

    void FlashWarning()
    {
        float alpha = Mathf.PingPong(Time.time * 2f, 0.5f);

        warningOverlay.color = new Color(1, 0, 0, alpha);
    }

    void GameOver()
    {
        isGameOver = true;

        SceneManager.LoadScene("LoseScene");
    }
}