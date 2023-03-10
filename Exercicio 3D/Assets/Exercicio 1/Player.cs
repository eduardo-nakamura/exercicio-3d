using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Vel;
    public float Rot;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.Translate(Vector3.forward * Vel * Time.deltaTime); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(-Vector3.forward * Vel * Time.deltaTime); }
        if (Input.GetKey(KeyCode.D)) { transform.Rotate(Vector3.up * Rot * Time.deltaTime); }
        if (Input.GetKey(KeyCode.A)) { transform.Rotate(-Vector3.up * Rot * Time.deltaTime); }
    }
}
