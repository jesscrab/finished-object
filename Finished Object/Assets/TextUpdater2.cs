using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUpdater2 : MonoBehaviour
{

    public Text displayText;
    public int currText = 0;
    public int textPerClick = 1; 
    public GameObject NextTextButton;
    public GameObject NextSceneButton;

    // Start is called before the first frame update
    void Start()
    {
        displayText.text = "hi";
        NextSceneButton.SetActive(false);
        NextTextButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (currText == 0){
            displayText.text = "You’re late. I let myself in.";
            }
        else if (currText == 1){
            displayText.text = "Wait, did you just wake up?";
        
        }
        else {
            displayText.text = "And you haven’t even set up your tools.";
            NextSceneButton.SetActive(true);
            NextTextButton.SetActive(false);
        }
    }

    public void clicked() {
     currText += textPerClick;
 }

}
