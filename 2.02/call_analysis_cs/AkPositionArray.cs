using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkPositionArray : IDisposable
{
	public IntPtr m_Buffer;

	private IntPtr m_Current;

	private uint m_MaxCount;

	private uint _003CCount_003Ek__BackingField;

	public uint Count
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "BuildAkPositionArray")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CalledBy(Type = typeof(AkAmbient), Member = "BuildMultiDirectionArray")]
	public AkPositionArray(uint in_Count)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	~AkPositionArray()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[CalledBy(Type = typeof(AkAmbient), Member = "BuildMultiDirectionArray")]
	[CalledBy(Type = typeof(AkAmbient), Member = "BuildAkPositionArray")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes")]
	[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	public void Add(Vector3 in_Pos, Vector3 in_Forward, Vector3 in_Top)
	{
	}
}
