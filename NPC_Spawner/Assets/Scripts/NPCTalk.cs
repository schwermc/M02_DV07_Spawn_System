using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class NPCTalk : MonoBehaviour
{
    public Client client;
    public TMP_Text npcTalk;

    private INPC m_NPC;

    public void NPCSpeak(Button button)
    {
        TMP_Text buttonText = button.GetComponentInChildren<TMP_Text>();
        NPCType emunType = (NPCType)Enum.Parse(typeof(NPCType), buttonText.text);

        if (buttonText != null)
        {
            m_NPC = client.GetNPC(emunType);
            npcTalk.text = m_NPC.Speak();
            StartCoroutine(NPCCoroutine(10f));
        }
    }

    IEnumerator NPCCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        npcTalk.text = "";
    }
}
