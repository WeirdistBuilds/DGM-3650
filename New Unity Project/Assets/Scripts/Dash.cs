using UnityEngine;
using System.Collections;

public class Dash : MonoBehaviour
{
    private float doubleTapTimeLimit = 0.25f;
    public float dashSpeed = 20;
    public float dashDuration = 1;
    private bool DPress1, DPress2, WPress1, WPress2;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("First W Tap");
            WPress1 = true;
            StartCoroutine(TapEvent());
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("First D Tap");
            DPress1 = true;
            StartCoroutine(TapEvent());
        }
    }

    IEnumerator TapEvent()
    {
        yield return new WaitForEndOfFrame();

        float count = 0f;
        while (count < doubleTapTimeLimit)
        {
            if (Input.GetKeyDown(KeyCode.W) && WPress1)
            {
                StartCoroutine(DashW());
                Debug.Log("Second W Tap");
                WPress1 = false;
                WPress2 = true;
                yield break;
            }
            else if (Input.GetKeyDown(KeyCode.D) && DPress1)
            {
                StartCoroutine(DashD());
                Debug.Log("Second D Tap");
                DPress1 = false;
                DPress2 = true;
                yield break;
            }
            count += Time.deltaTime; // increment counter by change in time between frames
            yield return null;
        }

        IEnumerator DashW()
        {
            if (WPress2)
            {
                Debug.Log("W Dash");
                WPress2 = false;
                rb.velocity = (transform.forward * dashSpeed);
                yield return new WaitForSeconds(dashDuration);
                rb.velocity = Vector3.zero;
            }
            
        }

        IEnumerator DashD()
        {
            if (DPress2)
            {
                Debug.Log("D Dash");
                DPress2 = false;
                rb.velocity = (transform.right * dashSpeed);
                yield return new WaitForSeconds(dashDuration);
                rb.velocity = Vector3.zero;
            }
        }

    }
}