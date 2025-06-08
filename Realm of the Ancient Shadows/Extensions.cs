public static class Extensions
{
    public static bool IsAlive(this Character character)
    {
        return character.Health > 0;
    }
}
