using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIControllerScheme : MonoBehaviour
{
	public enum ControlScheme
	{
		Controller,
		Mouse
	}

	public ControlScheme m_ControlScheme;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UIControllerScheme), Member = "SetActiveChildren")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "Start")]
	private void SetActiveChildren(bool enabled)
	{
	}

	[Calls(Type = typeof(UIControllerScheme), Member = "SetActiveChildren")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIControllerScheme()
	{
	}
}
