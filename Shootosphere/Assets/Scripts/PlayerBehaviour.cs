using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float speed = 20.0f;
    private CharacterController controller;
    public GameObject bulletPrefab;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        controller.Move(new Vector3(1 * horizontalInput, -5, 1 * forwardInput) * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 5) , bulletPrefab.transform.rotation);
        }

    }
}
