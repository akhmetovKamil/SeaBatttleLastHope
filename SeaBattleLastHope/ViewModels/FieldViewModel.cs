using System.Collections.ObjectModel;
using DynamicData;
using SeaBattleLastHope.Models;

namespace SeaBattleLastHope.ViewModels;

public class FieldViewModel : ViewModelBase
{
    public FieldModel Field { get; }
    public ObservableCollection<FieldCellViewModel> Cells { get; } = new();
    public string[] Temp { get; }
    
    public FieldViewModel()
    {
        Temp = new string[5]{"12","12","12","12","12"};
        Field = new FieldModel();

        for (int  i = 0;  i < 10;  i++)
        {
            for (int  j = 0;  j < 10;  j++)
            {
                Cells.Add(new FieldCellViewModel(Field.FieldMx[i][j]));
            }
        }
    }
    
}