using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraActivatedToggle : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public AuroraActivatedToggleState m_ToggleState;

	public string m_ToggleOnAudio;

	public string m_ToggleOffAudio;

	private bool m_ChildrenDisabled;

	private AuroraField m_ActiveAuroraField;

	public bool m_RequiresAuroraField;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(AuroraActivatedToggle), Member = "DisableChildren")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(AuroraActivatedToggle), Member = "EnableChildren")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraActivatedToggle), Member = "DisableChildren")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 0)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void TurnOn()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void TurnOff()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Update")]
	private void EnableChildren()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Start")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Update")]
	private void DisableChildren()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraActivatedToggle()
	{
	}
}
