using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
       	{
	 	if (transform.position.z < 6f)
         	{
           	 Debug.Log("pressed the d key to move to the right");
          	 transform.position += new Vector3(0f, 0f, 1f);
                }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
       	 	if (transform.position.z > -1f)
         	{
           	 Debug.Log("pressed the d key to move to the right");
          	 transform.position -= new Vector3(0f, 0f, 1f);
                }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
       	 	if (transform.position.x > -22.5f)
         	{
           	 Debug.Log("pressed the a key to move to the right");
          	 transform.position -= new Vector3(1f, 0f, 0f);
                }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
       	 	if (transform.position.x < -16f)
         	{
           	 Debug.Log("pressed the d key to move to the right");
          	 transform.position += new Vector3(1f, 0f, 0f);
                }
        }
        //if (OnCollisionEnter)
        //{
            //Debug.Log("pressed the d key to move to the right");
            //transform.position += new Vector3(0f, 7f, 0f);
        //}        
        
    }
}