using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class VistaLocationData
{
	public string m_Guid;

	public string m_MapRevealMaskPath;

	public Vector4 m_MaskOffsets;

	public float m_Time;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public VistaLocationData()
	{
	}
}
