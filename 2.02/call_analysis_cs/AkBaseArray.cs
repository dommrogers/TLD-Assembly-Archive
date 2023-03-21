using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

public abstract class AkBaseArray<T> : IDisposable
{
	private int _003CCapacity_003Ek__BackingField;

	private IntPtr m_Buffer;

	public int Capacity
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	protected abstract int StructureSize { get; }

	public T Item
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(T);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(AkPropagationPathInfoArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkAcousticSurfaceArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkDiffractionPathInfoArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkExternalSourceInfoArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkObjectInfoArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkObstructionOcclusionValuesArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkReflectionPathInfoArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkSourceSettingsArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkTriangleArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkVertexArray), Member = ".ctor")]
	[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public AkBaseArray(int capacity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	~AkBaseArray()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int Count()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
	{
	}

	protected abstract T CreateNewReferenceFromIntPtr(IntPtr address);

	protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other);

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public IntPtr GetBuffer()
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	protected IntPtr GetObjectPtr(int index)
	{
		return (IntPtr)0;
	}
}
