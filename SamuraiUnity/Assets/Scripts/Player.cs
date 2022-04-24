using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Player : MonoBehaviour
{
    private TimeSpan enemyTime = new TimeSpan(0, 0, 0, 3, 0);
    private double PlayerTime = 0;
    private TimeSpan timer;
    private Stopwatch time;
    private bool mode = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("WaitTimer");
        time = new System.Diagnostics.Stopwatch();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3(1,1,1);

        if(Input.GetKeyDown(KeyCode.A))
        {
            time.Start();
            mode = true;
            Debug.Log("ON");
        }

        if (Input.GetKeyDown(KeyCode.E) && mode)
        {
            time.Stop();
            timer = time.Elapsed;
            Debug.Log(timer);
            time.Reset();
            mode = false;
        }
    }

    public IEnumerable WaitTimer(float random)
    {
        yield return new WaitForSeconds(random);
    }

    public bool Compare(TimeSpan t1, TimeSpan t2)
    {
        return t1 > t2;
    }
}
