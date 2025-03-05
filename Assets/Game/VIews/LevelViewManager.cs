using Unity.VisualScripting;
using UnityEngine;

public class LevelViewManager : MonoBehaviour
{
    public LevelViewManager()
    {
    }
    public ViewType InitialViewType;
    public View CurrentView;

    public delegate void SwitchViewAction();
    public static event SwitchViewAction OnViewSwitched;
    void Start()
    {
        CurrentView = SetView(InitialViewType);
        OnViewSwitched();
    }
    void Update()
    {
        SwitchView();
    }
    public void SwitchView()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentView = SetView(ViewType.View1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrentView = SetView(ViewType.View2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CurrentView = SetView(ViewType.View3);
        }
        else
            return;
        CurrentView.ApplyView();
        if (OnViewSwitched != null)
            OnViewSwitched();
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
