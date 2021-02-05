using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    GameObject[] tanks;
    GameObject tank;
    [SerializeField]
    bool isPlayer;
    [SerializeField]
    GameObject smallTank, fastTank, bigTank, armoredTank;

    enum TankType
    {
        smallTank, fastTank, bigTank, armoredTank
    };

    private void Start()
    {
        if (isPlayer)
        {
            tanks = new GameObject[1] { smallTank };
        }
        else
        {
            tanks = new GameObject[4] { smallTank, fastTank, bigTank, armoredTank };
        }
    }

    public void StartSpawning()
    {
        if (!isPlayer)
        {
            List<int> tankToSpawn = new List<int>();
            tankToSpawn.Clear();
            if (LevelManager.smallTanks > 0) tankToSpawn.Add((int)TankType.smallTank);
            if (LevelManager.fastTanks > 0) tankToSpawn.Add((int)TankType.fastTank);
            if (LevelManager.bigTanks > 0) tankToSpawn.Add((int)TankType.bigTank);
            if (LevelManager.armoredTanks > 0) tankToSpawn.Add((int)TankType.armoredTank);
            int tankID = tankToSpawn[Random.Range(0, tankToSpawn.Count)];
            tank = Instantiate(tanks[tankID], transform.position, transform.rotation);
            /*tank.transform.SetParent(enemyHolder);
            if (Random.value <= LevelManager.bonusCrateRate)
            {
                tank.GetComponent<BonusTank>().MakeBonusTank();
            }*/
            if (tankID == (int)TankType.smallTank) LevelManager.smallTanks--;
            else if (tankID == (int)TankType.fastTank) LevelManager.fastTanks--;
            else if (tankID == (int)TankType.bigTank) LevelManager.bigTanks--;
            else if (tankID == (int)TankType.armoredTank) LevelManager.armoredTanks--;
            _ = GameObject.Find("Canvas").GetComponent<GamePlayManager>();
        }
        else
        {
            tank = Instantiate(tanks[0], transform.position, transform.rotation);
        }
    }

    public void SpawnNewTank()
    {
        if (tank != null) tank.SetActive(true);
    }

}