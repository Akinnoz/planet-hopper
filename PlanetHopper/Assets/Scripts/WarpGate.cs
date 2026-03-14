using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpGate : MonoBehaviour
{
    public int requiredParts = 15;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance.score >= requiredParts)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
}
