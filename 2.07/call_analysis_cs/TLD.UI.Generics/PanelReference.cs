using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI.Generics;

[Serializable]
public struct PanelReference<T> where T : Panel_Base
{
	private PanelReference m_PanelReference;

	[DeduplicatedMethod]
	[CallerCount(Count = 64)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	public T GetPanel()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 828)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetPanel(out T panel)
	{
		panel = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 173)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void TrySetEnabled(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InitializeReference()
	{
	}
}
