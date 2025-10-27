using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UpdateRepertoire : MonoBehaviour
{
    [SerializeField] PlayerTracker playerMoveSet;
    [SerializeField] Image repIcon;
    [SerializeField] TextMeshProUGUI moveName;
    [SerializeField] TextMeshProUGUI desc;

    private List<TestMoves> rep;
    private int current = 0;

    private InputSystem_Actions playerControls;
    private InputAction next;
    private InputAction prev;

    void Awake()
    {
        // Create input actions BEFORE OnEnable runs
        playerControls = new InputSystem_Actions();
        // Option A: enable the whole asset
        playerControls.Enable();
        // Option B (either/or): enable just the Player map
        // playerControls.Player.Enable();
    }

    void Start()
    {
        rep = playerMoveSet.moveSet;
        UpdateUI(); // draw initial state
    }

    void OnEnable()
    {
        // Now playerControls is valid
        next = playerControls.Player.Next;
        prev = playerControls.Player.Previous;

        next.performed += NextPage;
        prev.performed += PrevPage;
    }

    void OnDisable()
    {
        if (next != null) next.performed -= NextPage;
        if (prev != null) prev.performed -= PrevPage;
    }

    private void NextPage(InputAction.CallbackContext _)
    {
        current++;
        ClampIndex();
        Debug.Log(current);
        UpdateUI();
    }

    private void PrevPage(InputAction.CallbackContext _)
    {
        current--;
        ClampIndex();
        Debug.Log(current);
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (rep == null || rep.Count == 0) return;
        ClampIndex();

        var item = rep[current];
        if (item == null) return;

        repIcon.sprite = item.icon;
        moveName.text = item.moveName;
        desc.text = item.desc;
    }

    private void ClampIndex()
    {
        if (rep == null || rep.Count == 0) { current = 0; return; }
        current = Mathf.Clamp(current, 0, rep.Count - 1);
    }
}
