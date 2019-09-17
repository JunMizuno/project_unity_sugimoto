using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateManager : MonoBehaviour
{
    private float accelerateValueX = default;
    public float AccelerateValueX
    {
        get
        {
            return accelerateValueX;
        }
    }
    private float accelerateValueY = default;
    public float AccelerateValueY
    {
        get
        {
            return accelerateValueY;
        }
    }
    private float accelerateValueZ = default;
    public float AccelerateValueZ
    {
        get
        {
            return accelerateValueZ;
        }
    }

    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        accelerateValueX = Input.acceleration.x;
        accelerateValueY = Input.acceleration.y;
        accelerateValueZ = Input.acceleration.z;
    }
}
