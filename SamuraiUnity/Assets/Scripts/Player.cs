using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Player : MonoBehaviour
{
    [SerializeField]private SystemScript _systemScript;
    private TimeSpan enemyTime = new TimeSpan(0, 0, 0, 3, 0);
    private double PlayerTime = 0;
    private TimeSpan timer;
    private Stopwatch time;
    private bool boolian = false;
    
    
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
        

        if(Input.GetKeyDown(KeyCode.A) && _systemScript.mode == 0)
        {
            time.Start();
            boolian = true;
            Debug.Log("ON");
        }

        if (Input.GetKeyDown(KeyCode.E) && boolian)
        {
            time.Stop();
            timer = time.Elapsed;
            Debug.Log(timer);
            time.Reset();
            boolian = false;
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
