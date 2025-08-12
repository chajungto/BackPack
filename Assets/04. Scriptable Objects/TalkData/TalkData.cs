using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTalkData", menuName = "Talk/TalkData")]

public class TalkData : ScriptableObject
{
    //���̵�
    [SerializeField] private int _id;
    public int Id
    {
        get => _id;
        private set => _id = value;
    }

    //���
    [SerializeField] private List<string> _talkList;
    public List<string> TalkList
    {
        get => _talkList;
        private set => _talkList = value;
    }
}   
