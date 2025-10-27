using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleUI : MonoBehaviour
{
    InputSystem_Actions playerControls;
    InputAction repertoire;
    InputAction bag;
    [SerializeField] GameObject repertoireUI;
    private bool toggleRep = false;
    private bool toggleBag = false;
    void Awake()
    {
        playerControls = new InputSystem_Actions();
        repertoireUI.SetActive(false);
    }
    void OnEnable()
    {
        repertoire = playerControls.Player.ToggleRepitoire;
        repertoire.Enable();
        bag = playerControls.Player.ToggleBag;
        bag.Enable();

        repertoire.performed += RepertoireToggle;
        bag.performed += BagToggle;
    }

    void OnDisable()
    {
        repertoire.performed += RepertoireToggle;
        bag.performed -= BagToggle;

        repertoire.Disable();
        bag.Disable();
    }
    void Update()
    {

    }

    private void RepertoireToggle(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            toggleRep = !toggleRep;
            Debug.Log("Repertoire: " + toggleRep);
            repertoireUI.SetActive(toggleRep);
        }
    }
    private void BagToggle(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            toggleBag = !toggleBag;
            Debug.Log("Bag: " + toggleBag);
            
        }
    }
}

