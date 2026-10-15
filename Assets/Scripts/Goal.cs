using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI goaltext;

    // IsTrigeer‚É”½‰‚ª‚ ‚é‚©Šm”F
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        // Canvas‚ÉƒS[ƒ‹‚µ‚½î•ñ‚ğ‘—‚é
        goaltext.enabled = true;
    }
}
