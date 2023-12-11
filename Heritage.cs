using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExoIPI_2023_2024
{
    public class Character
    {
        public string Name;
        public int Life = 100;
        protected Random Rand = new Random();

        public virtual int CalculateDamages()
        {
            int result = Rand.Next(100);
            Console.WriteLine($"Damages calculated {result}");
            return result;
        }

        public virtual void Attack(Character target)
        {
            int attackValue = CalculateDamages();
            Console.WriteLine($"{Name} attaque avec {attackValue} de dégâts.");
            target.Defense(attackValue);
        }

        public void Defense(int attackValue)
        {
            Life -= attackValue;
            Console.WriteLine($"{Name} subit {attackValue} dégâts.");
        }
    }
    
    //VIVANT
    //Gagne 1 poin de vie après chaque défense si il n'est pas mort.

    //ROBOT
    //multiplie sa base d'attaque par 2 après chaque attaque. commence à 1
    public class Robot : Character
    {

    }

    public class Magicien : Character
    {
        public override void Attack(Character target)
        {
            int attackValue = NameToDamages(target);
            Console.WriteLine($"{Name} attaque avec {attackValue} de dégâts.");
            target.Defense(attackValue);
        }

        public void Incanting()
        {
            Console.WriteLine("wololo");
        }

        private int NameToDamages(Character target)
        {
            int result = 0;
            foreach (char c in target.Name)
            {
                result += (int)c;
            }
            return result;
        }
    }

    public class Torturer : Character
    {
        public override int CalculateDamages()
        {
            int result = base.CalculateDamages();
            //we add loosed life
            result += 100 - Life;
            return result;
        }
    }




    internal class Heritage
    {
        public Heritage()
        {
            Character character1 = new Torturer();
            character1.Name = "aaaa";
            Character character2 = new Character();
            character2.Name = "personnageB";
            while (character1.Life > 0 && character2.Life > 0) 
            {
                character1.Attack(character2);
                if (character2.Life > 0)
                {
                    character2.Attack(character1);
                }
            }

            if (character1.Life <= 0) Console.WriteLine($"{character1.Name} est mort.");
            if (character2.Life <= 0) Console.WriteLine($"{character2.Name} est mort.");
        }
    }
}
