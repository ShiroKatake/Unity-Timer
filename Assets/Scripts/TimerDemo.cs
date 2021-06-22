using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDemo : MonoBehaviour
{
    private Timer timer;
	private bool isStarted;

	// Start is called before the first frame update
	private void Awake()
	{
		timer = Timer.AddTimer(gameObject, "", 10f);
	}

	// Update is called once per frame
	void Update()
    {
		if (!isStarted)
		{
			timer.StartTime();
			isStarted = true;
		}
	}
}
