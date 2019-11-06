using UnityEngine;
using UnityEngine.UI;

public class HTCSetter : MonoBehaviour

{
    public PatientObject MyPatient;
    public Text HungerText, ThirstText, ComfortText;
    public string HungerStr, ThirstStr, ComfortStr;

    private void Start()
    {
        Transform canvasChild0 = gameObject.transform.GetChild(0);
        Transform canvasChild1 = gameObject.transform.GetChild(1);
        Transform canvasChild2 = gameObject.transform.GetChild(2);

        HungerText = canvasChild0.gameObject.GetComponent<Text>();
        ThirstText = canvasChild1.gameObject.GetComponent<Text>();
        ComfortText = canvasChild2.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        HungerStr = MyPatient.HungerLevel.ToString("0.00");
        HungerText.text = "Hunger: " + HungerStr;

        ThirstStr = MyPatient.ThirstLevel.ToString("0.00");
        ThirstText.text = "Thirst: " + ThirstStr;

        ComfortStr = MyPatient.DiscomfortLevel.ToString("0.00");
        ComfortText.text = "Discomfort: " + ComfortStr;
    }
}
