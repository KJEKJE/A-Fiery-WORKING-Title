using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
public class HPSystem : MonoBehaviour
{
    public int hp = 10;//set HP
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public void TakeDamage(int damage)
    {
        hp -= damage;
        onDamaged.Invoke(hp);//takes dmg
        if (hp < 1)
        {
            onDie.Invoke();//oof
        }
    }
}
