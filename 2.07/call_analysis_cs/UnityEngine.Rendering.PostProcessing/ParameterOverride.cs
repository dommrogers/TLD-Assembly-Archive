using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class ParameterOverride
{
	public bool overrideState;

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract int GetHash();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public T GetValue<T>()
	{
		return (T)null;
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

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ParameterOverride()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ParameterOverride(T value)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Override(T x)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(T valueA, T valueB)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override int GetHash()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static implicit operator T(ParameterOverride<T> prop)
	{
		return (T)null;
	}
}
