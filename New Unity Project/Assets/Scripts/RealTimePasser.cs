using System;
using UnityEngine;
using UnityEngine.UI;

public class RealTimePasser : MonoBehaviour
{
    public TimeObject MyTimeObject;
    public Transform SecondHand, MinuteHand, HourHand;
    public Text SecondText, MinuteText, HourText;
    public bool IsAnalog;

    void Start()
    {
        if (IsAnalog)
        {
            SecondHand = gameObject.transform.GetChild(0);
            MinuteHand = gameObject.transform.GetChild(1);
            HourHand = gameObject.transform.GetChild(2);
        }
        else
        {
            Transform canvas = gameObject.transform.GetChild(0);
            Transform canvasChild0 = canvas.transform.GetChild(0);
            Transform canvasChild1 = canvas.transform.GetChild(1);
            Transform canvasChild2 = canvas.transform.GetChild(2);
            SecondText = canvasChild0.gameObject.GetComponent<Text>();
            MinuteText = canvasChild1.gameObject.GetComponent<Text>();
            HourText = canvasChild2.gameObject.GetComponent<Text>();
        }
    }

    void Update()
    {
        if (MyTimeObject.TimeShouldPass)
        {
            if (IsAnalog)
            {
                DateTime currentTime = DateTime.Now;
                MyTimeObject.Second = currentTime.Second;
                MyTimeObject.Minute = currentTime.Minute;
                MyTimeObject.Hour = currentTime.Hour % 12;

                float secondAngle = -360 * (MyTimeObject.Second / 60);
                float minuteAngle = -360 * (MyTimeObject.Minute / 60);
                float hourAngle = -360 * (MyTimeObject.Hour / 12);

                SecondHand.localRotation = Quaternion.Euler(0, 0, secondAngle);
                MinuteHand.localRotation = Quaternion.Euler(0, 0, minuteAngle);
                HourHand.localRotation = Quaternion.Euler(0, 0, hourAngle);
            }
            else
            {
                DateTime currentTime = DateTime.Now;
                MyTimeObject.Second = currentTime.Second;
                MyTimeObject.Minute = currentTime.Minute;
                MyTimeObject.Hour = currentTime.Hour % 12;

                float secondAngle = -360 * (MyTimeObject.Second / 60);
                float minuteAngle = -360 * (MyTimeObject.Minute / 60);
                float hourAngle = -360 * (MyTimeObject.Hour / 12);

                SecondText.text = ((int)MyTimeObject.Second).ToString();
                MinuteText.text = ((int)MyTimeObject.Minute).ToString();
                HourText.text = ((int)MyTimeObject.Hour).ToString();
            }
        }
    }
}