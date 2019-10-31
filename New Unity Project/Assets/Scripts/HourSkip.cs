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
        InGameTime.TotalGameSeconds += 3600;
        InGameTime.SecondsPassed += 3600;
    }
}
