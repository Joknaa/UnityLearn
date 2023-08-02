using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 20.0f;
   
    void Update() {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}