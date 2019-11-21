using UnityEngine;

public class TimeResetter : MonoBehaviour
{
    public TimeObject MyInGameTime;

    public float temp;

    void Start()
    {
        temp = MyInGameTime.TotalGameSeconds;
        ResetTime();
    }

    public void ResetTime()
    {
        MyInGameTime.TotalGameSeconds = temp;
        MyInGameTime.SecondsPassed = 0;
    }
}
