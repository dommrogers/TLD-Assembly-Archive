using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace DataPlatform;

public class StatValue : IDisposable, IWrappedObject
{
	private IntPtr m_Self;

	private string m_Name;

	private string m_AsString;

	public string Name
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public double AsNumber
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(double);
		}
	}

	public long AsInteger
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(long);
		}
	}

	public string AsString
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public StatDataType DataType
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(StatDataType);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StatValue(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public StatValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatValue), Member = "DisposeImpl")]
	[CallsUnknownMethods(Count = 1)]
	~StatValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 98)]
	[DeduplicatedMethod]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(StatValue), Member = "DisposeImpl")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(StatValue), Member = "Finalize")]
	[CalledBy(Type = typeof(StatValue), Member = "Dispose")]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
