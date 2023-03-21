using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class ParameterOverride
{
	public bool overrideState;

	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	public abstract int GetHash();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public T GetValue<T>()
	{
		return default(T);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected internal virtual void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected internal virtual void OnDisable()
	{
	}

	internal abstract void SetValue(ParameterOverride parameter);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected ParameterOverride()
	{
	}
}
[Serializable]
public class ParameterOverride<T> : ParameterOverride
{
	public T value;

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 33)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ParameterOverride()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ParameterOverride(T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ParameterOverride(T value, bool overrideState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal override void Interp(ParameterOverride from, ParameterOverride to, float t)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Interp(T from, T to, float t)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CameraEffects), Member = "UpdateEffectParameters")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = "ApplySettings")]
	[CalledBy(Type = typeof(ColorGrading), Member = "UpdateLutForTimeOfDay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Override(T x)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(T valueA, T valueB)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override int GetHash()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator T(ParameterOverride<T> prop)
	{
		return default(T);
	}
}
