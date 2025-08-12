using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTalkData", menuName = "Talk/TalkData")]

public class TalkData : ScriptableObject
{
    //아이디
    [SerializeField] private int _id;
    public int Id
    {
        get => _id;
        private set => _id = value;
    }

    //대사
    [SerializeField] private List<string> _talkList;
    public List<string> TalkList
    {
        get => _talkList;
        private set => _talkList = value;
    }
}   
