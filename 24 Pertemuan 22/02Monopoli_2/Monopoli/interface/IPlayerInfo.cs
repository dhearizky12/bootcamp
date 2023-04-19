namespace Monopoli
{
public interface IPlayerInfo
{
    string name {get; set;} //nama si player
    int position {get;set;} //posisi player pada board
    bool jail {get; set;} // jika benar maka player akan berada di penjara
    Avatar playerAvatar { get; set; }  // menentukan warna player di console
}
}