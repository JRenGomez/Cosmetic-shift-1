using UnityEngine;

public abstract class View
{
    public View()
    {

    }
    public ViewType ViewType { get; set; }
    public abstract void ApplyView();
}
