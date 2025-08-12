using UnityEngine;

public class NPC : Object
{
    [SerializeField] private TalkData _talkData;
    public TalkData TalkData { get { return _talkData; } }
}
