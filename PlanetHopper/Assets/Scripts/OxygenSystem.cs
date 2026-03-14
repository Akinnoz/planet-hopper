using UnityEngine;
using UnityEngine.UI;

public class OxygenSystem : MonoBehaviour
{
    public float oxygen = 100f;
    public float drainRate = 5f;

    public Slider oxygenBar;

    void Update()
    {
        oxygen -= drainRate * Time.deltaTime;

        oxygenBar.value = oxygen;

        if (oxygen <= 0)
        {
            Debug.Log("Out of Oxygen!");
        }
    }
}