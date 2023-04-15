using TMPro;
using UnityEngine;
using UnityEditor;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public bool isEditing = false;
    [Space]

    public TMP_InputField forwardKey;
    public TMP_InputField backwardKey;
    public TMP_InputField lefyKey;
    public TMP_InputField rightKey;


    private void Awake() => instance = this;

    private void Start()
    {
        forwardKey.text = PlayerPrefs.GetString(Keywords.forwardTag, "w");
        backwardKey.text = PlayerPrefs.GetString(Keywords.backwardTag, "s");
        lefyKey.text = PlayerPrefs.GetString(Keywords.leftTag, "a");
        rightKey.text = PlayerPrefs.GetString(Keywords.rightTag, "d");
    }

    public void _saveButton()
    {
        isEditing = false;

        forwardKey.interactable = false;
        backwardKey.interactable = false;
        lefyKey.interactable = false;
        rightKey.interactable = false;

        PlayerPrefs.SetString(Keywords.forwardTag, forwardKey.text);
        PlayerPrefs.SetString(Keywords.backwardTag, backwardKey.text);
        PlayerPrefs.SetString(Keywords.leftTag, lefyKey.text);
        PlayerPrefs.SetString(Keywords.rightTag, rightKey.text);
    }

    public void _EditButton()
    {
        isEditing = true;

        forwardKey.interactable = true;
        backwardKey.interactable = true;
        lefyKey.interactable = true;
        rightKey.interactable = true;
    }

#if UNITY_EDITOR
    [MenuItem("PlayerPref Settings/Delete PlayerPrefs (All)")]
    static void DeleteAllPlayerPrefs()
    {
        Debug.LogWarning("All keys deleted");
        PlayerPrefs.DeleteAll();
    }
#endif
}
