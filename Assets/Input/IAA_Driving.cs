//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/IAA_Driving.inputactions
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

public partial class @IAA_Driving: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @IAA_Driving()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""IAA_Driving"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""a6f195eb-1c39-4eee-a5a9-71abe86f5012"",
            ""actions"": [
                {
                    ""name"": ""Turning"",
                    ""type"": ""Value"",
                    ""id"": ""e4072966-b347-42e6-99a3-197abd139b01"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""f6f5b4cb-4bbf-4bfd-8cb0-8ce76279f46b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""b729dba4-256b-4d7c-86c0-7c137816dd02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Nitrous"",
                    ""type"": ""Button"",
                    ""id"": ""98bd1919-230a-4b74-be79-b0990f6c95fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3fcd4aad-fe9e-4230-907f-04f4da9ce6ca"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""15154bec-a57c-4f99-aa0f-2e6de2cf1c35"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3c8d7033-77f4-4c16-be95-970abb2b8908"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb80862b-0cc5-4b46-aeb7-c0cd214b0d87"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3638736e-a17e-40cd-827c-1fb604d916b7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90c32444-fefb-49e7-9417-0b73ebf9e9d0"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Nitrous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Driving"",
            ""bindingGroup"": ""Driving"",
            ""devices"": []
        }
    ]
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Turning = m_Driving.FindAction("Turning", throwIfNotFound: true);
        m_Driving_Accelerate = m_Driving.FindAction("Accelerate", throwIfNotFound: true);
        m_Driving_Brake = m_Driving.FindAction("Brake", throwIfNotFound: true);
        m_Driving_Nitrous = m_Driving.FindAction("Nitrous", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private List<IDrivingActions> m_DrivingActionsCallbackInterfaces = new List<IDrivingActions>();
    private readonly InputAction m_Driving_Turning;
    private readonly InputAction m_Driving_Accelerate;
    private readonly InputAction m_Driving_Brake;
    private readonly InputAction m_Driving_Nitrous;
    public struct DrivingActions
    {
        private @IAA_Driving m_Wrapper;
        public DrivingActions(@IAA_Driving wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turning => m_Wrapper.m_Driving_Turning;
        public InputAction @Accelerate => m_Wrapper.m_Driving_Accelerate;
        public InputAction @Brake => m_Wrapper.m_Driving_Brake;
        public InputAction @Nitrous => m_Wrapper.m_Driving_Nitrous;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void AddCallbacks(IDrivingActions instance)
        {
            if (instance == null || m_Wrapper.m_DrivingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DrivingActionsCallbackInterfaces.Add(instance);
            @Turning.started += instance.OnTurning;
            @Turning.performed += instance.OnTurning;
            @Turning.canceled += instance.OnTurning;
            @Accelerate.started += instance.OnAccelerate;
            @Accelerate.performed += instance.OnAccelerate;
            @Accelerate.canceled += instance.OnAccelerate;
            @Brake.started += instance.OnBrake;
            @Brake.performed += instance.OnBrake;
            @Brake.canceled += instance.OnBrake;
            @Nitrous.started += instance.OnNitrous;
            @Nitrous.performed += instance.OnNitrous;
            @Nitrous.canceled += instance.OnNitrous;
        }

        private void UnregisterCallbacks(IDrivingActions instance)
        {
            @Turning.started -= instance.OnTurning;
            @Turning.performed -= instance.OnTurning;
            @Turning.canceled -= instance.OnTurning;
            @Accelerate.started -= instance.OnAccelerate;
            @Accelerate.performed -= instance.OnAccelerate;
            @Accelerate.canceled -= instance.OnAccelerate;
            @Brake.started -= instance.OnBrake;
            @Brake.performed -= instance.OnBrake;
            @Brake.canceled -= instance.OnBrake;
            @Nitrous.started -= instance.OnNitrous;
            @Nitrous.performed -= instance.OnNitrous;
            @Nitrous.canceled -= instance.OnNitrous;
        }

        public void RemoveCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDrivingActions instance)
        {
            foreach (var item in m_Wrapper.m_DrivingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DrivingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);
    private int m_DrivingSchemeIndex = -1;
    public InputControlScheme DrivingScheme
    {
        get
        {
            if (m_DrivingSchemeIndex == -1) m_DrivingSchemeIndex = asset.FindControlSchemeIndex("Driving");
            return asset.controlSchemes[m_DrivingSchemeIndex];
        }
    }
    public interface IDrivingActions
    {
        void OnTurning(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnNitrous(InputAction.CallbackContext context);
    }
}
