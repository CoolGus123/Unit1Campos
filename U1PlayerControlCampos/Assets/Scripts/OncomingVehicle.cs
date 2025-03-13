using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OncomingVehicle : MonoBehaviour
{
    public float speed = 35f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the oncoming vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
