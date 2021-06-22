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

    // Update is called once per frame
    void Update()
    {
        if (isTiming)
		{
            timePassed += Time.deltaTime;
            if (!isStopwatch && timePassed > timeEnd)
                ResetTime();
        }
    }

    public void StartTime()
	{
        if (isTiming)
            Debug.LogError($"Timer {timerName} is not finished yet, but you want to start it again. Please call StopTime() before calling StartTime() again.");
        ResetTime();
        isTiming = true;
	}

    public float StopTime()
	{
        isTiming = false;
        return timePassed;
	}

    public void ResetTime()
	{
        timePassed = 0f;
    }
}
