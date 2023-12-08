using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject genereishon;
    public GameControl gm;
    void Start()
    {
        createEnemy();

    }

    void Update()
    {

    }
    void createEnemy()
    {
        float kbro = Random.Range(-7.8f, 7.9f);
        Vector2 aleatorio = new Vector2(kbro, 3.5f);
        GameObject terrible = Instantiate(genereishon, aleatorio, transform.rotation);
        terrible.GetComponent<EnemyControl>().gameManager(gm);
        Invoke("createEnemy", 3);
    }
}
