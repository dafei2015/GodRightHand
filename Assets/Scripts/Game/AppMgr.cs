#region

using UnityEngine;

#endregion

public class AppMgr : MonoBehaviour
{
    private Camera mMainCamera;
    public static AppMgr Instance { get; private set; }

    public Camera MainCamera
    {
        get { return mMainCamera ?? (mMainCamera = Camera.current); }
    }

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}