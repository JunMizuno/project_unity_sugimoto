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

	private readonly float accelerateLocalMaximumValue = 1.1f;
	private int overLocalMaxValueCount = default;
    public int OverLocalMaxValueCount
	{
        get
		{
			return overLocalMaxValueCount;
		}
	}

    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        RefreshAccelerateValue();
    }

    /// <summary>
    /// 加速度の値を更新
    /// </summary>
    private void RefreshAccelerateValue()
    {
        accelerateValueX = Input.acceleration.x;
        accelerateValueY = Input.acceleration.y;
        accelerateValueZ = Input.acceleration.z;

        if (CalculateAccelerateValuesAvarage() >= accelerateLocalMaximumValue)
		{
			overLocalMaxValueCount++;
		}
    }

    /// <summary>
    /// 端末加速度の平均を計算
    /// </summary>
    /// <returns></returns>
    public float CalculateAccelerateValuesAvarage()
    {
        return Mathf.Sqrt((accelerateValueX * accelerateValueX) + (accelerateValueY * accelerateValueY) + (accelerateValueZ * accelerateValueZ));
    }
}
