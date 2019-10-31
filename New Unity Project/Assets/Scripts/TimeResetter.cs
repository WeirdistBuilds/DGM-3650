using UnityEngine;

public class TimeResetter : MonoBehaviour
{
    public TimeObject MyInGameTime;

    void Start()
    {
        ResetTime();
    }

    public void ResetTime()
    {
        MyInGameTime.SecondsPassed = 0;
    }
}
