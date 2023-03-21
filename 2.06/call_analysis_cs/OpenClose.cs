using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class OpenClose : LockedInteraction
{
	private const string DEFAULT_ANIM_PARAMETER_IS_OPEN = "IsOpen";

	private const string DEFAULT_ANIM_PARAMETER_SPEED_MULTIPLIER = "OpenCloseSpeedMultiplier";

	private const float IMMEDIATE_OPEN_CLOSE_SPEED_MULTIPLIER = 1000f;

	public LocalizedString m_LocalizedDisplayName;

	public AK.Wwise.Event m_OpenAudioEvent;

	public AK.Wwise.Event m_CloseAudioEvent;

	private string m_OpenAudio;

	private string m_CloseAudio;

	public GameObject m_ReverseAnimLocator;

	public bool m_AllowInteractionWhileCarrying;

	public bool m_StartOpened;

	public bool m_DisableOnClose;

	public bool m_DisableOnOpen;

	public bool m_DisableCollisionDuringAnimation;

	public bool m_SendInteractionCompleteEvent;

	private string m_AnimParameter_IsOpen;

	private string m_AnimParameter_SpeedMultiplier;

	private OpenClose[] m_LinkedObjects;

	private float m_NavmeshObstaclePadding;

	private bool m_IsOpen;

	private ObjectAnim m_ObjectAnim;

	private bool m_AnimsReversed;

	private bool m_StartHasBeenCalled;

	private bool m_Animating;

	private Animator m_Animator;

	private int m_AnimParameterHash_IsOpen;

	private int m_AnimParameterHash_SpeedMultiplier;

	private float m_DefaultOpenCloseSpeedMultiplierValue;

	private NavMeshObstacle m_NavmeshObstacle;

	private bool m_ForceOpenOnUpdate;

	private SafeCracking m_Safe;

	private static OpenCloseSaveDataProxy m_OpenCloseSaveDataProxy;

	public override bool CanInteract
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(LockedInteraction), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	protected override void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	public void UpdateOpenClose()
	{
	}

	[Calls(Type = typeof(SafeCracking), Member = "Serialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(OpenCloseManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(SafeCracking), Member = "Deserialize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[Calls(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TryOpenCloseAgain()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool DisabledInCurrentState()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "OnOpen")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Update")]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ObjectAnim), Member = "GoToEndImmediate")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(OpenClose), Member = "AnimateOpen")]
	private void Open(bool isImmediate, bool fromLink)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Close(bool isImmediate)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SafeCracking), Member = "CloseSafe")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectAnim), Member = "GoToEndImmediate")]
	private void Close(bool isImmediate, bool fromLink)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	private void AnimateOpen(bool isOpen)
	{
	}

	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	public void OnStateDone()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallsUnknownMethods(Count = 3)]
	private bool PlayAnimInReverse()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnStateDone")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CallsUnknownMethods(Count = 4)]
	private void SetCollisionEnabled(bool enabled)
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	private void SetAnimationSpeed(float value)
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_shape")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_carving")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeCreateNavMeshObstacle()
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private void MaybeUpdateNavmeshObstacleState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public OpenClose()
	{
	}
}
