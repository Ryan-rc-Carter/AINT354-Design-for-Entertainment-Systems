using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformInterraction : MonoBehaviour
{
    
    [SerializeField]
    private float rotationMultiplier = 50f;

    [SerializeField]
    private float smoothing = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, rotationMultiplier * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, -rotationMultiplier * Time.deltaTime);
        }

    }
}
