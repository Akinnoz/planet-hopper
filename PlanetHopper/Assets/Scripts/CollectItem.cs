using UnityEngine;

public class CollectItem : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GameManager.instance.AddScore(1);

            Destroy(gameObject);
        }
    }
}