using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMessage : MonoBehaviour
{
    public TextMeshProUGUI Dia;
    public int ind;
    public float TalkingSpeed;
    public string[] Speaking;
    public bool TalkingArea;
    public float Speed;
    public bool Talking;
    public bool StopTalking;

    // Start is called before the first frame update
    void Start()
    {
        Talking = false;
        Dia.text = string.Empty;
        TalkingArea = false;
        ind = -1;
    }

    void Update()
    {
        //Conversation//
        if (Input.GetKeyDown(KeyCode.B) && (TalkingArea == true) && ((Dia.text == string.Empty) || (Dia.text == Speaking[ind]))
            && (Dia.text != Speaking[Speaking.Length-1]))
        {
            Dia.text = string.Empty;
            Talking = true;
            StartDia();
        }
        //Interrupt
        else if (Input.GetKeyDown(KeyCode.B) && (Dia.text != string.Empty) && (Dia.text != Speaking[Speaking.Length-1]))
        {
            Dia.text = Speaking[ind];
            StopTalking = true;
        }
        
        //Stop Conversation//
        else if ((Input.GetKeyDown(KeyCode.B) is true) && (Dia.text == Speaking[Speaking.Length - 1]))
        {
            Talking = false;
            Dia.text = string.Empty;
            StopTalking = false;
            ind = -1;
        }
    }

    void StartDia()
    {
        ind += 1;
        StartCoroutine(Text1());
    }
    IEnumerator Text1()
    {
        foreach (char c in Speaking[ind].ToCharArray())
        {
            if(StopTalking == true)
            {
                break;
            }
            Dia.text += c;
            yield return new WaitForSeconds(TalkingSpeed);
        }
        StopTalking = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TalkingArea = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        TalkingArea = false;
    }
}
