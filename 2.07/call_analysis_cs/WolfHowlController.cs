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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[CallsUnknownMethods(Count = 2)]
	public void Add(BaseAi wolf)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(BaseAiManager), Member = "Remove")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Destroy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(BaseAi wolf)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RequestHowl(BaseAi wolf, bool isLead)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateCurrentHowl")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void DebugLog(string message)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[CalledBy(Type = typeof(WolfHowlController), Member = "RequestHowl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	private void StartLeadHowl(BaseAi wolf)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	private float StartResponseHowl(BaseAi wolf, float baseTime)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(WolfHowlController), Member = "Add")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Add")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetNextTimer()
	{
	}

	[CalledBy(Type = typeof(WolfHowlController), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateCurrentHowl()
	{
	}

	[CalledBy(Type = typeof(WolfHowlController), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 14)]
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
