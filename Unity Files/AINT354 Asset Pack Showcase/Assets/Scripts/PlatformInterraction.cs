using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformInterraction : MonoBehaviour
{
    
    [SerializeField]
    private float rotationMultiplier = 50f;

    [SerializeField]
    private float smoothing = 5.0f;

    [SerializeField]
    private GameObject Skeleton, Player, Goblin, Mimic;

    private GameObject currentModel = null;

    private int modelNumber = 1;


    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(false);
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentModel.SetActive(false);
            modelNumber++;
        }

        switch (modelNumber)
        {
            case (1):
                Skeleton.SetActive(true);
                currentModel = Skeleton;
                
                break;
            case (2):
                Player.SetActive(true);
                currentModel = Player;
                
                break;
            case (3):
                Goblin.SetActive(true);
                currentModel = Goblin;
                break;
            case (4):
                Mimic.SetActive(true);
                currentModel = Mimic;
                break;
            case (5):
                modelNumber = 1;
                break;
        }

    }
}
