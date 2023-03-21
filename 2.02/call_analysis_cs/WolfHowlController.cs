using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WolfHowlController : MonoBehaviour
{
	private const int INVALID_HOWL_ID = -1;

	private const int FIRST_HOWL_ID = 1;

	public uint m_MinimumNumberOfWolves;

	public float m_MinimumPlayerDistance;

	public float m_MaxiumumPlayerDistance;

	public int m_HowlMinimumDelay;

	public int m_HowlMaximumDelay;

	public int m_MaximumNumberOfResponses;

	private bool m_Debug;

	private BaseAi m_LastHowler;

	private List<BaseAi> m_RespondersList;

	private List<BaseAi> m_Wolves;

	private int m_CurrentHowl;

	private int m_NextHowl;

	private float m_NextHowlTimer;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Add(BaseAi wolf)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ForceNextHowl()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetDebugTimerText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetDebugWolfListTest()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Remove")]
	public void Remove(BaseAi wolf)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartResponseHowl")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RequestHowl(BaseAi wolf, bool isLead)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateCurrentHowl")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update()
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void DebugLog(string message)
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[CalledBy(Type = typeof(WolfHowlController), Member = "RequestHowl")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	private void StartLeadHowl(BaseAi wolf)
	{
	}

	[CalledBy(Type = typeof(WolfHowlController), Member = "RequestHowl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	private float StartResponseHowl(BaseAi wolf, float baseTime)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WolfHowlController), Member = "Add")]
	[CalledBy(Type = typeof(WolfHowlController), Member = "UpdateCurrentHowl")]
	[CalledBy(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	private void SetNextTimer()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(WolfHowlController), Member = "Update")]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateCurrentHowl()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(WolfHowlController), Member = "Update")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void UpdateTimer()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WolfHowlController()
	{
	}
}
