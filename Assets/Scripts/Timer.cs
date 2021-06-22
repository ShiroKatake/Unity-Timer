using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private string timerName;
    [SerializeField] private float timePassed;

    private float timeEnd;
    private bool isTiming;
    private bool isStopwatch;
    public static Timer AddTimer(GameObject gameObject, string timerName)
	{
        Timer timer = gameObject.AddComponent(typeof(Timer)) as Timer;
        timer.timerName = timerName;
        return timer;
    }
    public static Timer AddTimer(GameObject gameObject, string timerName, float timeEnd)
	{
        Timer timer = gameObject.AddComponent(typeof(Timer)) as Timer;
        timer.timerName = timerName;
        timer.timeEnd = timeEnd;
        return timer;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
