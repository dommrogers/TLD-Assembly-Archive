using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DisplayLocationLabelSaveDataProxy
{
	public Vector3 m_Position;

	public bool m_Logged;

	public bool m_PlayedStinger;

	public float m_CoolDownTimeLeft;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DisplayLocationLabelSaveDataProxy()
	{
	}
}
