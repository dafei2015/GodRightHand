#region

using System.Collections.Generic;
using LitJson;

#endregion

public class GoodsCfg : TableDataBase
{
    private List<Goods> mGoods = new List<Goods>();

    public GoodsCfg(string tableName)
        : base(tableName)
    {
    }

    protected override void ExtractJson(string json)
    {
        this.mGoods = JsonMapper.ToObject<List<Goods>>(json);
    }
}