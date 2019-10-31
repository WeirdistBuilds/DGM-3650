using UnityEngine;

[CreateAssetMenu(fileName = "NewInfection", menuName = "InfectionObject")]
public class InfectionObject : ScriptableObject
{
    public float TempDiffCent, HRDiffCent, RRDiffCent, BPSDiffCent, BPDDiffCent, O2SatDiffCent;
}