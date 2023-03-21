using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Sharpenable : MonoBehaviour
{
	public GearItem[] m_RequiredGear;

	public int[] m_RequiredGearUnits;

	public float m_ConditionIncreaseMin;

	public float m_ConditionIncreaseMax;

	public int m_DurationMinutesMin;

	public int m_DurationMinutesMax;

	public string m_SharpenAudio;

	public ToolsItem[] m_SharpenToolChoices;

	public bool m_RequiresToolToSharpen;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sharpenable()
	{
	}
}
