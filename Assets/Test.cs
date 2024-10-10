using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    List<int> user = new List<int>() { 1,5,2,5,6,8,19,8, 15, 7, 10};
    [SerializeField] int numberOfWinner = 2;
    int RandomNumber = 0;

    LautrySystem lSystem = new LautrySystem();
    void Start()
    {
        SelectRandomWinnerIndex();
        var numberOfUser = ChooseWinner();
        foreach(var item in numberOfUser)
        {
            Debug.Log(item+",");
        }
    }

    private void SelectRandomWinnerIndex()
    {
        for (int i = 0; i < numberOfWinner; i++)
        {
            ChooseRandom();
        }
    }

    private void ChooseRandom()
    {
        RandomNumber = user[Random.Range(0, user.Count)];

        if (!lSystem.winningNumbers.Contains(RandomNumber))
            lSystem.winningNumbers.Add(RandomNumber);
        else
            ChooseRandom();
    }
    private List<int> ChooseWinner()
    {
        for (int i = 0; i < user.Count; i++)
        {
            for (int j = 0; j < lSystem.winningNumbers.Count; j++)
            {
                if (user[i] == lSystem.winningNumbers[j])
                {
                    if (!lSystem.winnerUserIndex.Contains(user[i]))
                        lSystem.winnerUserIndex.Add(user[i]);
                }
            }
        }
        return lSystem.winnerUserIndex;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Start();
    }


}

public class LautrySystem
{
    public List<int> winningNumbers = new List<int>();
    public List<int> winnerUserIndex = new List<int>();
}
