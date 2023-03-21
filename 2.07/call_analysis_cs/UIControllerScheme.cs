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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "Start")]
	[CalledBy(Type = typeof(UIControllerScheme), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
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
	[CallerCount(Count = 0)]
	public UIControllerScheme()
	{
	}
}
