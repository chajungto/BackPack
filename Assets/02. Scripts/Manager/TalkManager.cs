using UnityEngine;
using System.Collections.Generic;

public class TalkManager : MonoBehaviour
{
    //대사 Dictionary
    private Dictionary<int, List<string>> talkDataDictionary;
    public Dictionary<int, List<string>> TalkDataDictionary
    {
        get => talkDataDictionary;
        private set => talkDataDictionary = value;
    }
    //TalkData 리스트
    [SerializeField] private List<TalkData> talkDataList;

    private void Awake()
    {
        talkDataDictionary = new Dictionary<int, List<string>>();
        GenerateTalkData();
    }

    void GenerateTalkData()
    {
        foreach(var data in talkDataList)
        {
            talkDataDictionary.Add(data.Id, data.TalkList);
        }
    }

    private void Update()
    {
        
    }
}
