using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class WolfHowlController : MonoBehaviour
{
	private const int INVALID_HOWL_ID = -1;

	private const int FIRST_HOWL_ID = 1;

	private PanelReference<Panel_Loading> m_Loading;

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

	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Add(BaseAi wolf)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ForceNextHowl()
	{
	}

	[CallerCount(Count = 0)]
	public string GetDebugTimerText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public string GetDebugWolfListTest()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Remove")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(BaseAi wolf)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void RequestHowl(BaseAi wolf, bool isLead)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateCurrentHowl")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update()
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void DebugLog(string message)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[CalledBy(Type = typeof(WolfHowlController), Member = "RequestHowl")]
	[CallsUnknownMethods(Count = 1)]
	private void StartLeadHowl(BaseAi wolf)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	private float StartResponseHowl(BaseAi wolf, float baseTime)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WolfHowlController), Member = "Add")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	private void SetNextTimer()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(WolfHowlController), Member = "Update")]
	private void UpdateCurrentHowl()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(WolfHowlController), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void UpdateTimer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public WolfHowlController()
	{
	}
}
