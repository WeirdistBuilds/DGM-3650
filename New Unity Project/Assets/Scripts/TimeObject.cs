using UnityEngine;

[CreateAssetMenu(fileName = "NewTime", menuName = "TimeObject")]
public class TimeObject : ScriptableObject
{
    public float Second, Minute, Hour;
    public float SecondsPassed, TotalGameSeconds;
    public bool TimeShouldPass;
}
