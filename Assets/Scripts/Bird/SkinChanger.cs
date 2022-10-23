using UnityEngine;
using UnityEngine.UI;

public class SkinChanger : MonoBehaviour
{
    [SerializeField] private GameObject _Panel;
    [SerializeField] private GameObject _Object;
    [SerializeField] private GameObject _Bird;
    [SerializeField] private Image _YellowBird;
    [SerializeField] private Image _BlueBird;
    [SerializeField] private Image _RedBird;

    public void ChooseSprite()
    {
        _Panel.SetActive(true);
    }
    public void ChangeRedBird()
    {
        _Object.GetComponent<Image>().sprite = _RedBird.sprite;
        _Bird.GetComponent<SpriteRenderer>().sprite = _RedBird.sprite;
        _Panel.SetActive(false);
    }
    public void ChangeBlueBird()
    {
        _Object.GetComponent<Image>().sprite = _BlueBird.sprite;
        _Bird.GetComponent<SpriteRenderer>().sprite = _BlueBird.sprite;
        _Panel.SetActive(false);
    }
    public void ChangeYellowBird()
    {
        _Object.GetComponent<Image>().sprite = _YellowBird.sprite;
        _Bird.GetComponent<SpriteRenderer>().sprite = _YellowBird.sprite;
        _Panel.SetActive(false);
    }
}
