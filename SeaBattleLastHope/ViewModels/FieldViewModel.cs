using SeaBattleLastHope.Models;

namespace SeaBattleLastHope.ViewModels;

public class FieldViewModel : ViewModelBase
{
    public FieldModel Field { get; }
    
    public string[] Temp { get; }
    public FieldCellModel[] FieldOneLine { get; }
    
    public FieldViewModel()
    {
        Temp = new string[5]{"12","12","12","12","12"};
        Field = new FieldModel();
        FieldOneLine = Field.getInOneLine();
    }
    
}