using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainInterraction : MonoBehaviour
{

    [SerializeField]
    private GameObject terrain, water, treeModel_1,treeModel_2, torchModel_1, torchModel_2;

    [SerializeField]
    private MeshRenderer terrainRenderer, waterRenderer;

    [SerializeField]
    private Material rockMaterial, grassMaterial, waterMaterial, lavaMaterial;

    private int terrainNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        torchModel_1.SetActive(false);
        torchModel_2.SetActive(false);
        terrainRenderer = terrain.GetComponent<MeshRenderer>();
        waterRenderer = water.GetComponent<MeshRenderer>();

        terrainRenderer.material = grassMaterial;
        waterRenderer.material = waterMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            terrainNumber++;
        }


        switch (terrainNumber)
        {
            case (1):
                disableForest();
                enableCave();


                break;
            case (2):
                disableCave();
                enableForest();

                break;
            case (3):
                terrainNumber = 1;
                break;
        }


    }

    void enableForest()
    {
        terrainRenderer.material = grassMaterial;
        waterRenderer.material = waterMaterial;
        treeModel_1.SetActive(true);
        treeModel_2.SetActive(true);
    }

    void disableForest()
    {
        treeModel_1.SetActive(false);
        treeModel_2.SetActive(false);
    }

    void enableCave()
    {
        terrainRenderer.material = rockMaterial;
        waterRenderer.material = lavaMaterial;
        torchModel_1.SetActive(true);
        torchModel_2.SetActive(true);
    }

    void disableCave()
    {
        torchModel_1.SetActive(false);
        torchModel_2.SetActive(false);
    }
}
