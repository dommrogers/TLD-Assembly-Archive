using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderObjectInstanceVolume : MonoBehaviour
{
	public float m_TriggerDistance;

	public float m_Lod2Distance;

	public float m_CullDistance;

	private Vector3 m_CachedPosition;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Vector3 GetCachedPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public RenderObjectInstanceVolume()
	{
	}
}
