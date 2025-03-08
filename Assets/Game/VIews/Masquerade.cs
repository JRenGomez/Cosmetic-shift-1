using UnityEngine;

public class Masquerade : View
{
    public Masquerade()
    {
        this.ViewType = ViewType.Masquerade;
    }
    public override void ApplyView()
    {
        Debug.Log("Masquerade view");
    }
}
