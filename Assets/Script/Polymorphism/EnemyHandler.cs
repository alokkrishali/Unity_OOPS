using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    void TakeDamage(int damageValue);
}

public class Zombie : MonoBehaviour, IEnemy
{
    public void TakeDamage(int damageValue)
    {
        Debug.Log("Zombie took Damage "+damageValue);
    }
}
public class Robot : MonoBehaviour, IEnemy
{
    public void TakeDamage(int damageValue)
    {
        Debug.Log("Robot took Damage "+damageValue);
    }
}
public class EnemyHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IEnemy enemy1 = new Zombie();
        IEnemy enemy2 = new Robot();

        enemy1.TakeDamage(10);
        enemy2.TakeDamage(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
