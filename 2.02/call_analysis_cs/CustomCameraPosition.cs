using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomCameraPosition : MonoBehaviour
{
	public enum State
	{
		Inactive,
		Activating,
		Active
	}

	public delegate void OnStateChange(State state);

	public static bool m_SuppressCrosshairs;

	private bool m_InteractOnlyFromFront;

	private Transform m_CameraTarget;

	private LocalizedString m_LocalizedHoverText;

	public OnStateChange m_OnStateChange;

	private State m_State;

	private AuroraElectrolizer m_Electrolizer;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "UpdateLayer")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "AnyButtonsOrKeysPressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	private void Update()
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	private bool AnyButtonsOrKeysPressed()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetState(State newState)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsPlayerCameraPositionValid")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 3)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsPlayerCameraPositionValid")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool GetIsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateLayer()
	{
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 2)]
	private bool IsPlayerCameraPositionValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "UpdateLayer")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsInteractible()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CustomCameraPosition()
	{
	}
}
