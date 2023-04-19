using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;


namespace Monopoli
{

    public class PlayerInfo : IPlayerInfo
{
    public string name {get; set;} //nama si player
    public int position {get;set;} //posisi player pada board
    public bool jail {get; set;} // jika benar maka player akan berada di penjara
    public Avatar playerAvatar {get;set;} // menentukan warna player di console
}
    class Player
{
   public PlayerInfo playerInfo;
    
        public Player (PlayerInfo playerInfo)
        {
            this.playerInfo = playerInfo;
        }
}
}