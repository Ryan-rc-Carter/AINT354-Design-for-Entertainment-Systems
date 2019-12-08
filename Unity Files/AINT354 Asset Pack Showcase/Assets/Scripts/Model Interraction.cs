using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInterraction : MonoBehaviour    
{

    private Transform modelPlatform;

    [SerializeField]
    private float rotationMultiplier = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        modelPlatform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            modelPlatform.Rotate(Vector3.right * Time.deltaTime * rotationMultiplier);
        }
    }
}
