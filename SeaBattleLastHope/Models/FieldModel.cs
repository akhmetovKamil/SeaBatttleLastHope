using DynamicData;

namespace SeaBattleLastHope.Models;

public class FieldModel
{
    public FieldCellModel[][] FieldMx { get; }

    public FieldModel()
    {
        FieldMx = new FieldCellModel[10][];
        for (int i = 0; i < 10; i++)
        {
            FieldCellModel[] row = new FieldCellModel[10];
            for (int j = 0; j < 10; j++)
            {
                row[j] = new FieldCellModel(i, j);
            }
            FieldMx[i] = row;
        }
    }

    public FieldCellModel[] getInOneLine()
    {
        FieldCellModel[] ol = new FieldCellModel[100];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                ol[i * 10 + j] = FieldMx[i][j];
            }
        }

        return ol;
    }
}