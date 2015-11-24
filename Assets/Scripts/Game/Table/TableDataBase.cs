#region

using UnityEngine;

#endregion

/// <summary>
///     数据读取基类
/// </summary>
public class TableDataBase : IResLoadListener
{
    public string TableName { get; set; }

    public TableDataBase(string tableName)
    {
        this.TableName = tableName;
        TableDataMgr.Instance.LoadTables.Add(this);
    }

    public void Finish(object asset)
    {
        TextAsset text = asset as TextAsset;
        if (text == null)
        {
            Log.Debug("读取配置表失败");
        }
        else
        {
            ExtractJson(text.text);
        }
        TableDataMgr.Instance.LoadTables.Remove(this);

        //数据全部加载完成后，开始游戏
        if (TableDataMgr.Instance.LoadTables.Count == 0)
        {
            EntranceSceneCtrl.Instance.SendEvent(EventDef.TableDataFinish);            
        }
    }

    public void Failure()
    {
    }

    /// <summary>
    /// 解析json数据
    /// </summary>
    /// <param name="json">json字符串</param>
    protected virtual void ExtractJson(string json)
    {
        
    }
}