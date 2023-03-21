using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;

public class RadioTower : TimedHoldInteraction
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_ProgressDisplayName;

	public string m_InteractAudio;

	private bool m_IsBeingInteractedWith;

	private float m_InteractTimer;

	private PlayerControlMode m_RestoreControlMode;

	private uint m_InteractAudioID;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "BeginHold")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	protected override void BeginHold()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void CancelHold()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	private void PlayAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void StopAudio()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public RadioTower()
	{
	}
}
