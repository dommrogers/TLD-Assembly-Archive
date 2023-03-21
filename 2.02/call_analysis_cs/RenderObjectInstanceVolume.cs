using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderObjectInstanceVolume : MonoBehaviour
{
	public float m_TriggerDistance;

	public float m_Lod2Distance;

	public float m_CullDistance;

	private Vector3 m_CachedPosition;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RenderObjectInstanceVolume()
	{
	}
}
