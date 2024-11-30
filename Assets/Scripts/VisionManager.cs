using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionManager : MonoBehaviour
{
    [SerializeField] OVRPassthroughLayer passthroughLayer;
    [SerializeField] OVRManager ovrManager;
    private int currentColorIndex;

    Color[] colors =
    {
        new Color(0, 0, 0, 1), // 검정색
        new Color(1, 0, 0, 1), // 빨간색
        new Color(0, 1, 0, 1), // 초록색
        new Color(0, 0, 1, 1), // 파란색
        new Color(1, 1, 0, 1), // 노란색
        new Color(0, 0, 0, 0)  // Off (투명도 0)
    };

    private void Start()
    {
        currentColorIndex = 0;
        passthroughLayer.edgeColor = colors[currentColorIndex];
        ovrManager.shouldBoundaryVisibilityBeSuppressed = true;
    }

    public void ChangeEdgeColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        passthroughLayer.edgeColor = colors[currentColorIndex];
    }
}
