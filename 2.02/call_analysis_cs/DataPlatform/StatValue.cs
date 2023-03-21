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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
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
			return 0.0;
		}
	}

	public long AsInteger
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0L;
		}
	}

	public string AsString
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public StatDataType DataType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatValue), Member = "DisposeImpl")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(StatValue), Member = "Finalize")]
	[CalledBy(Type = typeof(StatValue), Member = "Dispose")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeImpl()
	{
	}
}
