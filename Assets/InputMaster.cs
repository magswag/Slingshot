// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""c1dd6106-2cda-419b-87f3-b79e69b0d848"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""f56cca57-4e3c-4189-8509-518e697e0ec5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""e66f0e11-f911-4fea-b5b0-c5baa4d609e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""leftRight"",
                    ""id"": ""f3bf738c-f85e-41c1-af84-47b2304db837"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f16a807e-d227-483b-ac54-3357720e2dcf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cf0b2e39-d522-4309-bc20-346cfef4cd8c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""upDown"",
                    ""id"": ""2419df17-39eb-43a8-9092-430081001ae2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""edbb3547-a51b-4614-b033-8c05431e0eac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4e28dbd7-73b9-4cdf-a137-73c37674ea23"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""4f4aee8d-dd0d-40f8-9afb-dffbeae84201"",
            ""actions"": [
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""c7c3f100-c893-4eaa-bd5f-36b9e1925d66"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""001499ad-d0f2-4c0f-9c44-7b3890c25be2"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Global"",
            ""id"": ""c6ca68e2-cb98-4dc6-b569-0c7427157e16"",
            ""actions"": [
                {
                    ""name"": ""DecreaseTimeWarp"",
                    ""type"": ""Button"",
                    ""id"": ""5bacdc00-b3e6-4eb4-9192-ce28b5960d3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IncreaseTimeWarp"",
                    ""type"": ""Button"",
                    ""id"": ""29ac2c8b-ba54-44d4-bc2d-df3c07a2464f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f730140-9268-48d6-8598-2a29d626b4f0"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseTimeWarp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52f0fd99-2efd-486e-b88d-32fdfc092e58"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseTimeWarp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Rocket
        m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
        m_Rocket_Rotate = m_Rocket.FindAction("Rotate", throwIfNotFound: true);
        m_Rocket_Thrust = m_Rocket.FindAction("Thrust", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        // Global
        m_Global = asset.FindActionMap("Global", throwIfNotFound: true);
        m_Global_DecreaseTimeWarp = m_Global.FindAction("DecreaseTimeWarp", throwIfNotFound: true);
        m_Global_IncreaseTimeWarp = m_Global.FindAction("IncreaseTimeWarp", throwIfNotFound: true);
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

    // Rocket
    private readonly InputActionMap m_Rocket;
    private IRocketActions m_RocketActionsCallbackInterface;
    private readonly InputAction m_Rocket_Rotate;
    private readonly InputAction m_Rocket_Thrust;
    public struct RocketActions
    {
        private @InputMaster m_Wrapper;
        public RocketActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Rocket_Rotate;
        public InputAction @Thrust => m_Wrapper.m_Rocket_Thrust;
        public InputActionMap Get() { return m_Wrapper.m_Rocket; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
        public void SetCallbacks(IRocketActions instance)
        {
            if (m_Wrapper.m_RocketActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnRotate;
                @Thrust.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnThrust;
            }
            m_Wrapper.m_RocketActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
            }
        }
    }
    public RocketActions @Rocket => new RocketActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Zoom;
    public struct CameraActions
    {
        private @InputMaster m_Wrapper;
        public CameraActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Global
    private readonly InputActionMap m_Global;
    private IGlobalActions m_GlobalActionsCallbackInterface;
    private readonly InputAction m_Global_DecreaseTimeWarp;
    private readonly InputAction m_Global_IncreaseTimeWarp;
    public struct GlobalActions
    {
        private @InputMaster m_Wrapper;
        public GlobalActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @DecreaseTimeWarp => m_Wrapper.m_Global_DecreaseTimeWarp;
        public InputAction @IncreaseTimeWarp => m_Wrapper.m_Global_IncreaseTimeWarp;
        public InputActionMap Get() { return m_Wrapper.m_Global; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GlobalActions set) { return set.Get(); }
        public void SetCallbacks(IGlobalActions instance)
        {
            if (m_Wrapper.m_GlobalActionsCallbackInterface != null)
            {
                @DecreaseTimeWarp.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnDecreaseTimeWarp;
                @DecreaseTimeWarp.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnDecreaseTimeWarp;
                @DecreaseTimeWarp.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnDecreaseTimeWarp;
                @IncreaseTimeWarp.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnIncreaseTimeWarp;
                @IncreaseTimeWarp.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnIncreaseTimeWarp;
                @IncreaseTimeWarp.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnIncreaseTimeWarp;
            }
            m_Wrapper.m_GlobalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DecreaseTimeWarp.started += instance.OnDecreaseTimeWarp;
                @DecreaseTimeWarp.performed += instance.OnDecreaseTimeWarp;
                @DecreaseTimeWarp.canceled += instance.OnDecreaseTimeWarp;
                @IncreaseTimeWarp.started += instance.OnIncreaseTimeWarp;
                @IncreaseTimeWarp.performed += instance.OnIncreaseTimeWarp;
                @IncreaseTimeWarp.canceled += instance.OnIncreaseTimeWarp;
            }
        }
    }
    public GlobalActions @Global => new GlobalActions(this);
    public interface IRocketActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnThrust(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IGlobalActions
    {
        void OnDecreaseTimeWarp(InputAction.CallbackContext context);
        void OnIncreaseTimeWarp(InputAction.CallbackContext context);
    }
}
