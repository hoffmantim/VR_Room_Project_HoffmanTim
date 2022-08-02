using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform secondHand;
    public Transform minuteHand;
    public Transform hourHand;
    string oldSeconds;



    // Update is called once per frame
    void Update()
    {
        string seconds = System.DateTime.UtcNow.ToString("ss");

        if (seconds != oldSeconds) 
        {
            UpdateTimer();
        }

        oldSeconds = seconds;
    }

    void UpdateTimer() 
    {
        int secondsInt = int.Parse(System.DateTime.Now.ToString("ss"));
        int minutesInt = int.Parse(System.DateTime.Now.ToString("mm"));
        int hoursInt = int.Parse(System.DateTime.Now.ToString("hh"));
        int secondHandDegrees = (secondsInt * 6);
        int minuteHandDegrees = (minutesInt * 6);
        int hourHandDegrees = (hoursInt * 30);

        secondHand.localRotation = Quaternion.Euler(secondHandDegrees, 0, 0);
        minuteHand.localRotation = Quaternion.Euler(minuteHandDegrees, 0, 0);
        hourHand.localRotation = Quaternion.Euler(hourHandDegrees, 0, 0);
    }
}
