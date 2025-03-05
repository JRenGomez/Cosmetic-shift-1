using UnityEngine;

public class Test_View3 : View
{
    public Test_View3()
    {
        ViewType = ViewType.View3;
    }
    public override void ApplyView()
    {
        Debug.Log("This is View 3");
    }
}
