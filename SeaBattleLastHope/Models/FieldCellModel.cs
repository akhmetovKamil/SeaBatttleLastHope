namespace SeaBattleLastHope.Models;

public class FieldCellModel
{
    public int X { get; set; }
    public int Y { get; set; }
    public CellState State { get; set; } = CellState.Regular;

    public FieldCellModel(int x, int y)
    {
        X = x;
        Y = y;
    }
}