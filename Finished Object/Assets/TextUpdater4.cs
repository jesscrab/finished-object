using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUpdater4 : MonoBehaviour
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
            displayText.text = "Lou walks you past beach side shops and community art projects. ";
            }
        else if (currText == 1){
            displayText.text = "You arrived so late last night you didn’t get a good look at this sleepy little town. The Post Card said that every Community Member was a Craftsperson, and you’re starting to believe it.";
        
        }
        else if (currText == 2){
            displayText.text = "There is not a single detail of this boardwalk that wasn’t the result of multiple disciplines loving care.";
        
        }
        else {
            displayText.text = "He turns onto a well worn path down to the beach. You see a Soldier Crab bury itself with programmed grace. He looks out at the sea.";
            NextSceneButton.SetActive(true);
            NextTextButton.SetActive(false);
        }
    }

    public void clicked() {
     currText += textPerClick;
 }

}
