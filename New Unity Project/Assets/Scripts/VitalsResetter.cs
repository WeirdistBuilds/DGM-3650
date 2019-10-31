using UnityEngine;

public class VitalsResetter : MonoBehaviour
{
    public PatientObject MyPatient;

    void Start()
    {
        ResetVitals();
    }

    public void ResetVitals()
    {
        MyPatient.Age = Random.Range(18, 65);
        MyPatient.WeightInKG = Random.Range(40, 80);
        MyPatient.Allergies = "Allergies";
        MyPatient.HomeMeds = "Home Meds";
        MyPatient.History = "History";
        MyPatient.Name = "Don";        
        
        MyPatient.ThirstLevel = 0;
        MyPatient.HungerLevel = 0;
        MyPatient.DiscomfortLevel = 0;

        MyPatient.Temperature = Random.Range(96.0f, 99.0f);
        MyPatient.HR = Random.Range(70.0f, 100.0f);
        MyPatient.RR = Random.Range(10.0f, 15.0f);
        MyPatient.BPS = Random.Range(110.0f, 200.0f);
        MyPatient.BPD = MyPatient.BPS / (Random.Range(1.5f, 2.5f));
        MyPatient.O2Sat = 95;

        MyPatient.InfectionActive = true;
    }
}