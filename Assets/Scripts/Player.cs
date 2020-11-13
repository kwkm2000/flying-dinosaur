using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D Body { get; private set; }
    public RectTransform RectTransform { get; private set; }

    void Awake() {
        this.Body = gameObject.GetComponent<Rigidbody2D>();
        this.RectTransform = gameObject.GetComponent<RectTransform>();
    }

    void Update() {
        var currentX = this.RectTransform.localPosition.x;

        if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Right");
            var newX = Mathf.Min(currentX + 15, 230);
            var pos = new Vector3(newX, this.RectTransform.localPosition.y, 0);
            Debug.Log(pos);
            this.RectTransform.localPosition = pos;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Left");

            var newX = Mathf.Max(currentX - 15, -230);
            var pos = new Vector3(newX, this.RectTransform.localPosition.y, 0);
            this.RectTransform.localPosition = pos;
        }
    }
}