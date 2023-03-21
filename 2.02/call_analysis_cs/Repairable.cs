using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Repairable : MonoBehaviour
{
	public GearItem[] m_RequiredGear;

	public int[] m_RequiredGearUnits;

	public float m_ConditionIncrease;

	public float m_RepairConditionCap;

	public int m_DurationMinutes;

	public string m_RepairAudio;

	public ToolsItem[] m_RepairToolChoices;

	public bool m_RequiresToolToRepair;

	public bool m_NeverFail;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Repairable), Member = "AddAlternateTools")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Repairable), Member = "Start")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Repairable()
	{
	}
}
