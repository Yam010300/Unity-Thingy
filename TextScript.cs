using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    Dictionary<string, string[]> Conversation = new Dictionary<string, string[]>();

    TextMeshProUGUI TextMessage;
    public int TextIndex;
    public float TextSpeed;
    public string TalkingID;

    // Start is called before the first frame update
    void Start()
    {
        TextMessage = GetComponent<TextMeshProUGUI>();
        Conversation.Add("Daniel01", new string[] { "Hello Welcome to Fallen Land, my name is Daniel and I hate mylife","Why the Fuck you create me" });

        TextMessage.text = string.Empty;
        TextIndex = -1;
        TextSpeed = 0.05f;
        TalkingID = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (TalkingID != string.Empty && (TextMessage.text == string.Empty || TextMessage.text == Conversation[TalkingID][TextIndex]) && Input.GetKeyDown(KeyCode.B)
            && TextIndex != Conversation[TalkingID].Length-1)
        {
            TextMessage.text = string.Empty;
            TextIndex += 1;
            Talking();
        }
        else if (TextMessage.text != string.Empty && Input.GetKeyDown(KeyCode.B) == true && TextMessage.text != Conversation[TalkingID][TextIndex])
        {
            StopAllCoroutines();
            TextMessage.text = Conversation[TalkingID][TextIndex];
        }
        else if (Input.GetKeyDown(KeyCode.B) == true && TextIndex == Conversation[TalkingID].Length-1)
        {
            TextIndex = -1;
            TextMessage.text = string.Empty;
        }
    }

    void Talking()
    {
        StartCoroutine(SpeechCount());
    }
    IEnumerator SpeechCount()
    {
        foreach (char c in Conversation[TalkingID][TextIndex])
        {
            TextMessage.text += c;
            yield return new WaitForSeconds(TextSpeed);
        }
    }
}
