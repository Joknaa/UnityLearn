using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour {
    private float speed = 10;
    private float xRange = 10;
    private float horizontalInput;
    public GameObject projectilePrefab;

    private void Update() {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));
        
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}