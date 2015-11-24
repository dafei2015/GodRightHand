using UnityEngine;

public class UIDef : MonoBehaviour
{
    public const string MainUI = "CanvasMain";

    public const string SettingsUI = "CanvasSetting";
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

    public static int GetUIOrderLayer(string uiName)
    {
        switch (uiName)
        {
            case MainUI:
                return 0;
            case SettingsUI:
                return 1;
            
        }
        return 0;
    }
}
