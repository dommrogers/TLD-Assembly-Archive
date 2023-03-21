using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.ModularElectrolizer;
using TLD.UI.Generics;
using UnityEngine;

public class CustomCameraPosition : MonoBehaviour
{
	public enum State
	{
		Inactive,
		Activating,
		Active
	}

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_InteractOnlyFromFront;

	private Transform m_CameraTarget;

	public Action<State> m_OnStateChange;

	private State m_State;

	private AuroraModularElectrolizer m_Electrolizer;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	private void Update()
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	private bool AnyButtonsOrKeysPressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "OnDestroy")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "PerformInteraction")]
	private void SetState(State newState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsPlayerCameraPositionValid")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsPlayerCameraPositionValid")]
	private bool CanInteract()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSController), Member = "Stop")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 0)]
	public bool GetIsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "CanInteract")]
	[CallsUnknownMethods(Count = 9)]
	private bool IsPlayerCameraPositionValid()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "CanInteract")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "UpdateInteraction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	private bool IsInteractible()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CustomCameraPosition()
	{
	}
}
