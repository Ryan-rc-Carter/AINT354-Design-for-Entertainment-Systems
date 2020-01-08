using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitShowcase : MonoBehaviour
{
    [SerializeField]
    private Button ui_QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        ui_QuitButton.onClick.AddListener(TaskOnClick);
    }

    //Exit application when UI button is pressed
    void TaskOnClick()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
