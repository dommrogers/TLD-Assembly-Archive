using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkTriangle : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public ushort point0
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(ushort);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ushort point1
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(ushort);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ushort point2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(ushort);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ushort surface
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(ushort);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkTriangle(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkTriangleArray), Member = "CloneIntoReferenceFromIntPtr")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkTriangle obj)
	{
		return default(IntPtr);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkTriangle()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public virtual void Dispose()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AkTriangle()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public AkTriangle(ushort in_pt0, ushort in_pt1, ushort in_pt2, ushort in_surfaceInfo)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkTriangle_Clear")]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkTriangle_GetSizeOf")]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkTriangle_Clone")]
	public void Clone(AkTriangle other)
	{
	}
}
