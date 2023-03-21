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

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PerBatch), Member = "Dispose")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallsUnknownMethods(Count = 5)]
		public void Allocate(int batchCount, bool isUsingProceduralInstancing)
		{
		}

		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[CalledBy(Type = typeof(PerBatch), Member = "Allocate")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		public void Dispose()
		{
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallsUnknownMethods(Count = 6)]
		public int Initialize(List<int> objectCounts)
		{
			return default(int);
		}

		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
		[CallsUnknownMethods(Count = 10)]
		public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int batchIndex, int batchCount)
		{
			return default(RenderObjectInstanceJob);
		}

		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
		[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
		[CallsUnknownMethods(Count = 6)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Material), Member = "EnableKeyword")]
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
		[CallsUnknownMethods(Count = 10)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 9)]
		public void AddRenderer(Renderer renderer, PerBatch batches, int batchIndex)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(PerObject), Member = "Dispose")]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallsUnknownMethods(Count = 4)]
		public void Allocate(int objectCount)
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[CalledBy(Type = typeof(PerObject), Member = "Allocate")]
		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		public void Dispose()
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	[Calls(Type = typeof(PerBatch), Member = "SetRenderInfo")]
	[Calls(Type = typeof(PerObject), Member = "AddRenderer")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	public bool AddObject(Renderer renderer, int lod, bool forceOnlyLod0Shadows)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PerBatch), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PerObject), Member = "Allocate")]
	[Calls(Type = typeof(PerBatch), Member = "Allocate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
		return default(int);
	}

	[CallerCount(Count = 0)]
	public int GetBatchLodMask(int batchIndex)
	{
		return default(int);
	}

	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "GetDebugText")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
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

	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstancedProcedural")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "LateUpdate")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstanced")]
	public void RenderBatch(int batchIndex, MaterialPropertyBlock materialProperties)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 4)]
	public void ReserveBatchName(string name, int objectCount)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetDebugCounters()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "ReserveBatchName")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RenderObjectInstanceBatches()
	{
	}
}
