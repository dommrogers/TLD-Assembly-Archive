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

	[CalledBy(TypeFullName = "Unity.Jobs.IJobExtensions.JobStruct`1", Member = "Execute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceJob), Member = "IndexOOB")]
	[Calls(Type = typeof(JobVisUtils), Member = "TestPlanesAABBInternal")]
	[Calls(Type = typeof(JobVisUtils), Member = "FrustrumDotJob")]
	[CallsUnknownMethods(Count = 12)]
	public void Execute()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstanceJob), Member = "Execute")]
	[CallerCount(Count = 2)]
	private bool IndexOOB(int arraySize, int index)
	{
		return false;
	}
}
