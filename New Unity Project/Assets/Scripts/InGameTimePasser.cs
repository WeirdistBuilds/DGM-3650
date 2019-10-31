using UnityEngine;

public class InGameTimePasser : MonoBehaviour
{
    public TimeObject InGameTime;
    public int StartHour;
    public float SecondsPerSecond = 20;
    
    void Start()
    {
        float StartMinute = StartHour * 60;
        InGameTime.TotalGameSeconds = StartMinute * 60;
    }
    
    void Update()
    {
        if (InGameTime.TimeShouldPass)
        {
            InGameTime.SecondsPassed += SecondsPerSecond * Time.deltaTime;
            InGameTime.TotalGameSeconds += SecondsPerSecond * Time.deltaTime;
            InGameTime.Second = (InGameTime.TotalGameSeconds);
            InGameTime.Minute = (InGameTime.TotalGameSeconds / 60);
            InGameTime.Hour = (InGameTime.Minute / 60);    
        }
    }
}
