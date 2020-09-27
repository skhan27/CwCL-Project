using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletBehaviour : MonoBehaviour
{
    public int upperBound = 39;
    public int lowerBound = -39;
    public int rightBound = 29;
    public int leftBound = -29;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBound || transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > rightBound || transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
}
