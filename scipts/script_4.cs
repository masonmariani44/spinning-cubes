using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_4 : MonoBehaviour
{
    public Vector3 rotation_rate;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 1);
        rotation_rate = new Vector3(0, Random.Range(50.0f, 200.0f), 0);

        const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        string build_str = "";
        int str_len = Random.Range(5, 20);
        for (int i = 0; i < str_len; i++) {
            build_str += chars[Random.Range(0, 35)];
        }
        this.name = build_str;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0) {
            transform.Rotate(-rotation_rate * Time.deltaTime);
        }
        else {
            transform.Rotate(rotation_rate * Time.deltaTime);
        }
    }
}
