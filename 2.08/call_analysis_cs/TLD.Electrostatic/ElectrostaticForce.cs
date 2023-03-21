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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
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
			return default(bool);
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
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static float Strength
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(float);
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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		remove
		{
		}
	}

	public static event Action<bool> m_IsFullyActiveChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<float> m_NormalizedActiveChanged
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<float> m_StrengthChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnEnable")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(ElectrostaticEventListener), Member = "OnDisable")]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(IElectrostaticSource source)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Evaluate()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private static void UpdateValueAndStrength()
	{
	}
}
