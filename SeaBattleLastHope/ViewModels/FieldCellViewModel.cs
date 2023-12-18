using SeaBattleLastHope.Models;

namespace SeaBattleLastHope.ViewModels;

public class FieldCellViewModel : ViewModelBase
{
    private FieldCellModel _cell;

    public FieldCellViewModel(FieldCellModel cell)
    {
        _cell = cell;
    }
}