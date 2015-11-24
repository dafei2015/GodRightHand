#region

using System.Collections.Generic;
using LitJson;

#endregion

public class MonsterCfg : TableDataBase
{
    private List<Monster> mMonsters = new List<Monster>();

    public MonsterCfg(string tableName)
        : base(tableName)
    {
    }

    protected override void ExtractJson(string json)
    {
        this.mMonsters = JsonMapper.ToObject<List<Monster>>(json);
    }
}