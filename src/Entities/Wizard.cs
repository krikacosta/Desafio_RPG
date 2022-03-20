namespace Desafio_RPG.src.Entities
{
    public class Wizard //: Hero
    {
        public Wizard(string Name, int Level, string Hero_Type)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hero_Type = Hero_Type;
        }

        public string Name;
        public int Level;
        public string Hero_Type;
        
        public override string ToString(){
            return "Name: " + this.Name + " - Level: " + this.Level + " - Hero Type: " + this.Hero_Type + "\n";
        }
        
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Atacou com sua Magia com bonus de super energia de " + Bonus + "\n";
            }else{
                return this.Name + " Atacou com sua Magia com bonus de energia de " + Bonus + "\n";
            }
        }
    }
}