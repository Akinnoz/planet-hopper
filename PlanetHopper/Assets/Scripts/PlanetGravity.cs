using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravityForce = 25f;

    Rigidbody rb;
    GameObject[] planets;

    Transform currentPlanet;   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        planets = GameObject.FindGameObjectsWithTag("Planet");
    }

    void FixedUpdate()
    {
        Transform nearestPlanet = GetNearestPlanet();


        if (currentPlanet != nearestPlanet)
        {
            currentPlanet = nearestPlanet;

            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        Vector3 gravityDir = (nearestPlanet.position - transform.position).normalized;

        rb.AddForce(gravityDir * gravityForce, ForceMode.Acceleration);

        transform.up = -gravityDir;
    }

    Transform GetNearestPlanet()
    {
        Transform nearest = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject planet in planets)
        {
            float dist = Vector3.Distance(transform.position, planet.transform.position);

            if (dist < minDistance)
            {
                minDistance = dist;
                nearest = planet.transform;
            }
        }

        return nearest;
    }
}