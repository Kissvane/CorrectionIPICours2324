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

        public virtual void Defense(int attackValue)
        {
            Life -= attackValue;
            Console.WriteLine($"{Name} subit {attackValue} dégâts. Sa vie est désormais de {Life}");
            if (this is I_Fragil fragil)
            {
                fragil.ApplyFragil(attackValue, this);
            }
            if (Life <= 0) Console.WriteLine($"{Name} est mort.");
        }
    }

    //VIVANT
    //Gagne 1 point de vie après chaque défense si il n'est pas mort.
    public class Alive : Character
    {
        public override void Defense(int attackValue)
        {
            base.Defense(attackValue);
            if (Life > 0)
            {
                Life++;
                Console.WriteLine($"{Name} régénère 1 point de vie. Sa vie estd ésormais de {Life}.");
            }
        }
    }

    //ROBOT
    //multiplie sa base d'attaque par 2 après chaque attaque. commence à 1
    public class Robot : Character
    {
        protected int baseAttack = 1;

        public override void Attack(Character target)
        {
            base.Attack(target);
            baseAttack *= 2;
        }

        public override int CalculateDamages()
        {
            return baseAttack;
        }
    }

    public class C18 : Robot
    {
        public override void Defense(int attackValue)
        {
            base.Defense(attackValue / 2);
        }
    }

    //T1000 c'est un robot
    //fait 2 attaques
    public class T1000 : Robot, I_Fragil
    {
        int I_Fragil.DamageMalus { get => _damageMalus; set => _damageMalus = value; }
        int I_Fragil.ThresholdMalus { get => _thresholdMalus; set => _thresholdMalus = value; }

        private int _thresholdMalus = 10;
        private int _damageMalus = 10;

        public override void Attack(Character target)
        {
            base.Attack(target);
            base.Attack(target);
        }
    }

    public class Magicien : Alive, I_Fragil
    {
        int I_Fragil.DamageMalus { get => _damageMalus; set => _damageMalus = value; }
        int I_Fragil.ThresholdMalus { get => _thresholdMalus; set => _thresholdMalus = value; }

        private int _thresholdMalus = 10;
        private int _damageMalus = 10;

        public override void Attack(Character target)
        {
            int attackValue = NameToDamages(target);
            Console.WriteLine($"{Name} attaque avec {attackValue} de dégâts.");
            target.Defense(attackValue);
        }

        public override void Defense(int attackValue)
        {
            base.Defense(attackValue);
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

    public class Torturer : Alive
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
            Character character1 = new Magicien();
            character1.Name = "aaaa";
            Character character2 = new T1000();
            character2.Name = "personnageB";
            while (character1.Life > 0 && character2.Life > 0)
            {
                character1.Attack(character2);
                if (character2.Life > 0)
                {
                    character2.Attack(character1);
                }
            }
        }
    }

    internal interface I_Fragil
    {
        internal int DamageMalus { get; set; }
        internal int ThresholdMalus { get; set; }

        internal void ApplyFragil(int damage, Character target)
        {
            if (damage >= ThresholdMalus)
            {
                Console.WriteLine($"{target.Name} est fragile. Il subit {DamageMalus} points de dégâts en plus.");
                target.Life -= DamageMalus;
            }
        }
    }

    //implémenter les classes suivante
    //InfoVirus (Robot) : inflige des dégâts doublés aux robots
    //Neandertal (Alive) : divise par 2 les dégâts si l'attaquant est un robot
    //MecaDiesel (Robot) : augmente les dégâts de 1 après chaque attaque
    //Lepreux (Alive) : diminue la vie de 1 et augmente les dégâts de 2 après chaque attaque.
    //MecaHerisson (Robot) : chaque fois qu'il est attaqué, l'attaquant reçoit un point de dégâts.
    //Herisson (Alive) : chaque fois qu'il est attaqué, l'attaquant reçoit un point de dégâts.

}
