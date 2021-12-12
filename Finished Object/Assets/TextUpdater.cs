using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUpdater : MonoBehaviour
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
            displayText.text = "You are stuck in a familiar dream.";
            }
        else if (currText == 1){
            displayText.text = "Standing on a beach, the sun is setting.";
        }
        else if (currText == 2){
            displayText.text = "You are trying to build something. Something with an arm. Something with a heart.";
        }
        else if (currText == 3){
            displayText.text = "But before you connect one shape to the next, The Crabs wash it away.";
        }
        else if (currText == 4){
            displayText.text = "Thousands of them, moving like the sea, taking away fragments of your creation until nothing remains.";
        }
        else if (currText == 5){
            displayText.text = "Still you try. An eye. An ear.";
        }
        else if (currText == 6){
            displayText.text = "The Crabs hit you like a wave, slamming you into the sand.";
        }
        else if (currText == 7){
            displayText.text = "They knock on your head.";
        }
        else if (currText == 8){
            displayText.text = "It sounds like wood.";
        }
        else if (currText == 9){
            displayText.text = "And knock.";
        }
        else if (currText == 10){
            displayText.text = "Your head isn't made out of wood.";
        }
        else if (currText == 11){
            displayText.text = "They begin to bark.";
        }
        else if (currText == 12){
            displayText.text = "Wait a minute.";
        }
        else if (currText == 13){
            displayText.text = "This is a dream.";
        }
        else {
            displayText.text = "You wake up.";
            NextSceneButton.SetActive(true);
            NextTextButton.SetActive(false);
        }
    }

    public void clicked() {
     currText += textPerClick;
 }

}
