using System.CodeDom;
using UnityEngine;
using System.Collections;

public class LavaGen : MonoBehaviour
{
    public float Lambda, TimerDecrement;
    private float _timer;
    public Transform Lava;
    public int Radius;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        _timer -= TimerDecrement;
        while (_timer <= 0)
        {
            Debug.Log("Spawning a lava lake");
            Vector3 pos;
            do
            {
                pos = new Vector3(UnityEngine.Random.value * 100.0f - 50.0f, UnityEngine.Random.value * 100.0f - 50.0f, 0);
            } while (Mathf.Sqrt((Mathf.Abs(pos.x) * Mathf.Abs(pos.x)) + (Mathf.Abs(pos.y) * Mathf.Abs(pos.y))) < Radius);
            Instantiate(Lava, pos, Quaternion.identity);
            float u = Random.value;
            while (u == 1.0f)
            {
                u = Random.value;
            }
            u = Mathf.Log(1 - u) * Lambda * -1;
        }
    }
}
