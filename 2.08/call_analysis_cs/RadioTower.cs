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

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "BeginHold")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	protected override void BeginHold()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public override void CancelHold()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public RadioTower()
	{
	}
}
