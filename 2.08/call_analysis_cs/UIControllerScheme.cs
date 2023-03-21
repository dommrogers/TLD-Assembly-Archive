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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
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
