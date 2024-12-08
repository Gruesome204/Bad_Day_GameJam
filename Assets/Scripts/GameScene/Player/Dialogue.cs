using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
   public GameObject DialogueCanvas;
   public Rigidbody2D Ridgitbody2D;
   public TextMeshProUGUI _Dialogue;
   public Button b;


    [SerializeField] private AudioSource NPCTalkSoundEffect;


    public bool DialogueIsOpen;

    private void Start() 
   {
        DialogueIsOpen = false;

        b.onClick.AddListener(Click);

        Debug.Log("Dialogue Start");

        _Dialogue.text = "Start Dialogue";

  

    }

    private void Update()
    {

    }

    void Click()
    {
        //Text der beim Drücken des Buttons erscheint
        Debug.Log("Dialogue Test Click");

        Ridgitbody2D.constraints = RigidbodyConstraints2D.None;
        Ridgitbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
       
        DialogueCanvas.SetActive(false);
        DialogueIsOpen = false;
    }


    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Dialogue Collision NPC");

        //Text der beim nähren des NPCS erscheint


        if (other.gameObject.CompareTag("NPC1"))
        {
            _Dialogue.text = "Es ist gefährlich sich außerhalb der Stadt zu befinden. Hier ein paar Tipps: Springen: Space\nSchießen: Linke Maustaste"; 
  
            DialogueIsOpen = true;
            NPCTalkSoundEffect.Play();

            Debug.Log("Enable Canvas");
            DialogueCanvas.SetActive(true);

            Ridgitbody2D.constraints = RigidbodyConstraints2D.FreezePositionX;
            other.GetComponent<BoxCollider2D>().enabled = false;
        }



        if (other.gameObject.CompareTag("NPC2"))
        {

            _Dialogue.text ="Nach dem Zauberwald, kommt das Schloss der dunklen Hexe. Sicher das du weiter gehen willst?";


            DialogueIsOpen = true;
            NPCTalkSoundEffect.Play();

             Debug.Log("Enable Canvas");
             DialogueCanvas.SetActive(true);
              
             Ridgitbody2D.constraints = RigidbodyConstraints2D.FreezePositionX;
             other.GetComponent<BoxCollider2D>().enabled = false;
        }

        if (other.gameObject.CompareTag("NPC3"))
        {

            _Dialogue.text = "Hat dich die Hexe geschickt? Schade für dich das du es nicht mehr zurueck schaffen wirst.";

            DialogueIsOpen = true;

            Debug.Log("Enable Canvas");
            DialogueCanvas.SetActive(true);

            //transform.Find("Portrait").gameObject.SetActive(true);

            Ridgitbody2D.constraints = RigidbodyConstraints2D.FreezePositionX;
            other.GetComponent<BoxCollider2D>().enabled = false;

        }

    }

 
}
