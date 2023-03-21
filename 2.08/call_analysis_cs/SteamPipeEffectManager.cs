using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SteamPipeEffectManager : MonoBehaviour
{
	private List<SteamPipeEffect> m_Effects;

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Add(SteamPipeEffect effect)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(SteamPipeEffect effect)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamPipeEffect), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public SteamPipeEffectManager()
	{
	}
}
