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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetPanel(out T panel)
	{
		panel = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 173)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void TrySetEnabled(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InitializeReference()
	{
	}
}
