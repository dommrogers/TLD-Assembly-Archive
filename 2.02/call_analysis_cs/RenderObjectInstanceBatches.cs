using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class RenderObjectInstanceBatches
{
	private struct PerBatch
	{
		public struct RenderInfo
		{
			public Mesh m_Mesh;

			public Material[] m_Materials;

			public ShadowCastingMode m_CastShadows;

			public bool m_ReceiveShadows;
		}

		public RenderInfo[] m_RenderInfos;

		public ComputeBuffer[] m_VisiblesIndexes;

		public NativeArray<int> m_StartIndexes;

		public NativeArray<int> m_ObjectCounts;

		public NativeArray<int> m_VisibleCounts;

		public NativeArray<int> m_LodMasks;

		public NativeArray<bool> m_CastShadows;

		private bool m_IsUsingProceduralInstancing;

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PerBatch), Member = "Dispose")]
		public void Allocate(int batchCount, bool isUsingProceduralInstancing)
		{
		}

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 7)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[CalledBy(Type = typeof(PerBatch), Member = "Allocate")]
		[CallsUnknownMethods(Count = 18)]
		public void Dispose()
		{
		}

		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallsUnknownMethods(Count = 13)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		public int Initialize(List<int> objectCounts)
		{
			return default(int);
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 6)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
		[CallsUnknownMethods(Count = 10)]
		public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int batchIndex, int batchCount)
		{
			return default(RenderObjectInstanceJob);
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "EnableKeyword")]
		[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
		[CallsUnknownMethods(Count = 16)]
		public void SetRenderInfo(int batchIndex, Renderer renderer, Mesh mesh, int lod, bool forceOnlyLod0Shadow)
		{
		}
	}

	private struct PerObject
	{
		public ComputeBuffer m_InstancedMatrices;

		public ComputeBuffer m_InstancedInverses;

		public NativeArray<Matrix4x4> m_TemporaryMatrices;

		public NativeArray<Matrix4x4> m_TemporaryInverses;

		public NativeArray<int> m_VisibleIndexes;

		public NativeArray<float4> m_Positions;

		public NativeArray<Bounds> m_Bounds;

		[CallsUnknownMethods(Count = 12)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(Matrix4x4), Member = "get_inverse")]
		public void AddRenderer(Renderer renderer, PerBatch batches, int batchIndex)
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(PerObject), Member = "Dispose")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallsUnknownMethods(Count = 5)]
		public void Allocate(int objectCount)
		{
		}

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[CallsUnknownMethods(Count = 10)]
		[CalledBy(Type = typeof(PerObject), Member = "Allocate")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 3)]
		public void Dispose()
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
		public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int objectIndex, int objectCount)
		{
			return default(RenderObjectInstanceJob);
		}
	}

	public static bool s_DisableProceduralInstancing;

	private const int DRAW_MESH_INSTANCED_LIMIT = 1023;

	private Matrix4x4[] m_RenderTransforms;

	private List<string> m_Names;

	private List<int> m_ObjectCounts;

	private int m_MaxObjectCount;

	private PerObject m_Objects;

	private PerBatch m_Batches;

	private int m_DebugObjectCount;

	private int m_DebugVisibleCount;

	private int m_DebugBatchCount;

	private bool m_IsUsingProceduralInstancing;

	private static readonly int s_InstanceMatricesShaderID;

	private static readonly int s_InstanceInversesShaderID;

	private static readonly int s_VisibleIndexesShaderID;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	[Calls(Type = typeof(PerBatch), Member = "SetRenderInfo")]
	[Calls(Type = typeof(PerObject), Member = "AddRenderer")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "AddLODGroupToBatchList")]
	[CallsUnknownMethods(Count = 1)]
	public bool AddObject(Renderer renderer, int lod, bool forceOnlyLod0Shadows)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[Calls(Type = typeof(PerObject), Member = "Allocate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PerBatch), Member = "Allocate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PerBatch), Member = "Initialize")]
	public void Allocate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerObject), Member = "Dispose")]
	[Calls(Type = typeof(PerBatch), Member = "Dispose")]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void FinishInitialization()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "GetDebugText")]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
	[CallsUnknownMethods(Count = 1)]
	public int GetBatchCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public int GetBatchLodMask(int batchIndex)
	{
		return default(int);
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "GetDebugText")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchCount")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	public void GetDebugText(StringBuilder sb)
	{
	}

	[Calls(Type = typeof(PerObject), Member = "InitializeJob")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
	[Calls(Type = typeof(PerBatch), Member = "InitializeJob")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int batchIndex, int batchCount)
	{
		return default(RenderObjectInstanceJob);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "LateUpdate")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstancedProcedural")]
	[Calls(Type = typeof(ComputeBuffer), Member = "InternalSetNativeData")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstanced")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	public void RenderBatch(int batchIndex, MaterialPropertyBlock materialProperties)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	public void ReserveBatchName(string name, int objectCount)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetDebugCounters()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "ReserveBatchName")]
	[CallsUnknownMethods(Count = 1)]
	private int GetBatchIndex(string name)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsAllocated()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 19)]
	public RenderObjectInstanceBatches()
	{
	}
}
