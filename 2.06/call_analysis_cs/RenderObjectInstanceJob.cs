using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

public struct RenderObjectInstanceJob : IJob
{
	public float4 m_CameraPosition;

	public float4 m_ViewDirection;

	public float m_Lod1Near;

	public float m_Lod1Far;

	public float m_Lod2Near;

	public float m_Lod2Far;

	public float m_CullFar;

	public bool m_NoLod0Cull;

	public bool m_UseCameraFrustum;

	public int m_JobLightPlanesCount;

	public NativeSlice<Plane> m_JobCameraPlanes;

	public NativeSlice<Plane> m_JobLightPlanes;

	public NativeSlice<int> m_BatchObjectCounts;

	public NativeSlice<int> m_BatchStartIndexes;

	public NativeSlice<int> m_BatchLodMasks;

	public NativeSlice<bool> m_BatchCastsShadows;

	public NativeSlice<int> m_BatchVisibleCounts;

	public NativeSlice<float4> m_ObjectPositions;

	public NativeSlice<Bounds> m_ObjectBounds;

	public NativeSlice<int> m_ObjectVisibleIndexes;

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(IJobExtensions.JobStruct<>), Member = "Execute")]
	[Calls(Type = typeof(RenderObjectInstanceJob), Member = "IndexOOB")]
	[Calls(Type = typeof(JobVisUtils), Member = "FrustrumDotJob")]
	[Calls(Type = typeof(JobVisUtils), Member = "TestPlanesAABBInternal")]
	[Calls(Type = typeof(RenderObjectInstanceJob), Member = "IndexOOB")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobVisUtils), Member = "TestPlanesAABBInternal")]
	[CallsDeduplicatedMethods(Count = 6)]
	public void Execute()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstanceJob), Member = "Execute")]
	[CalledBy(Type = typeof(RenderObjectInstanceJob), Member = "Execute")]
	private bool IndexOOB(int arraySize, int index)
	{
		return default(bool);
	}
}
