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
        SwitchView(ViewType.ParallelDimension, KeyCode.J);
        SwitchView(ViewType.BurningLight, KeyCode.K);
        SwitchView(ViewType.Masquerade, KeyCode.L);
    }

    private void SwitchView(ViewType view, KeyCode keyCode)
    {
        if (OnViewSwitched == null)
            return;
        if (Input.GetKeyDown(keyCode))
        {
            if (CurrentView.ViewType != view)
                CurrentView = SetView(view);
            else
                CurrentView = SetView(ViewType.UsualView);
            CurrentView.ApplyView();
            OnViewSwitched();
        }

    }

    public View SetView(ViewType viewType)
    {
        switch (viewType) 
        {
            case ViewType.ParallelDimension:
                return new ParallelDimension();
            case ViewType.BurningLight:
                return new BurningLight();
            case ViewType.Masquerade:
                return new Masquerade();
            default:
                return new UsualView();
        }
    }
}
