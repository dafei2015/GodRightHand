using UnityEngine;

public class UIDef : MonoBehaviour
{
    public const string MainUI = "CanvasMain";
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
            
        }
        return 0;
    }
}
