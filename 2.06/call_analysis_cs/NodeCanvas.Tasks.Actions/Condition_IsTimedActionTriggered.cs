using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Condition_IsTimedActionTriggered : ConditionTask
{
	private PanelReference<Panel_HUD> m_HUD;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsTimedActionTriggered()
	{
	}
}
