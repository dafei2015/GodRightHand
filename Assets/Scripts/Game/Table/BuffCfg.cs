#region

using System.Collections.Generic;
using LitJson;

#endregion

public class BuffCfg : TableDataBase
{
    private List<Buff> mBuffs = new List<Buff>();

    public BuffCfg(string tableName) : base(tableName)
    {
    }

    /// <summary>
    /// 解析json数据
    /// </summary>
    /// <param name="json">json字符串</param>
    protected override void ExtractJson(string json)
    {
        this.mBuffs = JsonMapper.ToObject<List<Buff>>(json);
        Log.Debug(this.mBuffs.Count);
    }
}