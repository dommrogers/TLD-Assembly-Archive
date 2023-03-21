using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Electrostatic;

public static class ElectrostaticForce
{
	private const float FULLY_ACTIVE_THRESHOLD = 0.95f;

	private static bool _003CIsActive_003Ek__BackingField;

	private static bool _003CIsFullyActive_003Ek__BackingField;

	private static float _003CNormalizedActive_003Ek__BackingField;

	private static float _003CStrength_003Ek__BackingField;

	private static List<IElectrostaticSource> m_Sources;

	public static bool IsActive
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static bool IsFullyActive
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static float NormalizedActive
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static float Strength
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static event Action<bool> m_IsActiveChanged
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<bool> m_IsFullyActiveChanged
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<float> m_NormalizedActiveChanged
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<float> m_StrengthChanged
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Add(IElectrostaticSource source)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(IElectrostaticSource source)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Evaluate()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private static void UpdateValueAndStrength()
	{
	}
}
