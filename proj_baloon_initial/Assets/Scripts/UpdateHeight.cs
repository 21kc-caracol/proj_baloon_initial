using UnityEngine;

public class UpdateHeight : MonoBehaviour
{
    public GameObject Ball;
    TMPro.TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText("Current height: " + Ball.transform.position.y);
    }
}
