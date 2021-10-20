using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleTick : MonoBehaviour
{
    public float TickSize = 60.0f;
    public int SecondsToTick = 1;

    private float TickMoveSize;
    // Start is called before the first frame update
    void Start()
    {
        TickMoveSize = 360 / TickSize;
        StartCoroutine(Tick());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Tick()
    {
        while (true)
        {
            yield return new WaitForSeconds(SecondsToTick);
            TickTheNeedle();
        }
    }

    /*
     reference - https://gamedevbeginner.com/how-to-rotate-in-unity-complete-beginners-guide/
    */
    void TickTheNeedle()
    {
        Vector3 NeedleNewRotation = new Vector3(0, transform.eulerAngles.y + TickMoveSize, 0);
        transform.eulerAngles = NeedleNewRotation;
    }
}
