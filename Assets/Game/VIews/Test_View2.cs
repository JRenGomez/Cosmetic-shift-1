using UnityEngine;

public class Test_View2 : View
{
    public Test_View2()
    {
        ViewType = ViewType.View2;
    }
    public override void ApplyView()
    {
        Debug.Log("This is View 2");
    }
}
