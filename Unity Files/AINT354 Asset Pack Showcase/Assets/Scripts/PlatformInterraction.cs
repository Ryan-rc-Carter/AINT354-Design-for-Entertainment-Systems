using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformInterraction : MonoBehaviour
{

    [SerializeField]
    private Text T_infoText;

    [SerializeField]
    private float f_rotationMultiplier = 50f;

    //[SerializeField]
    //private float f_smoothing = 5.0f;

    [SerializeField]
    private GameObject go_Skeleton, go_Player, go_Goblin, go_Mimic;

    private GameObject go_currentModel = null;

    private int int_modelNumber = 1;


    // Start is called before the first frame update
    void Start()
    {

        T_infoText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, f_rotationMultiplier * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, -f_rotationMultiplier * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            go_currentModel.SetActive(false);
            int_modelNumber++;
        }

        switch (int_modelNumber)
        {
            case (1):
                go_Skeleton.SetActive(true);
                go_currentModel = go_Skeleton;
                T_infoText.text = "Info\nA: Walk Animation\nS: Attack Animation\nD: Death Animation\n\nLeft and Right arrows: Rotate model\n\nSpace: Next Model\n\nL: Next Background";
                
                break;
            case (2):
                go_Player.SetActive(true);
                go_currentModel = go_Player;
                T_infoText.text = "Info\nA: Walk Animation\nS: Attack Animation\nHold S: Multiple Attack animations(Only Player)\nD: Death Animation\n\nLeft and Right arrows: Rotate model\n\nSpace: Next Model\n\nL: Next Background";

                break;
            case (3):
                go_Goblin.SetActive(true);
                go_currentModel = go_Goblin;
                T_infoText.text = "Info\nA: Walk Animation\nS: Attack Animation\nD: Death Animation\n\nLeft and Right arrows: Rotate model\n\nSpace: Next Model\n\nL: Next Background";

                break;
            case (4):
                go_Mimic.SetActive(true);
                go_currentModel = go_Mimic;
                T_infoText.text = "Info\nS: Attack Animation\nD: Death Animation\n\nLeft and Right arrows: Rotate model\n\nSpace: Next Model\n\nL: Next Background";

                break;
            case (5):
                int_modelNumber = 1;
                break;
        }

    }
}
