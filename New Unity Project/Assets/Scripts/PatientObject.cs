using UnityEngine;

[CreateAssetMenu(fileName = "NewPatient", menuName = "PatientObject")]
public class PatientObject : ScriptableObject
{
    public string Name = "New Patient";
    public string Allergies = "NKDFA";
    public string History = "No History";
    public string HomeMeds = "No Meds";
    public string Notes = "No Notes";

    public float Temperature = 98.6f; //Temperature
    public float HR = 80; // Heart Rate
    public float RR = 18; // Respiration Rate
    public float BPS = 120; // First number of Blood Pressure (Systolic)
    public float BPD = 80; // Second number of Blood Pressure (Diastolic)
    public float O2Sat = 95; // O2 Saturation, on Room Air
    public float WBC = 11000; // White Blood Cell Count
    public float Lactic = 1; // White Blood Cell Count
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