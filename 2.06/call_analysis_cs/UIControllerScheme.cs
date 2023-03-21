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
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UIControllerScheme), Member = "SetActiveChildren")]
	public void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected void OnEnable()
	{
	}

	[CalledBy(Type = typeof(UIControllerScheme), Member = "Start")]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void SetActiveChildren(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UIControllerScheme), Member = "SetActiveChildren")]
	public void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIControllerScheme()
	{
	}
}
