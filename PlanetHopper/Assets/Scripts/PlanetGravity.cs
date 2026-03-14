using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravityForce = 25f;

    Rigidbody rb;
    GameObject[] planets;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        planets = GameObject.FindGameObjectsWithTag("Planet");
    }

    void FixedUpdate()
    {
        Transform nearestPlanet = GetNearestPlanet();

        Vector3 direction = (nearestPlanet.position - transform.position).normalized;

        rb.AddForce(direction * gravityForce);

        transform.up = -direction;
    }

    Transform GetNearestPlanet()
    {
        Transform nearest = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject planet in planets)
        {
            float distance = Vector3.Distance(transform.position, planet.transform.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                nearest = planet.transform;
            }
        }

        return nearest;
    }
}