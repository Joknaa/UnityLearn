using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour {
    public float speed;
    public float xRange;
    public float horizontalInput;

    private void Update() {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * (horizontalInput * speed * Time.deltaTime));
        
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }
}