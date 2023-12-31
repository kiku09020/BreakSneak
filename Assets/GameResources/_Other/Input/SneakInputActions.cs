//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/GameResources/_Other/Input/SneakInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @SneakInputClass: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @SneakInputClass()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SneakInputActions"",
    ""maps"": [
        {
            ""name"": ""SneakInput"",
            ""id"": ""b88948e1-e291-47aa-9796-8a1ec3ac0c16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""28942a7b-d718-4648-a7fd-2f6532b647d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""25748096-59c2-4450-ad36-35676beb79b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""364801c4-071d-4995-b65e-3b956a6c1855"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""b8371711-fc44-4a01-890d-c97d7a2ea818"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9fcaf81e-1773-47d5-8ae7-57ad592e07c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3e3c86da-48c2-4631-b01e-c2b581c16f66"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e9f3c19e-1dbd-4c05-bdd0-1059dd7a7013"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d602dc2f-a097-4eb0-9a91-db86a1b87f5d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""104a81d1-75f9-4fed-b292-783423234b97"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91689340-ead4-4054-9224-e39c41e71755"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SneakInput
        m_SneakInput = asset.FindActionMap("SneakInput", throwIfNotFound: true);
        m_SneakInput_Move = m_SneakInput.FindAction("Move", throwIfNotFound: true);
        m_SneakInput_Dash = m_SneakInput.FindAction("Dash", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // SneakInput
    private readonly InputActionMap m_SneakInput;
    private List<ISneakInputActions> m_SneakInputActionsCallbackInterfaces = new List<ISneakInputActions>();
    private readonly InputAction m_SneakInput_Move;
    private readonly InputAction m_SneakInput_Dash;
    public struct SneakInputActions
    {
        private @SneakInputClass m_Wrapper;
        public SneakInputActions(@SneakInputClass wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_SneakInput_Move;
        public InputAction @Dash => m_Wrapper.m_SneakInput_Dash;
        public InputActionMap Get() { return m_Wrapper.m_SneakInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SneakInputActions set) { return set.Get(); }
        public void AddCallbacks(ISneakInputActions instance)
        {
            if (instance == null || m_Wrapper.m_SneakInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SneakInputActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
        }

        private void UnregisterCallbacks(ISneakInputActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
        }

        public void RemoveCallbacks(ISneakInputActions instance)
        {
            if (m_Wrapper.m_SneakInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISneakInputActions instance)
        {
            foreach (var item in m_Wrapper.m_SneakInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SneakInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SneakInputActions @SneakInput => new SneakInputActions(this);
    public interface ISneakInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
}
