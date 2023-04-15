using UnityEngine;

public class InputManager : MonoBehaviour
{
    UIManager uiManager;

    Commands xKeys;
    Commands zKeys;

    [SerializeField] Rigidbody player;

    [Range (1, 10)]
    [SerializeField] float speed = 4;

    private void Start()
    {
        xKeys = new Xdirection();
        zKeys = new Zdirection();

        uiManager = UIManager.instance;
    }

    private void Update()
    {
        if (uiManager.isEditing)
            return;

        if (Input.GetKey(uiManager.forwardKey.text))
            zKeys.Excecute(player, speed, 1);
        else if (Input.GetKey(uiManager.backwardKey.text))
            zKeys.Excecute(player, speed, -1);
        else
            zKeys.Excecute(player, speed, 0);

        if (Input.GetKey(uiManager.rightKey.text))
            xKeys.Excecute(player, speed, 1);
        else if (Input.GetKey(uiManager.lefyKey.text))
            xKeys.Excecute(player, speed, -1);
        else
            xKeys.Excecute(player, speed, 0);
    }
}
