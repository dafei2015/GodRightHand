#region

using System.Collections.Generic;
using LitJson;

#endregion

public class EquipmentCfg : TableDataBase
{
    private List<Equipment> mEquipments = new List<Equipment>();

    public EquipmentCfg(string tableName) : base(tableName)
    {
    }

    protected override void ExtractJson(string json)
    {
        this.mEquipments = JsonMapper.ToObject<List<Equipment>>(json);
    }
}