using UnityEngine;
using UnityEngine.UI;

public class InfectionSetter : MonoBehaviour
{
    public PatientObject MyPatient;
    public Text CurrentText, ActiveText, RateText;
    public string CurrentStr, ActiveStr, RateStr;

    private void Start()
    {
        Transform canvasChild0 = gameObject.transform.GetChild(0);
        Transform canvasChild1 = gameObject.transform.GetChild(1);
        Transform canvasChild2 = gameObject.transform.GetChild(2);

        CurrentText = canvasChild0.gameObject.GetComponent<Text>();
        ActiveText = canvasChild1.gameObject.GetComponent<Text>();
        RateText = canvasChild2.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        CurrentStr = MyPatient.InfectionCurrent.ToString("0.00");
        CurrentText.text = "Infection Level: " + CurrentStr;

        ActiveStr = MyPatient.InfectionActive.ToString();
        ActiveText.text = "Infection Active: " + ActiveStr;

        RateStr = MyPatient.InfectionRate.ToString("0.00");
        RateText.text = "Infection Rate: " + RateStr;
    }
}
