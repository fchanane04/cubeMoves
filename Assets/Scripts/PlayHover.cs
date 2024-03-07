using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using UnityEngine.SceneManagement;

public class PlayHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Button button;
    private Color normalColor;
    public Color hoverColor = new Color(192f / 255f, 249f / 255f, 172f / 255f, 1f); // Green color (C0F9AC) in Unity's Color format

    void Start()
    {
        button = GetComponent<Button>();
        normalColor = button.image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        button.image.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.image.color = normalColor;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
