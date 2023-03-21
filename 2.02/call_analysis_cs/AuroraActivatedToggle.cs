using System.Collections.Generic;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraActivatedToggle), Member = "DisableChildren")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraActivatedToggle), Member = "EnableChildren")]
	[Calls(Type = typeof(AuroraActivatedToggle), Member = "DisableChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 46)]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void TurnOn()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void TurnOff()
	{
	}

	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void EnableChildren()
	{
	}

	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Start")]
	[CalledBy(Type = typeof(AuroraActivatedToggle), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void DisableChildren()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraActivatedToggle()
	{
	}
}
