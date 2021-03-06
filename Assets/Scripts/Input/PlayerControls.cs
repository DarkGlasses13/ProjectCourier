//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/Input/PlayerControlsEditor.inputactions
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

namespace Assets.Scripts
{
    public partial class @PlayerControls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlsEditor"",
    ""maps"": [
        {
            ""name"": ""Swipe"",
            ""id"": ""c0f82c65-d962-4051-b2d6-801797e84144"",
            ""actions"": [
                {
                    ""name"": ""OnTouch"",
                    ""type"": ""Button"",
                    ""id"": ""aaf7213d-937e-4e36-bc07-5f8525d14a98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""StartTouch"",
                    ""type"": ""Value"",
                    ""id"": ""90179a22-fbfa-4dae-9438-57e6c7c2c547"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""8423398a-2194-4c5a-ad6a-c5adaa7bd60b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7112a94-4377-4fe1-8661-e3ca467d7b5a"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""OnTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16677458-0f22-4876-ae02-94d33feb26a4"",
                    ""path"": ""<Touchscreen>/primaryTouch/startPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""StartTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8687ce3-170e-492c-b721-573905b94ccd"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""TouchScreen"",
            ""bindingGroup"": ""TouchScreen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Swipe
            m_Swipe = asset.FindActionMap("Swipe", throwIfNotFound: true);
            m_Swipe_OnTouch = m_Swipe.FindAction("OnTouch", throwIfNotFound: true);
            m_Swipe_StartTouch = m_Swipe.FindAction("StartTouch", throwIfNotFound: true);
            m_Swipe_Position = m_Swipe.FindAction("Position", throwIfNotFound: true);
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

        // Swipe
        private readonly InputActionMap m_Swipe;
        private ISwipeActions m_SwipeActionsCallbackInterface;
        private readonly InputAction m_Swipe_OnTouch;
        private readonly InputAction m_Swipe_StartTouch;
        private readonly InputAction m_Swipe_Position;
        public struct SwipeActions
        {
            private @PlayerControls m_Wrapper;
            public SwipeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @OnTouch => m_Wrapper.m_Swipe_OnTouch;
            public InputAction @StartTouch => m_Wrapper.m_Swipe_StartTouch;
            public InputAction @Position => m_Wrapper.m_Swipe_Position;
            public InputActionMap Get() { return m_Wrapper.m_Swipe; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SwipeActions set) { return set.Get(); }
            public void SetCallbacks(ISwipeActions instance)
            {
                if (m_Wrapper.m_SwipeActionsCallbackInterface != null)
                {
                    @OnTouch.started -= m_Wrapper.m_SwipeActionsCallbackInterface.OnOnTouch;
                    @OnTouch.performed -= m_Wrapper.m_SwipeActionsCallbackInterface.OnOnTouch;
                    @OnTouch.canceled -= m_Wrapper.m_SwipeActionsCallbackInterface.OnOnTouch;
                    @StartTouch.started -= m_Wrapper.m_SwipeActionsCallbackInterface.OnStartTouch;
                    @StartTouch.performed -= m_Wrapper.m_SwipeActionsCallbackInterface.OnStartTouch;
                    @StartTouch.canceled -= m_Wrapper.m_SwipeActionsCallbackInterface.OnStartTouch;
                    @Position.started -= m_Wrapper.m_SwipeActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_SwipeActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_SwipeActionsCallbackInterface.OnPosition;
                }
                m_Wrapper.m_SwipeActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @OnTouch.started += instance.OnOnTouch;
                    @OnTouch.performed += instance.OnOnTouch;
                    @OnTouch.canceled += instance.OnOnTouch;
                    @StartTouch.started += instance.OnStartTouch;
                    @StartTouch.performed += instance.OnStartTouch;
                    @StartTouch.canceled += instance.OnStartTouch;
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                }
            }
        }
        public SwipeActions @Swipe => new SwipeActions(this);
        private int m_TouchScreenSchemeIndex = -1;
        public InputControlScheme TouchScreenScheme
        {
            get
            {
                if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("TouchScreen");
                return asset.controlSchemes[m_TouchScreenSchemeIndex];
            }
        }
        public interface ISwipeActions
        {
            void OnOnTouch(InputAction.CallbackContext context);
            void OnStartTouch(InputAction.CallbackContext context);
            void OnPosition(InputAction.CallbackContext context);
        }
    }
}
