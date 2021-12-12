using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScenario : MonoBehaviour
{
    
    public GameObject CraftButton;
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;
    public GameObject Slot7;
    public GameObject Slot8;
    public string nextScene;
    public bool isImg1On;
    public Image img1;
    public bool isImg2On;
    public Image img2;
    public bool isImg3On;
    public Image img3;
    public bool isImg4On;
    public Image img4;   
    public Text onboardingText;
    public bool isTextOn;


    // Start is called before the first frame update
    void Start()
    {
        CraftButton.SetActive(false);
        Debug.Log(Slot1.transform.childCount);
        img1.enabled = true;
        isImg1On = true;
        img2.enabled = false;
        isImg2On = false;
        img3.enabled = false;
        isImg3On = false;
        img4.enabled = false;
        isImg4On = false;
        onboardingText.enabled = true;
        isTextOn = true;

    }


    void Update(){
        Debug.Log(Slot1.transform.childCount + 
            Slot2.transform.childCount + 
            Slot3.transform.childCount + 
            Slot4.transform.childCount + 
            Slot5.transform.childCount + 
            Slot6.transform.childCount + 
            Slot7.transform.childCount + 
            Slot8.transform.childCount);

        
        if (Slot5.transform.childCount + Slot6.transform.childCount + 
        Slot7.transform.childCount + Slot8.transform.childCount > 0 && isImg2On == false){
            Debug.Log("hi");
            img2.enabled = true;
            isImg2On = true;
            onboardingText.enabled = false;
            isTextOn = false;

        }
        else if (Slot5.transform.childCount + Slot6.transform.childCount + 
        Slot7.transform.childCount + Slot8.transform.childCount > 1 && isImg3On == false){
            Debug.Log("hi");
            img3.enabled = true;
            isImg3On = true;          
        }
        else if (Slot5.transform.childCount + Slot6.transform.childCount + 
        Slot7.transform.childCount + Slot8.transform.childCount > 2 && isImg4On == false){
            Debug.Log("hi");
            img4.enabled = true;
            isImg4On = true;          
        }
        /*
        else if (Slot6.transform.childCount == 1 && isImg2On == false){
            Debug.Log("yo");
            img2.enabled = true;
            isImg2On = true;
        }
        else if (Slot7.transform.childCount == 1 && isImg3On == false){
            Debug.Log("ye");
            img3.enabled = true;
            isImg3On = true;
        }
        else if (Slot8.transform.childCount == 1 && isImg4On == false){
            Debug.Log("ah");
            img4.enabled = true;
            isImg4On = true;
        }*/
        else if (Slot1.transform.childCount + 
            Slot2.transform.childCount + 
            Slot3.transform.childCount + 
            Slot4.transform.childCount + 
            Slot5.transform.childCount + 
            Slot6.transform.childCount + 
            Slot7.transform.childCount + 
            Slot8.transform.childCount > 7){
            CraftButton.SetActive (true);
        }
        else{
            CraftButton.SetActive (false);
        }

    }

    //public void clickThisButton()
     //{
       //    CraftButton.SetActive (true);

     //}


    public void NextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

}
