using UnityEngine;

public class EntranceSceneCtrl : EventNode, IEventListener
{
    public static EntranceSceneCtrl Instance { get; private set; }
    public bool HandleEvent(int id, object param1, object param2)
    {
        switch (id)
        {
            case EventDef.TableDataFinish:
                Log.Debug("开始游戏");
                break;
        }
        return false;
    }

    public int EventPriority()
    {
        return 0;
    }

    private void Awake()
    {
        Instance = this;
        //挂载一个消息
        AttachEventListener(EventDef.TableDataFinish, this);
    }

    // Use this for initialization
    private void Start()
    {
    }

    private void OnDestroy()
    {
        //卸载一个消息
        DetachEventListener(EventDef.TableDataFinish, this);
    }
}