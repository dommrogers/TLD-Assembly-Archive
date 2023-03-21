using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEnvironment : MonoBehaviour
{
	public class AkEnvironment_CompareByPriority : IComparer<AkEnvironment>
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(AkEnvironment_CompareBySelectionAlgorithm), Member = "Compare")]
		public virtual int Compare(AkEnvironment a, AkEnvironment b)
		{
			return default(int);
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public AkEnvironment_CompareByPriority()
		{
		}
	}

	public class AkEnvironment_CompareBySelectionAlgorithm : AkEnvironment_CompareByPriority
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkEnvironment_CompareByPriority), Member = "Compare")]
		[CallsUnknownMethods(Count = 1)]
		public override int Compare(AkEnvironment a, AkEnvironment b)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public AkEnvironment_CompareBySelectionAlgorithm()
		{
		}
	}

	public const int MAX_NB_ENVIRONMENTS = 4;

	public static AkEnvironment_CompareByPriority s_compareByPriority;

	public static AkEnvironment_CompareBySelectionAlgorithm s_compareBySelectionAlgorithm;

	public bool excludeOthers;

	public bool isDefault;

	public AuxBus data;

	private Collider _003CCollider_003Ek__BackingField;

	public int priority;

	private int auxBusIdInternal;

	private byte[] valueGuidInternal;

	public Collider Collider
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 20)]
		private set
		{
		}
	}

	public int m_auxBusID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public byte[] valueGuid
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetAuxSendValueForPosition(Vector3 in_position)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Obsolete]
	public uint GetAuxBusID()
	{
		return default(uint);
	}

	[Obsolete]
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Collider GetCollider()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AkEnvironment()
	{
	}
}
