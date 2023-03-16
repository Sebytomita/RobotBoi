using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    GameObject player;
    float[] SpawnPointsX = new float[100];
    float[] SpawnPointsY = new float[100];
    public GameObject SpawnEffect;
    public GameObject PrefabInsecta1;
    public GameObject PrefabInsecta2;
    public GameObject PrefabInsecta3;
    public GameObject PrefabInsecta4;
    public GameObject PrefabInsecta5;
    public GameObject PrefabInsecta6;
    public GameObject PrefabInsecta7;
    public GameObject PrefabInsecta8;
    public GameObject PrefabInsecta9;
    Vector2 poz;
    Vector2 spawnPlace;
    Vector2 Place;
    float randX, copieX, coordonataX;
    float randY, copieY, coordonataY;
    float timer = 3f;
    bool intrat1, intrat2, intrat3, intrat4, intrat5;
    bool it1 = false;
    int wait;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("RobotBoi");
        intrat1 = intrat2 = intrat3 = intrat4 = intrat5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        poz = player.transform.position;
        if (poz.x >= -16.27f && poz.x <= -7.02f && poz.y >= -0.32f && poz.y <= 8.97f && intrat1 == false)
        {
            if (it1 == false)
            {
                for (int i = 1; i <= 4; i++)
                {
                    randX = UnityEngine.Random.Range(-16.27f, -7.02f);
                    randY = UnityEngine.Random.Range(-0.32f, 9.19f);
                    SpawnPointsX[i] = randX;
                    SpawnPointsY[i] = randY;
                }
                timer = 3f;
                it1 = true;
                for (int i = 1; i <= 4; i++)
                {
                    randX = SpawnPointsX[i];
                    randY = SpawnPointsY[i];
                    spawnPlace = new Vector2(randX, randY);
                    Instantiate(SpawnEffect, spawnPlace, Quaternion.identity);
                    UnityEngine.Debug.Log(spawnPlace);
                }
            }
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Camera1();
                intrat1 = true;
                it1 = false;
            }
        }
        else if (poz.x >= 14.07f && poz.x <= 24.35f && poz.y >= -0.87f && poz.y <= 9.19f && intrat2 == false)
        {
            if (it1 == false)
            {
                for (int i = 1; i <= 5; i++)
                {
                    randX = UnityEngine.Random.Range(14.07f, 24.35f);
                    randY = UnityEngine.Random.Range(-0.87f, 9.19f);
                    SpawnPointsX[i] = randX;
                    SpawnPointsY[i] = randY;
                }
                timer = 3f;
                it1 = true;
                for (int i = 1; i <= 5; i++)
                {
                    randX = SpawnPointsX[i];
                    randY = SpawnPointsY[i];
                    spawnPlace = new Vector2(randX, randY);
                    Instantiate(SpawnEffect, spawnPlace, Quaternion.identity);
                }
            }
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Camera2();
                intrat2 = true;
                it1 = false;
            }
        }
        else if (poz.x >= 14.35f && poz.x <= 24.88f && poz.y >= 30.07f && poz.y <= 40.28f && intrat3 == false)
        {
            if (it1 == false)
            {
                for (int i = 1; i <= 6; i++)
                {
                    randX = UnityEngine.Random.Range(14.35f, 24.88f);
                    randY = UnityEngine.Random.Range(30.07f, 40.28f);
                    SpawnPointsX[i] = randX;
                    SpawnPointsY[i] = randY;
                }
                timer = 3f;
                it1 = true;
                for (int i = 1; i <= 6; i++)
                {
                    randX = SpawnPointsX[i];
                    randY = SpawnPointsY[i];
                    spawnPlace = new Vector2(randX, randY);
                    Instantiate(SpawnEffect, spawnPlace, Quaternion.identity);
                }
            }
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Camera3();
                intrat3 = true;
                it1 = false;
            }
        }
        else if (poz.x >= -16.77f && poz.x <= -6.26f && poz.y >= 30.02f && poz.y <= 40.4f && intrat4 == false)
        {
            if (it1 == false)
            {
                for (int i = 1; i <= 6; i++)
                {
                    randX = UnityEngine.Random.Range(-16.27f, -6.26f);
                    randY = UnityEngine.Random.Range(30.02f, 40.4f);
                    SpawnPointsX[i] = randX;
                    SpawnPointsY[i] = randY;
                }
                timer = 3f;
                it1 = true;
                for (int i = 1; i <= 6; i++)
                {
                    randX = SpawnPointsX[i];
                    randY = SpawnPointsY[i];
                    spawnPlace = new Vector2(randX, randY);
                    Instantiate(SpawnEffect, spawnPlace, Quaternion.identity);
                }
            }
            if (timer > 0)
                timer -= Time.deltaTime;
            else
            {
                Camera4();
                intrat4 = true;
                it1 = false;
            }
        }
        else if (poz.x >= 44.91f && poz.x <= 55.36f && poz.y >= 30.02f && poz.y <= 40.4f && intrat5 == false)
        {
            if (it1 == false)
            {
                for (int i = 1; i <= 4; i++)
                {
                    randX = UnityEngine.Random.Range(44.91f, 55.36f);
                    randY = UnityEngine.Random.Range(30.02f, 40.4f);
                    SpawnPointsX[i] = randX;
                    SpawnPointsY[i] = randY;
                }
                timer = 3f;
                it1 = true;
                for (int i = 1; i <= 4; i++)
                {
                    randX = SpawnPointsX[i];
                    randY = SpawnPointsY[i];
                    spawnPlace = new Vector2(randX, randY);
                    Instantiate(SpawnEffect, spawnPlace, Quaternion.identity);
                }
            }
            if (timer > 0)
                timer -= Time.deltaTime;
            else
            {
                Camera5();
                intrat5 = true;
                it1 = false;
            }
        }
    }

    void Camera1()
    {
        for (int i = 1; i <= 2; i++)
        {
            randX = SpawnPointsX[i];
            randY = SpawnPointsY[i];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta1, spawnPlace, Quaternion.identity);
        }
        for (int i = 1; i <= 2; i++)
        {
            randX = SpawnPointsX[i + 2];
            randY = SpawnPointsY[i + 2];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta2, spawnPlace, Quaternion.identity);
        }
    }
    void Camera2()
    {
        for (int i = 1; i <= 4; i++)
        {
            randX = SpawnPointsX[i];
            randY = SpawnPointsY[i];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta1, spawnPlace, Quaternion.identity);
        }
        for (int i = 1; i <= 1; i++)
        {
            randX = SpawnPointsX[i + 4];
            randY = SpawnPointsY[i + 4];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta3, spawnPlace, Quaternion.identity);
        }
    }

    void Camera3()
    {
        for (int i = 1; i <= 2; i++)
        {
            randX = SpawnPointsX[i];
            randY = SpawnPointsY[i];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta4, spawnPlace, Quaternion.identity);
        }
        for (int i = 1; i <= 4; i++)
        {
            randX = SpawnPointsX[i + 2];
            randY = SpawnPointsY[i + 2];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta5, spawnPlace, Quaternion.identity);
        }
    }

    void Camera4()
    {
        for (int i = 1; i <= 3; i++)
        {
            randX = SpawnPointsX[i];
            randY = SpawnPointsY[i];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta6, spawnPlace, Quaternion.identity);
        }
        for (int i = 1; i <= 3; i++)
        {
            randX = SpawnPointsX[i + 3];
            randY = SpawnPointsY[i + 3];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta7, spawnPlace, Quaternion.identity);
        }
    }

    void Camera5()
    {
        for (int i = 1; i <= 2; i++)
        {
            randX = SpawnPointsX[i];
            randY = SpawnPointsY[i];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta8, spawnPlace, Quaternion.identity);
        }
        for (int i = 1; i <= 2; i++)
        {
            randX = SpawnPointsX[i + 2];
            randY = SpawnPointsY[i + 2];
            spawnPlace = new Vector2(randX, randY);
            Instantiate(PrefabInsecta9, spawnPlace, Quaternion.identity);
        }
    }

}