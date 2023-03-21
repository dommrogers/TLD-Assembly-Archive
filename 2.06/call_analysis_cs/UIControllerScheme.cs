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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UIControllerScheme), Member = "SetActiveChildren")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "Start")]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 7)]
	private void SetActiveChildren(bool enabled)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIControllerScheme), Member = "SetActiveChildren")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UIControllerScheme()
	{
	}
}
