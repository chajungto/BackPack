using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    //아이디
    [SerializeField] private int _id;
    public int Id { get { return _id; } }

    //대화
    [SerializeField] private TalkData _tData;
    public TalkData TData { get { return _tData; } }

    //이름 캔버스
    [SerializeField] private NearSign nameCanvas;
    public NearSign NameCanvas { get {return nameCanvas; } }

    private void Awake()
    {
        if (nameCanvas == null)
        {
            nameCanvas = GetComponentInChildren<NearSign>();
        }
    }

    public void Interact()
    {
        List<string> talkList = GameManager.Instance.TalkManager.TalkDataDictionary[Id];
        Debug.Log("성공");
    }
}
