namespace Monopoli
{
public interface IPlayer
{
    string Name {get; set;} //nama si player
    int Position {get;set;} //posisi player pada board
    bool Jail {get; set;} // jika benar maka player akan berada di penjara
    Avatar PlayerAvatar { get; set; }  // menentukan warna player di console
}
}