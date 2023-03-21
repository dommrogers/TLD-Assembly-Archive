using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
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
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(PerBatch), Member = "Dispose")]
		public void Allocate(int batchCount, bool isUsingProceduralInstancing)
		{
		}

		[CallsUnknownMethods(Count = 37)]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[CalledBy(Type = typeof(PerBatch), Member = "Allocate")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		public void Dispose()
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CallsUnknownMethods(Count = 9)]
		public int Initialize(List<int> objectCounts)
		{
			return default(int);
		}

		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "InitializeJob")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "ScheduleJobs")]
		[CallsUnknownMethods(Count = 10)]
		public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int batchIndex, int batchCount)
		{
			return default(RenderObjectInstanceJob);
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
		[Calls(Type = typeof(Material), Member = "set_enableInstancing")]
		[Calls(Type = typeof(Material), Member = "EnableKeyword")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 1)]
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

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 9)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
		[CallsUnknownMethods(Count = 10)]
		public void AddRenderer(Renderer renderer, PerBatch batches, int batchIndex)
		{
		}

		[CallsUnknownMethods(Count = 14)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Allocate")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		[Calls(Type = typeof(PerObject), Member = "Dispose")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor")]
		public void Allocate(int objectCount)
		{
		}

		[Calls(Type = typeof(ComputeBuffer), Member = "Dispose")]
		[CallsUnknownMethods(Count = 18)]
		[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "Dispose")]
		[CalledBy(Type = typeof(RenderObjectInstance), Member = "Cleanup")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
		[CalledBy(Type = typeof(PerObject), Member = "Allocate")]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 3)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(PerObject), Member = "AddRenderer")]
	[Calls(Type = typeof(PerBatch), Member = "SetRenderInfo")]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "MaybeGetMeshForInstancedRendering")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "PopulateBatchList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	public bool AddObject(Renderer renderer, int lod, bool forceOnlyLod0Shadows)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PerBatch), Member = "Initialize")]
	[Calls(Type = typeof(PerBatch), Member = "Allocate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerObject), Member = "Allocate")]
	public void Allocate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerObject), Member = "Dispose")]
	[Calls(Type = typeof(PerBatch), Member = "Dispose")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Setup")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "Initialize")]
	[CallsUnknownMethods(Count = 17)]
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

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "GetDebugText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	public void GetDebugText(StringBuilder sb)
	{
	}

	[Calls(Type = typeof(PerObject), Member = "InitializeJob")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerBatch), Member = "InitializeJob")]
	public RenderObjectInstanceJob InitializeJob(RenderObjectInstanceJob job, int batchIndex, int batchCount)
	{
		return default(RenderObjectInstanceJob);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "LateUpdate")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstanced")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshInstancedProcedural")]
	public void RenderBatch(int batchIndex, MaterialPropertyBlock materialProperties)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstanceBatches), Member = "GetBatchIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 3)]
	public void ReserveBatchName(string name, int objectCount)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetDebugCounters()
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "ReserveBatchName")]
	[CalledBy(Type = typeof(RenderObjectInstanceBatches), Member = "AddObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int GetBatchIndex(string name)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool IsAllocated()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "CreateBatchList")]
	[CallsUnknownMethods(Count = 13)]
	public RenderObjectInstanceBatches()
	{
	}
}
