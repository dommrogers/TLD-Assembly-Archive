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
		[CalledBy(Type = typeof(AkEnvironment_CompareBySelectionAlgorithm), Member = "Compare")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Compare(AkEnvironment a, AkEnvironment b)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
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
			return 0;
		}
	}

	public byte[] valueGuid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(WwiseObjectReference), Member = "get_Guid")]
		[Calls(Type = typeof(Guid), Member = "ToByteArray")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[Obsolete]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetAuxBusID()
	{
		return 0u;
	}

	[Obsolete]
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Collider GetCollider()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkEnvironment()
	{
	}
}
