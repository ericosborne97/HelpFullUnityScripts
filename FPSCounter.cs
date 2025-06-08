using UnityEngine;
using UnityEngine.UI;
using TMPro;

 
public class FpsCounter : MonoBehaviour
{
    public TMP_Text _fpsText;

    [SerializeField] private float _hudRefreshRate = 1f;
 
    private float _timer;
 
    private void Update()
    {
        if (Time.unscaledTime > _timer)
        {
            int fps = (int)(1f / Time.unscaledDeltaTime);
            _fpsText.SetText("FPS: " + fps);
            _timer = Time.unscaledTime + _hudRefreshRate;
        }
    }
}