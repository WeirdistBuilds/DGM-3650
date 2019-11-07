using UnityEngine;

[CreateAssetMenu(fileName = "NewInfection", menuName = "InfectionObject")]
public class InfectionObject : ScriptableObject
{
    public float TempStart,
        TempEnd,
        HRStart,
        HREnd,
        RRStart,
        RREnd,
        BPSStart,
        BPSEnd,
        BPDStart,
        BPDEnd,
        O2SatStart,
        O2SatEnd,
        WBCStart,
        WBCEnd,
        LacticStart,
        LacticEnd,
        WeightMin,
        WeightMax,
        AgeMin,
        AgeMax,
        TimeToICU;

    public string Medication,
        Allergies,
        History;
}