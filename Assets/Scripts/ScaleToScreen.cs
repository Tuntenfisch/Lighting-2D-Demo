using Unity.Mathematics;
using UnityEngine;

[ExecuteAlways]
public class ScaleToScreen : MonoBehaviour
{
    #region Inspector Fields
    [SerializeField]
    private Camera m_camera;
    #endregion

    #region Unity Events
    private void LateUpdate()
    {
        float height = 2.0f * m_camera.orthographicSize;
        float width = m_camera.aspect * height;
        transform.localScale = new float3(width, height, 1.0f);
    }
    #endregion
}
