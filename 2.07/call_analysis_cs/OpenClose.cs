using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.Logging;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class OpenClose : LockedInteraction
{
	private const string DEFAULT_ANIM_PARAMETER_IS_OPEN = "IsOpen";

	private const string DEFAULT_ANIM_PARAMETER_SPEED_MULTIPLIER = "OpenCloseSpeedMultiplier";

	private const float IMMEDIATE_OPEN_CLOSE_SPEED_MULTIPLIER = 1000f;

	private static readonly LogFilter s_LogFilter;

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

	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectAnim), Member = "Initialize")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SafeCracking), Member = "Deserialize")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsOpen()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Open(bool isImmediate)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "OnOpen")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Update")]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(OpenClose), Member = "PlayAnimInReverse")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(ObjectAnim), Member = "GoToEndImmediate")]
	[Calls(Type = typeof(OpenClose), Member = "AnimateOpen")]
	private void Open(bool isImmediate, bool fromLink)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Close(bool isImmediate)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SafeCracking), Member = "CloseSafe")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(ObjectAnim), Member = "GoToEndImmediate")]
	[Calls(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private void Close(bool isImmediate, bool fromLink)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void AnimateOpen(bool isOpen)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public void OnStateDone()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CallsUnknownMethods(Count = 3)]
	private bool PlayAnimInReverse()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(OpenClose), Member = "OnStateDone")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	private void SetCollisionEnabled(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void SetAnimationSpeed(float value)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_shape")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_carving")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallerCount(Count = 1)]
	private void MaybeCreateNavMeshObstacle()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	private void MaybeUpdateNavmeshObstacleState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public OpenClose()
	{
	}
}
