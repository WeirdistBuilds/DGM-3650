using UnityEngine;

[CreateAssetMenu(fileName = "NewPatient", menuName = "PatientObject")]
public class PatientObject : ScriptableObject
{
    public string Name = "John Doe";
    public int Age = 21;
    public int WeightInKG = 180;
    public string Allergies = "None";
    public string History = "None";
    public string HomeMeds = "None";

    public float Temperature = 98.6f; //Temperature
    public float HR = 80; // Heart Rate
    public float RR = 18; // Respiration Rate
    public float BPS = 120; // First number of Blood Pressure (Systolic)
    public float BPD = 80; // Second number of Blood Pressure (Diastolic)
    public float O2Sat = 95; // O2 Saturation, on Room Air
    public int EWS; // Early Warning Score
    public int qSepsisScore; // qSepsis Score


    public float DiscomfortLevel = 0;
    public float ThirstLevel = 0;
    public float HungerLevel = 0;

    public float TimeLastFood, TimeLastWater, TimeLastComfort;

    public bool InfectionActive = true;
    public float InfectionRate = 000.1f;
    public float InfectionStart = 1;
    public float InfectionCurrent;
}
