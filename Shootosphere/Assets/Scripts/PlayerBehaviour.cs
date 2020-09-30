using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 150.0f;
    private CharacterController controller;
    public GameObject bulletPrefab;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0,Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
        Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        controller.Move(move * speed);
        this.transform.Rotate(rotation);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 5) , transform.rotation);
        }

    }
}
