using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_2 : MonoBehaviour
{
    public Vector3 rotation_rate;

    // Start is called before the first frame update
    void Start()
    {
        rotation_rate = new Vector3(0, Random.Range(50.0f, 200.0f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(rotation_rate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(-rotation_rate * Time.deltaTime);
        }  
    }
}
