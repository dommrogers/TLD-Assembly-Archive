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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomCameraPosition), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "UpdateLayer")]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool AnyButtonsOrKeysPressed()
	{
		return false;
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetState(State newState)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsPlayerCameraPositionValid")]
	[Calls(Type = typeof(PanViewCamera), Member = "PanToTransform")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsPlayerCameraPositionValid")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool GetIsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CustomCameraPosition), Member = "IsInteractible")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateLayer()
	{
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "GetHoverText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	private bool IsPlayerCameraPositionValid()
	{
		return false;
	}

	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "UpdateLayer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsInteractible()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CustomCameraPosition()
	{
	}
}
