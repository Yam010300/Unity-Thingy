using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTalking : MonoBehaviour
{
    public bool TalkingArea;
    public string TalkingID;
    GameObject TextObj;
    TextScript TextSC;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CircleCollider2D>();
        TalkingID = string.Empty;

        TextObj = GameObject.Find("Text (TMP)");
        TextSC = TextObj.GetComponent<TextScript>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TalkingArea = true;
        TextSC.TalkingID = "Daniel01";
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        TalkingArea = false;
        TextSC.TalkingID = string.Empty;
    }
}
