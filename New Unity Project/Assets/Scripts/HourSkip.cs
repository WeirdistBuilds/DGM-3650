using UnityEngine;
using UnityEngine.UI;

public class HourSkip : MonoBehaviour
{
    public TimeObject InGameTime;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(DoHourSkip);
    }

    public void DoHourSkip()
    {
        float hours = InGameTime.TotalGameSeconds + 3600;
        float temp = hours % 14400;
        float add = 14400 - temp;
        InGameTime.TotalGameSeconds += add;
        InGameTime.SecondsPassed += add;
    }
}
