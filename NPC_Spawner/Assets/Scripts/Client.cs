using UnityEngine;

public class Client : MonoBehaviour
{
    public INPC m_NPC;

    void Start()
    {
        var types = new NPCType();
        m_NPC = GetNPC(types);
    }

    public INPC GetNPC(NPCType type)
    {
        var npcType = new NPCFactory(type);
        return npcType.Create();
    }
}
