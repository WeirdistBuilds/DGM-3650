using UnityEngine;

[CreateAssetMenu(fileName = "NewChart", menuName = "ChartObject")]
public class ChartObject : ScriptableObject
{
    public ChartTimeObject[] Charts;
    public string Name, Age, Weight, Allergies, History, HomeMeds, Notes;
}
