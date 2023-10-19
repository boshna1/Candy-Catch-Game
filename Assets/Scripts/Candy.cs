using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Candy : MonoBehaviour
{
    public GameObject[] CandyType = new GameObject[6];
    private int tempCandyType;
    Quaternion Rotation;
    private int CandyCount = 0;
    private DisplayScore DS = new DisplayScore();
    private string message;
    private Text _text;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
            while (CandyCount <= 14)
            {

                int x = Random.Range(-6, 6);
                int y = Random.Range(5, 200);
                int random = Random.Range(0, 100);
                if (random >= 0 && random < 5)
                {
                    tempCandyType = 0;
                }
                if (random >= 7 && random < 15)
                {
                    tempCandyType = 1;
                }
                if (random >= 15 && random < 35)
                {
                    tempCandyType = 2;
                }
                if (random >= 35 && random < 60)
                {
                    tempCandyType = 3;
                }
                if (random >= 60 && random < 80)
                {
                    tempCandyType = 4;
                }
                if (random >= 80 && random < 100)
                {
                    tempCandyType = 5;
                }
                Instantiate(CandyType[tempCandyType], new Vector3(x, y), Rotation);
                CandyCount++;
        }
        if (CandyCount >= 14)
        {
            DS.CheckGame();
        }
    }
    public void resetCandy()
    {
        CandyCount = 0;

        
    }
    }
