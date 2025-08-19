using UnityEngine;
using UnityEngine.UIElements;

public class MoverRotatorScaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
    }
}