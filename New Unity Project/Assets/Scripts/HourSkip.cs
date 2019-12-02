using UnityEngine;

public class HourSkip : MonoBehaviour
{
    public TimeObject InGameTime;

    public void DoHourSkip()
    {
        Debug.Log("Do Hour Skip");
        float hours = InGameTime.TotalGameSeconds + 3600;
        float temp = hours % 14400;
        float add = 14400 - temp;
        InGameTime.TotalGameSeconds += add;
        InGameTime.SecondsPassed += add;
    }
}
