using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepsCounterLabel : MonoBehaviour
{
    [SerializeField]
    public AccelerateManager accelerateManager = default;

    /// <summary>
    /// 初期設定
    /// </summary>
    private void Start()
    {
        InitializeStepsCounterLabel();
    }

    /// <summary>
    /// 更新
    /// </summary>
    private void Update()
    {
        if (accelerateManager != null)
        {
            RefreshStepsCounterLabel();
        }
    }

    /// <summary>
    /// ラベル表示の初期化
    /// </summary>
    private void InitializeStepsCounterLabel()
    {
        var label = this.GetComponent<Text>();
        label.text = string.Format("Acceleration x:{0:F1}  y:{1:F1}  z:{2:F1}\nAverage:{3:F1}", 0, 0, 0, 0);
    }

    /// <summary>
    /// ラベル表示の更新
    /// </summary>
    private void RefreshStepsCounterLabel()
    {
        float x = accelerateManager.AccelerateValueX;
        float y = accelerateManager.AccelerateValueY;
        float z = accelerateManager.AccelerateValueZ;
        float average = accelerateManager.CalculateAccelerateValuesAvarage();

        var label = this.GetComponent<Text>();
        label.text = string.Format("Acceleration x:{0:F1}  y:{1:F1}  z:{2:F1}\nAverage:{3:F1}", x, y, z, average);
    }
}
