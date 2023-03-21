using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class ParameterOverride
{
	public bool overrideState;

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ParameterOverride()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Interp(T from, T to, float t)
	{
	}

	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Override(T x)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual bool Equals(T valueA, T valueB)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
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
