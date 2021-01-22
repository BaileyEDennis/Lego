using System;
using System.Collections.Generic;
using System.Text;

namespace Lego.Figures
{
    public class ConstructionWorker
    {
        public bool HairOrHat { get; set; } = true;
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public ConstructionWorker(bool hairOrHat, string head, string torso, string legs, string accessories)
        {
            HairOrHat = hairOrHat;
            Head = head;
            Torso = torso;
            Legs = legs;
            Accessories = accessories;
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void DoubleJump()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            Console.WriteLine("Construction worker hits with a pipe wrench for 5 damage");
        }
        public void SpecialAttack()
        {
            Console.WriteLine("Construction worker uses Weld! 10 fire damage!");
        }
        public void Look()
        {
            throw new NotImplementedException();
        }
        public void Inspect()
        {
            string HatHair;
            if (HairOrHat)
            {
                HatHair = "Hat";
            }
            else
            {
                HatHair = "Hair";
            }
            Console.WriteLine($"You are equipped with {HatHair} on your head, A {Head} head, {Torso} on body, {Legs} on legs, and have {Accessories}");
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
