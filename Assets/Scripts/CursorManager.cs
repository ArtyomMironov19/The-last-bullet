using UnityEngine;
using UnityEngine.Serialization;

public class CursorManager: MonoBehaviour
{
    [SerializeField] private Texture2D defaultCursor;
    [SerializeField] private Vector2 hotspot = Vector2.zero;

    private void Start()
    {
        Cursor.SetCursor(defaultCursor, hotspot, CursorMode.Auto);
    }
}
