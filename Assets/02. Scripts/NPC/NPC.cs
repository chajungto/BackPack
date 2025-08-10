using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private NearSign nameCanvas;
    public NearSign NameCanvas { get {return nameCanvas; } }


    private void Awake()
    {
        if (nameCanvas == null)
        {
            nameCanvas = GetComponentInChildren<NearSign>();
        }
    }
}
