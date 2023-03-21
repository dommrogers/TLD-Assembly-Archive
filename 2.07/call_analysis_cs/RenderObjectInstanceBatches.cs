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

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PerBatch), Member = "Dispose")]
		[CallsUnknownMethods(Count = 5)]
		public void Allocate(int batchCount, bool isUsingProceduralInstancing)
		{
		}

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[CalledBy(Type = typeof(PerBatch), Member = "Allocate")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public void Dispose()
		{
		}

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 6)]
		public int Initialize(List<int> objectCounts)
		{
			return 0;
		}

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 10)]
		public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int batchIndex, int batchCount)
		{
			return default(RenderObjectInstanceJob);
		}

		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Material), Member = "EnableKeyword")]
		[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
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

		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 10)]
		public void AddRenderer(Renderer renderer, PerBatch batches, int batchIndex)
		{
		}

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PerObject), Member = "Dispose")]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[Calls(Type = typeof(ComputeBuffer), Member = "BeginWrite")]
		[CallsUnknownMethods(Count = 4)]
		public void Allocate(int objectCount)
		{
		}

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[CalledBy(Type = typeof(PerObject), Member = "Allocate")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		[CallsUnknownMethods(Count = 5)]
		public void Dispose()
		{
		}

		[CalledBy(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
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

	private int m_CalculatedRenderBatchCount;

	private PerObject m_Objects;

	private PerBatch m_Batches;

	private int m_DebugObjectCount;

	private int m_DebugVisibleCount;

	private int m_DebugRenderedBatchCount;

	private bool m_IsUsingProceduralInstancing;

	private static readonly int s_InstanceMatricesShaderID;

	private static readonly int s_InstanceInversesShaderID;

	private static readonly int s_VisibleIndexesShaderID;

	public int CalculatedRenderBatchCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	[Calls(Type = typeof(PerBatch), Member = "SetRenderInfo")]
	[Calls(Type = typeof(PerObject), Member = "AddRenderer")]
	public bool AddObject(Renderer renderer, int lod, bool forceOnlyLod0Shadows)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerBatch), Member = "Allocate")]
	[Calls(Type = typeof(PerBatch), Member = "Initialize")]
	[Calls(Type = typeof(PerObject), Member = "Allocate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Allocate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerObject), Member = "Dispose")]
	[Calls(Type = typeof(PerBatch), Member = "Dispose")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void FinishInitialization()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetBatchCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public int GetBatchLodMask(int batchIndex)
	{
		return 0;
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "GetDebugText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 3)]
	public void GetDebugText(StringBuilder sb)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerBatch), Member = "InitializeJob")]
	[Calls(Type = typeof(PerObject), Member = "InitializeJob")]
	[CallsUnknownMethods(Count = 1)]
	public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int batchIndex, int batchCount)
	{
		return default(RenderObjectInstanceJob);
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstanced")]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstancedProcedural")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	public void RenderBatch(int batchIndex, MaterialPropertyBlock materialProperties)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public void ReserveBatchName(string name, int objectCount)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetDebugCounters()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "ReserveBatchName")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetBatchIndex(string name)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsAllocated()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RenderObjectInstanceBatches()
	{
	}
}
