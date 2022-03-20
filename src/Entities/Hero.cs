namespace Desafio_RPG.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string Hero_Type)
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
        public virtual string Attack(){
            return this.Name + " Atacou com sua Espada" + "\n";
        }        
    }
}