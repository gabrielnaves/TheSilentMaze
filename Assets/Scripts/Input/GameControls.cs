// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""ed969a0e-a42e-4c88-b6be-2ee4f4cde2c9"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""5f255c33-5106-46fe-ad53-a750e097ee12"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slow Walk"",
                    ""type"": ""Button"",
                    ""id"": ""081666d4-2e4c-4321-adcf-85c41449ca3d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Player Movement"",
                    ""type"": ""Button"",
                    ""id"": ""4a310822-f6e2-4d29-8219-d6b24b467117"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera Movement Joystick"",
                    ""type"": ""Button"",
                    ""id"": ""a52e0f5f-19aa-4f9d-80c1-9658f23b6ca7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera Movement Mouse"",
                    ""type"": ""Button"",
                    ""id"": ""b5da1bb9-f9aa-4e78-ae7a-62a6f95e6e84"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ac9c7f95-ec27-4be9-b9fe-8d8f17a7b1e3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""af781347-a8d6-4a92-9067-822b5456a949"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4c67731e-7915-4690-82d3-612f92729609"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4df7a8bf-b36f-4264-943b-d1416fe30314"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f5d463fd-04e7-42de-a1be-58b0817d4627"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""7a4c44f1-4de4-4c27-a545-c6204d67ad72"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bd5a29d2-a0fc-4d26-a747-854e4edcae3e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""82b736d4-455f-423a-9140-a2e0d5d2d2af"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d5be754-138a-43b4-8ab5-a6fee4095113"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4f82fec9-8a46-4bf1-a537-e4ffc8686461"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Right Stick"",
                    ""id"": ""11e12628-9566-4fdd-876b-91854784cd31"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement Joystick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eccc3d4e-1483-4fd8-bb25-d396a53fd347"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cec22bbc-70db-4a52-9564-2600888a0b24"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""60e6d7b1-15d1-4216-9584-290d1f35bfdf"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bcea2f51-820f-4ec6-9507-a8220bdff008"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b599bc65-d80b-4bba-a787-d2b114c1b75a"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""646aeb8b-7963-4691-a7e0-7fae50db5cee"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e6d8372-3566-4835-91fe-2c03e19a1be5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slow Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e76a662a-6ce0-4b1c-82f1-fb910c91dffe"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slow Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14ae70c2-40dd-4185-b580-c82460c7ea85"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Movement Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""b3bf418a-3b59-4b8f-afd1-7bda09061d8f"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""06fca7dd-b25d-4695-87de-b6cc48979188"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigation"",
                    ""type"": ""Button"",
                    ""id"": ""e36b848e-92da-4242-9dd8-ef9fbbd1575e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""32c2d720-cdf9-4fb2-b07d-abf24c49a026"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DialogueContinue"",
                    ""type"": ""Button"",
                    ""id"": ""abc72b97-288d-4a65-b953-5037ec80e48f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a4596689-1489-4392-8ba5-b5540df526f0"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5258afe0-7bd3-47f5-8a1e-9936d3017335"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""08e85e3f-c804-4300-be16-81acc7e20117"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""29ccf163-4154-4bb7-acbd-0564b6d4cfdc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""48e20219-75e1-4e4b-9750-bd703b5e2775"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""58b42b63-bb1b-4fae-ac91-cc4a5cd0d69e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""08e0b149-ded4-4098-b323-ba5859884de3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""be1c67f6-142f-4aed-b8b7-521b94b48d4d"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8b47b49c-da8c-4d00-be9d-2b74e2bdacf0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7639339f-c650-4713-82e4-7895b9b8dd45"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ecc198c5-a3cb-44d6-ab18-8ddd7164ab96"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd23fe98-2b10-422d-aed5-d3abe9bb6698"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b3b8c269-4819-4999-83f6-2b231cc8da3e"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""ad4f1879-8d5e-44bf-affc-9b3f7aafa2cd"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3ea028bd-4d0a-4366-858d-f6bad32f1cbd"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=1000),Clamp(max=1)"",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""180a4470-8745-4d3a-9785-e1632ac628ad"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=1000),Clamp(max=1)"",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9ff2f474-c7af-4447-beb6-5e9ada70230f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=1000),Clamp(max=1)"",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ee996e99-36c1-4c23-8c17-720046a8c440"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=1000),Clamp(max=1)"",
                    ""groups"": """",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e587db9f-5a35-4390-a6ff-6a5dc5c18631"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45e38118-57a3-4ab8-8dfe-19b006d59be6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29e7b303-8eec-4f46-9f23-463bd03ca90a"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ba772bf-aa38-4d8c-b2f3-547c540996a7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1958014b-e6ac-41ad-a646-0c1144238f59"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a10c7ae0-866e-4de3-a7e0-acaea6626888"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c40f3cb-799e-43eb-a8b3-1f24dbe1a60c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ceb5660-7d82-40ef-bc88-f8ef101678aa"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dd13278-454c-4986-9287-b86c60982906"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab4fc84e-8859-438b-99f1-3e35d4ade6ee"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a12b6d7-6bfc-4012-ba0a-d914d0678be2"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueContinue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ControlType"",
            ""id"": ""db87fd18-0c70-41f5-be6b-c2d28f8f7bed"",
            ""actions"": [
                {
                    ""name"": ""Keyboard"",
                    ""type"": ""Button"",
                    ""id"": ""d2b6af58-2369-4b76-8625-1164efa4cd12"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Controller"",
                    ""type"": ""Button"",
                    ""id"": ""3c80a49d-f3c4-4d64-bf5a-46965c706f81"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PS4"",
                    ""type"": ""Button"",
                    ""id"": ""47354b5c-1d07-4ad2-9bec-db030453136f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ca39412a-ce2e-498b-9d73-a2dbd565ea78"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49f0155a-f604-477e-a25f-04d77466ffef"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e89f0ae7-1023-4cdc-83de-5d4af3d89029"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0d8fed4-7d1e-4c75-b736-9307700171cd"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9613d9d-66ff-4f2f-902a-84c22c7cd6a9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf64e168-ca32-4cd6-81a2-698fd1543b2f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2955b65-ff04-4030-ae49-3f6be822bfeb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9521732f-aa19-4ae3-8c33-4df3f67dc10e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b33111e8-cb05-4aa1-b825-b7af310a1a71"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4382ea46-ea01-482f-9c06-0b46811c0114"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""699d5be2-4a50-42ad-8fab-9b143d39757e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b01758c-9efc-4534-9fff-7057cf0e96d6"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0abc6254-812b-499c-923d-08ce80c0327f"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d96c8b8-b672-43c4-8448-610471d455d3"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d75bdf3-2e01-44e6-8fe4-d50e302836d2"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""397f68ef-aaf4-4709-bb6f-97b0148a8d7a"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2910cc21-6387-4248-8996-6ba8a0257efb"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""187b7a94-8340-4337-9726-a7ae6bd5e824"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e67865d-ad34-456a-bb1f-18eb9afdc5e7"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e159180-6d99-492a-af58-acd35f8f877d"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74001cbb-4187-4dd0-8f19-ba5ebdaee840"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82c749f3-2227-4065-b935-4e09118e586a"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf6b6ee0-b804-49c4-90ca-55669d37ccf6"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25d03879-7ebe-4f4d-86bc-e5fcf96f0079"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6241e779-fd6a-4235-9f32-1d6826ce43f8"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60d50cbe-021d-4e08-a799-a8ba32c59bae"",
                    ""path"": ""<DualShockGamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1473f6c6-b042-4ae3-a509-6f0957bf56b2"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4466c331-5c4c-4c66-a1bd-a50049d576fa"",
                    ""path"": ""<DualShockGamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86c0076f-0e9d-4f72-918c-cca62cfcc937"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PS4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Run = m_Gameplay.FindAction("Run", throwIfNotFound: true);
        m_Gameplay_SlowWalk = m_Gameplay.FindAction("Slow Walk", throwIfNotFound: true);
        m_Gameplay_PlayerMovement = m_Gameplay.FindAction("Player Movement", throwIfNotFound: true);
        m_Gameplay_CameraMovementJoystick = m_Gameplay.FindAction("Camera Movement Joystick", throwIfNotFound: true);
        m_Gameplay_CameraMovementMouse = m_Gameplay.FindAction("Camera Movement Mouse", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
        m_UI_Navigation = m_UI.FindAction("Navigation", throwIfNotFound: true);
        m_UI_Select = m_UI.FindAction("Select", throwIfNotFound: true);
        m_UI_DialogueContinue = m_UI.FindAction("DialogueContinue", throwIfNotFound: true);
        // ControlType
        m_ControlType = asset.FindActionMap("ControlType", throwIfNotFound: true);
        m_ControlType_Keyboard = m_ControlType.FindAction("Keyboard", throwIfNotFound: true);
        m_ControlType_Controller = m_ControlType.FindAction("Controller", throwIfNotFound: true);
        m_ControlType_PS4 = m_ControlType.FindAction("PS4", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Run;
    private readonly InputAction m_Gameplay_SlowWalk;
    private readonly InputAction m_Gameplay_PlayerMovement;
    private readonly InputAction m_Gameplay_CameraMovementJoystick;
    private readonly InputAction m_Gameplay_CameraMovementMouse;
    public struct GameplayActions
    {
        private @GameControls m_Wrapper;
        public GameplayActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_Gameplay_Run;
        public InputAction @SlowWalk => m_Wrapper.m_Gameplay_SlowWalk;
        public InputAction @PlayerMovement => m_Wrapper.m_Gameplay_PlayerMovement;
        public InputAction @CameraMovementJoystick => m_Wrapper.m_Gameplay_CameraMovementJoystick;
        public InputAction @CameraMovementMouse => m_Wrapper.m_Gameplay_CameraMovementMouse;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Run.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @SlowWalk.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSlowWalk;
                @SlowWalk.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSlowWalk;
                @SlowWalk.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSlowWalk;
                @PlayerMovement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPlayerMovement;
                @CameraMovementJoystick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovementJoystick;
                @CameraMovementJoystick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovementJoystick;
                @CameraMovementJoystick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovementJoystick;
                @CameraMovementMouse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovementMouse;
                @CameraMovementMouse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovementMouse;
                @CameraMovementMouse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMovementMouse;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @SlowWalk.started += instance.OnSlowWalk;
                @SlowWalk.performed += instance.OnSlowWalk;
                @SlowWalk.canceled += instance.OnSlowWalk;
                @PlayerMovement.started += instance.OnPlayerMovement;
                @PlayerMovement.performed += instance.OnPlayerMovement;
                @PlayerMovement.canceled += instance.OnPlayerMovement;
                @CameraMovementJoystick.started += instance.OnCameraMovementJoystick;
                @CameraMovementJoystick.performed += instance.OnCameraMovementJoystick;
                @CameraMovementJoystick.canceled += instance.OnCameraMovementJoystick;
                @CameraMovementMouse.started += instance.OnCameraMovementMouse;
                @CameraMovementMouse.performed += instance.OnCameraMovementMouse;
                @CameraMovementMouse.canceled += instance.OnCameraMovementMouse;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Pause;
    private readonly InputAction m_UI_Navigation;
    private readonly InputAction m_UI_Select;
    private readonly InputAction m_UI_DialogueContinue;
    public struct UIActions
    {
        private @GameControls m_Wrapper;
        public UIActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputAction @Navigation => m_Wrapper.m_UI_Navigation;
        public InputAction @Select => m_Wrapper.m_UI_Select;
        public InputAction @DialogueContinue => m_Wrapper.m_UI_DialogueContinue;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Navigation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigation;
                @Navigation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigation;
                @Navigation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigation;
                @Select.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @DialogueContinue.started -= m_Wrapper.m_UIActionsCallbackInterface.OnDialogueContinue;
                @DialogueContinue.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnDialogueContinue;
                @DialogueContinue.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnDialogueContinue;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Navigation.started += instance.OnNavigation;
                @Navigation.performed += instance.OnNavigation;
                @Navigation.canceled += instance.OnNavigation;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @DialogueContinue.started += instance.OnDialogueContinue;
                @DialogueContinue.performed += instance.OnDialogueContinue;
                @DialogueContinue.canceled += instance.OnDialogueContinue;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // ControlType
    private readonly InputActionMap m_ControlType;
    private IControlTypeActions m_ControlTypeActionsCallbackInterface;
    private readonly InputAction m_ControlType_Keyboard;
    private readonly InputAction m_ControlType_Controller;
    private readonly InputAction m_ControlType_PS4;
    public struct ControlTypeActions
    {
        private @GameControls m_Wrapper;
        public ControlTypeActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Keyboard => m_Wrapper.m_ControlType_Keyboard;
        public InputAction @Controller => m_Wrapper.m_ControlType_Controller;
        public InputAction @PS4 => m_Wrapper.m_ControlType_PS4;
        public InputActionMap Get() { return m_Wrapper.m_ControlType; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlTypeActions set) { return set.Get(); }
        public void SetCallbacks(IControlTypeActions instance)
        {
            if (m_Wrapper.m_ControlTypeActionsCallbackInterface != null)
            {
                @Keyboard.started -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnKeyboard;
                @Keyboard.performed -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnKeyboard;
                @Keyboard.canceled -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnKeyboard;
                @Controller.started -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnController;
                @Controller.performed -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnController;
                @Controller.canceled -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnController;
                @PS4.started -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnPS4;
                @PS4.performed -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnPS4;
                @PS4.canceled -= m_Wrapper.m_ControlTypeActionsCallbackInterface.OnPS4;
            }
            m_Wrapper.m_ControlTypeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Keyboard.started += instance.OnKeyboard;
                @Keyboard.performed += instance.OnKeyboard;
                @Keyboard.canceled += instance.OnKeyboard;
                @Controller.started += instance.OnController;
                @Controller.performed += instance.OnController;
                @Controller.canceled += instance.OnController;
                @PS4.started += instance.OnPS4;
                @PS4.performed += instance.OnPS4;
                @PS4.canceled += instance.OnPS4;
            }
        }
    }
    public ControlTypeActions @ControlType => new ControlTypeActions(this);
    public interface IGameplayActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnSlowWalk(InputAction.CallbackContext context);
        void OnPlayerMovement(InputAction.CallbackContext context);
        void OnCameraMovementJoystick(InputAction.CallbackContext context);
        void OnCameraMovementMouse(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnNavigation(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnDialogueContinue(InputAction.CallbackContext context);
    }
    public interface IControlTypeActions
    {
        void OnKeyboard(InputAction.CallbackContext context);
        void OnController(InputAction.CallbackContext context);
        void OnPS4(InputAction.CallbackContext context);
    }
}
