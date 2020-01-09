using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossUI : MonoBehaviour
{
    public delegate void UpdateHealthII(int newHP);
    public static event UpdateHealthII OnUpdateHealthII;
    public void SendHealthData(int HP)
    {
        if (OnUpdateHealthII != null)
        {
            OnUpdateHealthII(HP);
        }
    }
}
