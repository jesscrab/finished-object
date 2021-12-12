using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUpdater3 : MonoBehaviour
{

    public Text displayText;
    public int currText = 0;
    public int textPerClick = 1; 
    public GameObject NextTextButton;
    public GameObject NextSceneButton;
    public Image BGImage;
    public Sprite spriteChange1;
    public Sprite spriteChange2;
    public Sprite spriteChange3;
    public Sprite spriteChange4;

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
            displayText.text = "So yeah. That’s the town. I pretty much love it here.";
            }
        else if (currText == 1){
            displayText.text = "We don’t get a lot of new comers these days, what with the eminent end of the world and all of that. But we have one last big project we’re trying to pull off before the crabs take us all.";
        
        }
        else if (currText == 2){
            displayText.text = "There are a few other studio’s that would like your help once David and I are done with you.";
        
        }
        else if (currText == 3){
            displayText.text = "The Ceramicists run the local Cafe. They do great work, you’ll find their Tea Cups in just about any house in the area, but they can get pretty distracted with customers so there’s times where you’ll be on your own.";
            BGImage.sprite = spriteChange1;
        }
        else if (currText == 4){
            displayText.text = "The local Jewelers studio doubles as a Pawn Shop, and the Master Craftsman and his Daughter are at odds, but they’ve got some of the best material in town. That is if the shops bird doesn’t snatch it away when you need it most.";
            BGImage.sprite = spriteChange2;       
        }
        else if (currText == 5){
            displayText.text = "Then there’s the Blacksmith. They keep their forge hot and their schedule meticulous. Your glass will crack under the heat if you leave it out too long, so timing is everything when finishing a project there.";
            BGImage.sprite = spriteChange3;        
        }
        else if (currText == 6){
            displayText.text = "You did good today. You should go back to the studio and get some rest. David gets in tomorrow, and that’s when the real work begins.";
            BGImage.sprite = spriteChange4;
        }
        else if (currText == 7){
            displayText.text = "…see you Esme.";
        
        }
        else {
            displayText.text = "TO BE CONTINUED";
            NextSceneButton.SetActive(true);
            NextTextButton.SetActive(false);
        }
    }

    public void clicked() {
     currText += textPerClick;
 }

}
