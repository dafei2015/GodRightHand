#region

using UnityEngine;

#endregion

public class Initializer : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        StartGame();
    }

    /// <summary>
    ///     初始化游戏
    /// </summary>
    private void StartGame()
    {
        this.gameObject.AddComponent<ResMgr>();
        this.gameObject.AddComponent<UIMgr>();
        this.gameObject.AddComponent<AppMgr>();
        EntranceSceneCtrl.Instance.SendEvent(EventDef.TableDataFinish);
    }
}