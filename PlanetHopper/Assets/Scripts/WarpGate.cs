using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpGate : MonoBehaviour
{
    public int requiredScore = 15;

    Collider gateCollider;

    void Start()
    {
        gateCollider = GetComponent<Collider>();

        gateCollider.isTrigger = false;
    }

    void Update()
    {
        if (GameManager.instance.score >= requiredScore)
        {
            gateCollider.isTrigger = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}