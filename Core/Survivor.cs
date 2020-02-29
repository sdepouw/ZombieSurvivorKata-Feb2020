namespace ZombieSurvivorKata
{
    public class Survivor
    {
        public string Name { get; set; }
        public int Wounds { get; set; }
        public bool IsDead => Wounds >= 2;
    }
}