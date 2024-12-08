using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualNovelDialogue : MonoBehaviour
{

    public int countDialogue= 0;
    bool activateClickNext = true;
    public string Text;
    public Button NextButton;
    // Start is called before the first frame update



    void Start()
      {

        //   NextButton.onClick.AddListener(NextDialogue);
    }

    void Dialogue(int countDialogue)
    {
        switch (countDialogue)
        {
            case 1:
                Text =("T1");
                break;
            case 2:
                Text = ("T2");
                break;
            case 3:
                Text = ("T3");
                break;
            case 4:
                Text = ("T4");
                break;
            default:
                break;
        }
    }


// Update is called once per frame
void Update()
    {
        if (activateClickNext == true) { 
            if (Input.GetMouseButton(0))
            {
               
                Dialogue(countDialogue);
                countDialogue++;
            //    Text = "";
                
            }
           }
        else
        {

        }


        if (countDialogue == 5)
        {
            //GameObject(InHierachy).SetActive(true);
        }
        
    }


   void NextDialogue()
    {

    }
}
