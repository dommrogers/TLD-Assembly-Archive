using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MarkupPointGenerator : MonoBehaviour
{
	public float m_Radius;

	public float m_PlacementDistance;

	public float m_PlacementCeiling;

	public float m_MarkupPointRadius;

	public int m_MinMarkupLinks;

	public AreaMarkupType m_AreaMarkupType;

	public bool m_TriggeredHasMarkupPointsWarning;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MarkupPointGenerator()
	{
	}
}
