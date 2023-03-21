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

	public static float Strength
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public static event Action<bool> m_IsFullyActiveChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	public static event Action<float> m_NormalizedActiveChanged
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	public static event Action<float> m_StrengthChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private static void UpdateValueAndStrength()
	{
	}
}
