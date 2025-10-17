public class ColorNPCFactory : AbstractNPCFactory
{
    private readonly NPCType _type;

    public ColorNPCFactory(NPCType type)
    {
        _type = type;
        
    }

    public override INPC Create()
    {
        return null;
    }
}
