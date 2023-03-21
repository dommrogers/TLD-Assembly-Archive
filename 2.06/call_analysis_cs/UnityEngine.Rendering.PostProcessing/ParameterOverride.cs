using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class ParameterOverride
{
	public bool overrideState;

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract int GetHash();

	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 101224)]
	internal abstract void SetValue(ParameterOverride parameter);

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected ParameterOverride()
	{
	}
}
[Serializable]
public class ParameterOverride<T> : ParameterOverride
{
	public T value;

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 32)]
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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
