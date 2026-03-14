using UnityEngine;

public class OxygenSystem : MonoBehaviour
{
    public float oxygen = 60f;

    void Update()
    {
        oxygen -= Time.deltaTime;

        if (oxygen <= 0)
        {
            Debug.Log("Out of oxygen!");
            Time.timeScale = 0;
        }
    }
}