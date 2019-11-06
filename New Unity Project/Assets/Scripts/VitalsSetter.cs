using UnityEngine;
using UnityEngine.UI;

public class VitalsSetter : MonoBehaviour
{
    public PatientObject MyPatient;
    public Text TempText, HRText, RRText, BPText, O2SatText;
    public string TempStr, HRStr, RRStr, BPSStr, BPDStr, O2SatStr;

    private void Start()
    {
        Transform canvasChild0 = gameObject.transform.GetChild(0);
        Transform canvasChild1 = gameObject.transform.GetChild(1);
        Transform canvasChild2 = gameObject.transform.GetChild(2);
        Transform canvasChild3 = gameObject.transform.GetChild(3);
        Transform canvasChild4 = gameObject.transform.GetChild(4);

        TempText = canvasChild0.gameObject.GetComponent<Text>();
        HRText = canvasChild1.gameObject.GetComponent<Text>();
        RRText = canvasChild2.gameObject.GetComponent<Text>();
        BPText = canvasChild3.gameObject.GetComponent<Text>();
        O2SatText = canvasChild4.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        TempStr = MyPatient.Temperature.ToString("0.0");
        TempText.text = "Temperature: " + TempStr;

        HRStr = MyPatient.HR.ToString("0");
        HRText.text = "Heart Rate: " + HRStr;

        RRStr = MyPatient.RR.ToString("0");
        RRText.text = "Respiration Rate: " + RRStr;

        BPSStr = MyPatient.BPS.ToString("0");
        BPDStr = MyPatient.BPD.ToString("0");
        BPText.text = "Blood Pressure: " + BPSStr + "/" + BPDStr;
        
        O2SatStr = MyPatient.O2Sat.ToString("0");
        O2SatText.text = "O2 on RA: " + O2SatStr + "%";
    }
}