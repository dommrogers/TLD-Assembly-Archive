using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

internal struct ElectrolizerParallelJob : IJobParallelFor
{
	public NativeArray<float4> m_PosArr;

	public float4 m_CamPos;

	public NativeArray<float> m_MaxDistSqr;

	public NativeArray<float> m_DistSqr;

	public NativeArray<byte> m_EnabledArr;

	[CalledBy(TypeFullName = "Unity.Jobs.IJobParallelForExtensions.ParallelForJobStruct`1", Member = "Execute")]
	[CallerCount(Count = 1)]
	public void Execute(int i)
	{
	}
}
