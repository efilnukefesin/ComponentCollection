// GENERATED AUTOMATICALLY FROM 'Assets/ComponentCollection/Input/10Mixed2DAnd3D/TopdownControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ComponentCollection.Input.Mixed2DAnd3D
{
    public class @TopdownControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; } 
        public @TopdownControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TopdownControls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""2087bf87-35b6-4508-bf92-d87f388b6961"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""74f49807-c4d9-4979-aae9-55c4d710e2c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""aeeb8391-9a08-480c-b7bb-f1cd8c4c0bc1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""02b0117a-30cc-4fd3-b8c4-8180f0361fec"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b77e272d-8bda-4724-b32d-d23ab0e17ae4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c19d1b82-a4a2-40b8-b7d8-0fdb6a09fe38"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c5e651e-c7de-4b41-ac4e-ee2e16a8b511"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Default
            m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
            m_Default_Left = m_Default.FindAction("Left", throwIfNotFound: true);
            m_Default_Right = m_Default.FindAction("Right", throwIfNotFound: true);
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

        // Default
        private readonly InputActionMap m_Default;
        private IDefaultActions m_DefaultActionsCallbackInterface;
        private readonly InputAction m_Default_Left;
        private readonly InputAction m_Default_Right;
        public struct DefaultActions
        {
            private @TopdownControls m_Wrapper;
            public DefaultActions(@TopdownControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Left => m_Wrapper.m_Default_Left;
            public InputAction @Right => m_Wrapper.m_Default_Right;
            public InputActionMap Get() { return m_Wrapper.m_Default; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
            public void SetCallbacks(IDefaultActions instance)
            {
                if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
                {
                    @Left.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                    @Left.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                    @Left.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                    @Right.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                    @Right.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                    @Right.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                }
                m_Wrapper.m_DefaultActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Left.started += instance.OnLeft;
                    @Left.performed += instance.OnLeft;
                    @Left.canceled += instance.OnLeft;
                    @Right.started += instance.OnRight;
                    @Right.performed += instance.OnRight;
                    @Right.canceled += instance.OnRight;
                }
            }
        }
        public DefaultActions @Default => new DefaultActions(this);
        public interface IDefaultActions
        {
            void OnLeft(InputAction.CallbackContext context);
            void OnRight(InputAction.CallbackContext context);
        }
    }
}
