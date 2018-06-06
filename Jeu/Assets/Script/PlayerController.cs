using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 150.0f;
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		var z = Input.GetAxis("height") * Time.deltaTime * speed;

        transform.Translate(x, z, y);
    }
}