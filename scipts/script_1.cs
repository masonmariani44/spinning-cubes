using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_1 : MonoBehaviour
{
    public Vector3 rotation_rate;

    void Start()
    {
        rotation_rate = new Vector3(0, 100, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(rotation_rate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(-rotation_rate * Time.deltaTime);
        }
        
    }
}
