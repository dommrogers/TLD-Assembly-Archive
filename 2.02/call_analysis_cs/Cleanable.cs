using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Cleanable : MonoBehaviour
{
	public GearItem[] m_RequiredGear;

	public int[] m_RequiredGearUnits;

	public float m_ConditionIncreaseMin;

	public float m_ConditionIncreaseMax;

	public int m_DurationMinutesMin;

	public int m_DurationMinutesMax;

	public string m_CleanAudio;

	public ToolsItem[] m_CleanToolChoices;

	public bool m_RequiresToolToClean;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Cleanable()
	{
	}
}
