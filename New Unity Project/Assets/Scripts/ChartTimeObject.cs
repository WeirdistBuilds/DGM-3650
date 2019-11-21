using UnityEngine;

[CreateAssetMenu(fileName = "NewChartTimeObject", menuName = "ChartTimeObject")]
public class ChartTimeObject : ScriptableObject
{
    public string TimeCharted, Temp, HR, RR, BPS, BPD, O2Sat, WBC, Lactic;
}
