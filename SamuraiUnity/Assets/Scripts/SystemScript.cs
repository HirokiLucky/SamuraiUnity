using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class SystemScript : MonoBehaviour
{
    [SerializeField] private Player player;
    private TimeSpan enemyTime = new TimeSpan(0, 0, 0, 3, 0);
    public int mode; 
    public Stopwatch systemTime;
    private TimeSpan returnTime;
    private bool winner;
    
    // Start is called before the first frame update
    void Start()
    {
        systemTime = new System.Diagnostics.Stopwatch();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            mode = 1;
        }

        switch (mode)
        {
            //case 0:   メニュー画面
            //case 1:   待機など
            case 2:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    Debug.Log("ON");
                    systemTime.Start();
                    mode = 3;
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.E))
                {
                    returnTime = player.StopTime();
                    winner = Compare(returnTime, enemyTime);
                }
                break;
            case 4:
                if (winner) { Debug.Log("win"); }
                else{Debug.Log("Lose");}
                mode = 5;
                break;
            case 5:
                break;
        }
    }
    
    public bool Compare(TimeSpan t1, TimeSpan t2)
    {
        return t1 < t2;
    }
}
