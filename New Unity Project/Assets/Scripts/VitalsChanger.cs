using UnityEngine;

public class VitalsChanger : MonoBehaviour
{
    public PatientObject MyPatient;
    public InfectionObject MyInfection;
    public float TempStart, HRStart, RRStart, BPSStart, BPDStart, O2SatStart;
    public float TempDiff, HRDiff, RRDiff, BPSDiff, BPDDiff, O2SatDiff;

    // Start is called before the first frame update
    void Start()
    {
        TempStart = MyPatient.Temperature;
        HRStart = MyPatient.HR;
        RRStart = MyPatient.RR;
        BPSStart = MyPatient.BPS;
        BPDStart = MyPatient.BPD;
        O2SatStart = MyPatient.O2Sat;

        TempDiff = MyPatient.Temperature * MyInfection.TempDiffCent;
        HRDiff = MyPatient.HR * MyInfection.HRDiffCent;
        RRDiff = MyPatient.RR * MyInfection.RRDiffCent;
        BPSDiff = MyPatient.BPS * MyInfection.BPSDiffCent;
        BPDDiff = MyPatient.BPD * MyInfection.BPDDiffCent;
        O2SatDiff = MyPatient.O2Sat * MyInfection.O2SatDiffCent;
    }

    // Update is called once per frame
    void Update()
    {
        MyPatient.Temperature = TempStart + ((TempDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.HR = HRStart + ((HRDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.RR = RRStart + ((RRDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.BPS = BPSStart + ((BPSDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.BPD = BPDStart + ((BPDDiff / 100) * MyPatient.InfectionCurrent);
        MyPatient.O2Sat = O2SatStart + ((O2SatDiff / 100) * MyPatient.InfectionCurrent);
    }
}