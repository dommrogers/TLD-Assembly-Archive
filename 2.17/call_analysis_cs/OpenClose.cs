using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using InteractiveObjects;
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

	private TimelinePlayback m_TimelinePlayback;

	private TimelinePlayback.TimelineInfo m_OpenTimelineInfo;

	private TimelinePlayback.TimelineInfo m_CloseTimelineInfo;

	private Renderer[] m_Renderers;

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
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LockedInteraction), Member = "Awake")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectAnim), Member = "Initialize")]
	[Calls(Type = typeof(Lock), Member = "RollLockedState")]
	[Calls(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateOpenClose()
	{
	}

	[CalledBy(Type = typeof(OpenCloseManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Serialize")]
	[Calls(Type = typeof(SafeCracking), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(OpenCloseManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Lock), Member = "Deserialize")]
	[Calls(Type = typeof(SafeCracking), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[CalledBy(Type = typeof(TransmitterSwitchInteraction), Member = "PerformHold")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override bool PerformHold()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TryOpenCloseAgain()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool DisabledInCurrentState()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsOpen()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Open(bool isImmediate)
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "OpenSafe")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SafeCracking), Member = "OnOpen")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(Transmitter), Member = "UpdateRuntimeState")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Open(bool isImmediate, bool fromLink)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Close(bool isImmediate)
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "CloseSafe")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenCloseTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(Transmitter), Member = "UpdateRuntimeState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(TimelinePlayback), Member = "PlayTimelineOnSelf")]
	[Calls(Type = typeof(OpenClose), Member = "Close")]
	[Calls(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Close(bool isImmediate, bool fromLink)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void AnimateOpen(bool isOpen)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public void OnStateDone()
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool PlayAnimInReverse()
	{
		return false;
	}

	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "AnimateOpen")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnStateDone")]
	[CalledBy(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetCollisionEnabled(bool enabled)
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CalledBy(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetAnimationSpeed(float value)
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_carving")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_shape")]
	[Calls(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 12)]
	private void MaybeCreateNavMeshObstacle()
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeCreateNavMeshObstacle")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectAnim), Member = "IsAnimating")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateNavmeshObstacleState()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void PlayAnimationsImmediate(bool open)
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnTimelineOpenEnd")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnTimelineCloseEnd")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(OpenClose), Member = "SetAnimationSpeed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(OpenClose), Member = "SetCollisionEnabled")]
	[Calls(Type = typeof(OpenClose), Member = "PlayAnimInReverse")]
	[Calls(Type = typeof(ObjectAnim), Member = "Play")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void PlayAnimations(bool open, bool isImmediate)
	{
	}

	[CalledBy(Type = typeof(OpenClose), Member = "OnTimelineOpenStart")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnTimelineCloseStart")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnTimelineOpenEnd")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnTimelineCloseEnd")]
	[CalledBy(Type = typeof(OpenClose), Member = "OnTimelineEnd")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ToggleRenderers(bool show)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "ToggleRenderers")]
	private void OnTimelineOpenStart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "ToggleRenderers")]
	private void OnTimelineCloseStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "ToggleRenderers")]
	[Calls(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	private void OnTimelineOpenEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "ToggleRenderers")]
	[Calls(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	private void OnTimelineCloseEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OpenClose), Member = "ToggleRenderers")]
	private void OnTimelineEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public OpenClose()
	{
	}
}
