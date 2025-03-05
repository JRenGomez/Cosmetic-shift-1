using Unity.VisualScripting;
using UnityEngine;

public class LevelViewManager : MonoBehaviour
{
    public LevelViewManager()
    {
    }
    public ViewType InitialViewType;
    public View CurrentView;
    void Start()
    {
        CurrentView = SetView(InitialViewType);
    }
    void Update()
    {
        SwitchViewToView1();
        SwitchViewToView2();
        SwitchViewToView3();
    }
    public void SwitchViewToView1()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentView = SetView(ViewType.View1);
            CurrentView.ApplyView();
        }
    }
    public void SwitchViewToView2()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentView = SetView(ViewType.View2);
            CurrentView.ApplyView();
        }
    }
    public void SwitchViewToView3()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentView = SetView(ViewType.View3);
            CurrentView.ApplyView();
        }
    }
    public View SetView(ViewType viewType)
    {
        switch (viewType) 
        {
            case ViewType.View1:
                return new Test_View1();
            case ViewType.View2:
                return new Test_View2();
            case ViewType.View3:
                return new Test_View3();
            default:
                return new Test_View1();
        }
    }
}
