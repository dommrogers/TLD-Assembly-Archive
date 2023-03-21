using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;

public class OpenClose : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public string m_OpenAudio;

	public string m_CloseAudio;

	public GameObject m_ReverseAnimLocator;

	public bool m_AllowInteractionWhileCarrying;

	public bool m_StartOpened;

	public bool m_DisableOnClose;

	public bool m_DisableOnOpen;

	public bool m_DisableCollisionDuringAnimation;

	public bool m_SendInteractionCompleteEvent;

	private const string DEFAULT_ANIM_PARAMETER_IS_OPEN = "IsOpen";

	private const string DEFAULT_ANIM_PARAMETER_SPEED_MULTIPLIER = "OpenCloseSpeedMultiplier";

	private const float IMMEDIATE_OPEN_CLOSE_SPEED_MULTIPLIER = 1000f;

	private string m_AnimParameter_IsOpen;

	private string m_AnimParameter_SpeedMultiplier;

	private OpenClose[] m_LinkedObjects;

	private float m_NavmeshObstaclePadding;

	private bool m_IsOpen;

	private ObjectAnim m_ObjectAnim;

	private Lock m_Lock;

	private bool m_AnimsReversed;

	private bool m_StartHasBeenCalled;

	private bool m_Animating;

	private Animator m_Animator;

	private int m_AnimParameterHash_IsOpen;

	private int m_AnimParameterHash_SpeedMultiplier;

	private float m_DefaultOpenCloseSpeedMultiplierValue;

	private NavMeshObstacle m_NavmeshObstacle;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private PlayerControlMode m_RestoreControlMode;

	private bool m_ForceOpenOnUpdate;

	private SafeCracking m_Safe;

	private static OpenCloseSaveDataProxy m_OpenCloseSaveDataProxy;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[CalledBy(Type = typeof(OpenClose), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Update_Internal()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(OpenClose), Member = "Cancel")]
	[Calls(Type = typeof(OpenClose), Member = "Cancel")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void UpdateOpenClose()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "SerializeAll")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SafeCracking), Member = "Serialize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(SafeCracking), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessOpenCloseInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ShouldShowClickHoldBackpiece")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanInteract()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool IsOpen()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Open(bool isImmediate)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "Update_Internal")]
	[CalledBy(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ObjectAnim), Member = "GoToEndImmediate")]
	[Calls(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "PlayAnimInReverse")]
	private void Open(bool isImmediate, bool fromLink)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	public void Close(bool isImmediate)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(OpenClose), Member = "Cancel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(SafeCracking), Member = "CloseSafe")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[Calls(Type = typeof(ObjectAnim), Member = "GoToEndImmediate")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	private void Close(bool isImmediate, bool fromLink)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void AnimateOpen(bool isOpen)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsUnknownMethods(Count = 4)]
	public string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessOpenCloseInteraction")]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "ForceLockBegin")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Lock), Member = "GetGearItemToForceLock")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ForceLock()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsLocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void StartSafeCrackingInterface()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessOpenCloseInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnLockBroken")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void StartInteract()
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProgressBarStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	public void OnStateDone()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private bool PlayAnimInReverse()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(OpenClose), Member = "StartInteract")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	private void OnLockBroken()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(OpenClose), Member = "OnStateDone")]
	[CalledBy(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Update_Internal")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void SetCollisionEnabled(bool enabled)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(OpenClose), Member = "Awake")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CallsUnknownMethods(Count = 1)]
	private void SetAnimationSpeed(float value)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_carving")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_shape")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeCreateNavMeshObstacle()
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[CalledBy(Type = typeof(OpenClose), Member = "Update_Internal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	private void MaybeUpdateNavmeshObstacleState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public OpenClose()
	{
	}
}
