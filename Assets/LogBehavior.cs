using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        {
            Debug.Log("Log Spam");
            transform.position += new Vector3(0.02f, 0f, 0f);
        }
    }
}