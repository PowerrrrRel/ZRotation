using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject obj;
    public int rotateSpeed;

    void Update()
    {
        obj.transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}
