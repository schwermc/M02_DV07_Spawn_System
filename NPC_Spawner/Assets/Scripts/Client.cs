using UnityEngine;

public class Client : MonoBehaviour
{
    public INPC m_VNPC;
    public INPC m_CNPC;

    void Start()
    {
        var types = new NPCType();
        m_VNPC = GetVNPC(types);
        m_CNPC = GetCNPC(types);
    }

    public INPC GetVNPC(NPCType type)
    {
        var npcType = new VillagersNPCFactory(type);
        return npcType.Create();
    }

    public INPC GetCNPC(NPCType type)
    {
        var npcType = new CityNPCFactory(type);
        return npcType.Create();
    }
}
