using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CanOpeningItem : MonoBehaviour
{
	public enum CanOpeningType
	{
		CanOpener,
		Knife,
		Hatchet,
		KnifeImprovised,
		HatchetImprovised
	}

	public CanOpeningType m_Type;

	public string m_CanOpeningAudio;

	public float m_CanOpeningLengthSeconds;

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public CanOpeningItem()
	{
	}
}
