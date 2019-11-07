using UnityEngine;

public class VitalsResetter : MonoBehaviour
{
    public PatientObject MyPatient;
    public InfectionObject MyInfection;

    void Start()
    {
        ResetVitals();
    }

    public void ResetVitals()
    {
       MyPatient.ThirstLevel = 0;
        MyPatient.HungerLevel = 0;
        MyPatient.DiscomfortLevel = 0;

        MyPatient.Temperature = MyInfection.TempStart;
        MyPatient.HR = MyInfection.HRStart;
        MyPatient.RR = MyInfection.RRStart;
        MyPatient.BPS = MyInfection.BPSStart;
        MyPatient.BPD = MyInfection.BPDStart;
        MyPatient.O2Sat = MyInfection.O2SatStart;
        MyPatient.WBC = MyInfection.WBCStart;
        MyPatient.Lactic = MyInfection.LacticStart;
        MyPatient.InfectionActive = true;
    }
}