using UnityEngine;

public class VitalsChanger : MonoBehaviour
{
    public PatientObject MyPatient;
    public InfectionObject MyInfection;
    public float TempDiff, HRDiff, RRDiff, BPSDiff, BPDDiff, O2SatDiff, WBCDiff, LacticDiff;

    void Start()
    {
        MyPatient.Temperature = MyInfection.TempStart;
        MyPatient.HR = MyInfection.HRStart;
        MyPatient.RR = MyInfection.RRStart;
        MyPatient.BPS = MyInfection.BPSStart;
        MyPatient.BPD = MyInfection.BPDStart;
        MyPatient.O2Sat = MyInfection.O2SatStart;
        MyPatient.WBC = MyInfection.WBCStart;
        MyPatient.Lactic = MyInfection.LacticStart;

        TempDiff = MyInfection.TempEnd - MyInfection.TempStart;
        HRDiff = MyInfection.HREnd - MyInfection.HRStart;
        RRDiff = MyInfection.RREnd - MyInfection.RRStart;
        BPSDiff = MyInfection.BPSEnd - MyInfection.BPSStart;
        BPDDiff = MyInfection.BPDEnd - MyInfection.BPDStart;
        O2SatDiff = MyInfection.O2SatEnd - MyInfection.O2SatStart;
        WBCDiff = MyInfection.WBCEnd - MyInfection.WBCStart;
        LacticDiff = MyInfection.LacticEnd - MyInfection.LacticStart;
    }

    void Update()
    {
        MyPatient.Temperature = MyInfection.TempStart + ((TempDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.HR = MyInfection.HRStart + ((HRDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.RR = MyInfection.RRStart + ((RRDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.BPS = MyInfection.BPSStart + ((BPSDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.BPD = MyInfection.BPDStart + ((BPDDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.O2Sat = MyInfection.O2SatStart + ((O2SatDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.WBC = MyInfection.WBCStart + ((WBCDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.Lactic = MyInfection.LacticStart + ((LacticDiff / 100) * MyPatient.InfectionCurrent);
    }
}