using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainInterraction : MonoBehaviour
{

    [SerializeField]
    private GameObject go_Village, go_Mountains, go_Foreground;

    private int int_TerrainNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        //go_Village.SetActive(false);
        //go_Mountains.SetActive(true);
        //go_Foreground.SetActive(false);
    }

    
    void Update()
    {
        //Await L Key press to increase terrainNumber
        if (Input.GetKeyDown(KeyCode.L))
        {
            int_TerrainNumber++;
        }

        //When terrainNumber changes, change background and terrain assets 
        switch (int_TerrainNumber)
        {
            case (1):
                //Village area loads
                go_Village.SetActive(true);
                go_Foreground.SetActive(true);
                go_Mountains.SetActive(false);

                break;
            case (2):
                //Cave area loads
                go_Village.SetActive(false);
                go_Foreground.SetActive(false);
                go_Mountains.SetActive(true);

                break;
            case (3):
                //reverts to village area
                int_TerrainNumber = 1;
                break;
        }


    }

    
}
