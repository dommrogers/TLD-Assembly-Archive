using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI.Generics;

[Serializable]
public struct PanelReference<T> where T : Panel_Base
{
	private PanelReference m_PanelReference;

	[DeduplicatedMethod]
	[CallerCount(Count = 63)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	public T GetPanel()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[DeduplicatedMethod]
	[CallerCount(Count = 816)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetPanel(out T panel)
	{
		panel = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 173)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public void TrySetEnabled(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void InitializeReference()
	{
	}
}
