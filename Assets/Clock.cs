using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float degreesPerHour = -30f;
    const float degreesPerMinute = -6f;

    [SerializeField]
    Transform hourPivot, minutePivot, secondPivot;

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hourPivot.localRotation = Quaternion.Euler(0, 0, (float)time.TotalHours * degreesPerHour);
        minutePivot.localRotation = Quaternion.Euler(0, 0, (float)time.TotalMinutes * degreesPerMinute);
        secondPivot.localRotation = Quaternion.Euler(0, 0, (float)time.TotalSeconds * degreesPerMinute);//Quaternion.Euler(0, 0, ((float)Math.Floor(time.TotalSeconds) + (float)Math.Pow(time.TotalSeconds - Math.Floor(time.TotalSeconds), 8)) * degreesPerMinute);
    }
}
