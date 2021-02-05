using UnityEngine;

public class MasterTracker : MonoBehaviour
{

    static MasterTracker instance = null;

    [SerializeField]
    int smallTankPoints = 100, fastTankPoints = 200, bigTankPoints = 300, armoredTankPoints = 400;
    public int SmallTankPointsWorth { get { return smallTankPoints; } }
    public int FastTankPointsWorth { get { return fastTankPoints; } }
    public int BigTankPointsWorth { get { return bigTankPoints; } }
    public int armoredTankPointsWorth { get { return armoredTankPoints; } }
    public static bool stageCleared = false;
    public static int smallTankDestroyed, fastTankDestroyed, bigTankDestroyed, armoredTankDestroyed;
    public static int stageNumber;
    public static int playerScore = 0, playerLives = 3;

    /*void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }*/

}