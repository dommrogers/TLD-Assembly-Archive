using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ClothLOD : MonoBehaviour
{
	public bool m_ForceAlwaysEnabled;

	public float m_Distance;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ClothLOD()
	{
	}
}
