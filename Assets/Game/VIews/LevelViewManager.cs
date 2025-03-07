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
        if (Input.GetKeyDown(KeyCode.E))
            SwitchView();
    }

    public void SwitchView()
    {
        switch (CurrentView.ViewType) 
        {
            case ViewType.UsualView:
                CurrentView = SetView(ViewType.ParallelDimension);
                break;
            case ViewType.ParallelDimension:
                CurrentView = SetView(ViewType.UsualView);
                break;
            default:
                return;
        }
        if (OnViewSwitched != null)
            OnViewSwitched();

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
