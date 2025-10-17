public class CityNPCFactory : AbstractNPCFactory
{
    private readonly NPCType _type;

    public CityNPCFactory(NPCType type)
    {
        _type = type;
        
    }

    public override INPC Create()
    {
        switch (_type)
        {
            case NPCType.Baker:
                INPC baker = new Baker();
                return baker;
            case NPCType.Banker:
                INPC banker = new Banker();
                return banker;
            case NPCType.Lawer:
                INPC lawer = new Lawer();
                return lawer;
        }
        return null;
    }
}
