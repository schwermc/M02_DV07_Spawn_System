public class VillagersNPCFactory : AbstractNPCFactory
{
    private readonly NPCType _type;

    public VillagersNPCFactory(NPCType type)
    {
        _type = type;
    }

    public override INPC Create()
    {
        switch (_type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
            case NPCType.Miner:
                INPC miner = new Miner();
                return miner;
            case NPCType.Cleric:
                INPC cleric = new Cleric();
                return cleric;
            case NPCType.Blacksmith:
                INPC blacksmith = new Blacksmith();
                return blacksmith;
        }
        return null;
    }
}