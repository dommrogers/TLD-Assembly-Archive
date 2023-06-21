using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCStatusBar : StatusBar
{
	private NPC m_NPCComponent;

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public void AttachNPC(NPC npc)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool ShouldBeHidden()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void GetFillValuesThirst(out float normalizedValue, out float fill, out float modifierFill)
	{
		normalizedValue = default(float);
		fill = default(float);
		modifierFill = default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void GetFillValuesHunger(out float normalizedValue, out float fill, out float modifierFill)
	{
		normalizedValue = default(float);
		fill = default(float);
		modifierFill = default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void GetFillValuesCold(out float normalizedValue, out float fill, out float modifierFill)
	{
		normalizedValue = default(float);
		fill = default(float);
		modifierFill = default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void GetFillValuesFatigue(out float normalizedValue, out float fill, out float modifierFill)
	{
		normalizedValue = default(float);
		fill = default(float);
		modifierFill = default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCCondition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 1)]
	protected override void GetFillValuesCondition(out float normalizedValue, out float fill, out float modifierFill)
	{
		normalizedValue = default(float);
		fill = default(float);
		modifierFill = default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	protected override float GetRateOfChangeThirst()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override float GetRateOfChangeHunger()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 1)]
	protected override float GetRateOfChangeCold()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override float GetRateOfChangeFatigue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override bool IsBuffActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool IsDebuffActive()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCStatusBar()
	{
	}
}
