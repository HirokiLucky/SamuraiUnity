using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Player : MonoBehaviour
{
    [SerializeField]private SystemScript _systemScript;
    
    private double PlayerTime = 0;
    private TimeSpan timer;
  
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("WaitTimer");
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerable WaitTimer(float random)
    {
        yield return new WaitForSeconds(random);
    }

    

    public TimeSpan StopTime(){
    
        _systemScript.systemTime.Stop();
        timer = _systemScript.systemTime.Elapsed;
        Debug.Log(timer);
        _systemScript.systemTime.Reset();
        _systemScript.mode = 4;
        return timer;
    }
}
