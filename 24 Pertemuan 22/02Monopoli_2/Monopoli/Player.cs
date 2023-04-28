using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;


namespace Monopoli
{

    public class Player : IPlayer
    {
        public string Name { get; set; } //nama si player
        public int Position { get; set; } = 0; //posisi player pada board
        public bool Jail { get; set; } = false; // jika benar maka player akan berada di penjara
        public Avatar PlayerAvatar { get; set; } // menentukan warna player di console

        public Player(string name)
        {
            this.Name = name;
        }


        public void Move(int postition)
        {
            int tempPosition = this.Position + postition;
            if (tempPosition < 40)
            {
                this.Position = tempPosition;
            }
            else
            {
                this.Position = tempPosition - 40;
            }
        }
        public int[] RollDice(Dice[] dices)
        {
            int[] rollDiceResult = new int[dices.Count()];
            rollDiceResult[0] = dices[0].RollDice();
            rollDiceResult[1] = dices[1].RollDice();
            return rollDiceResult;
        }
    }

}