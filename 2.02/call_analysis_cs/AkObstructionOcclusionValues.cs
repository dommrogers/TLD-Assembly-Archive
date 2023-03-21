using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkObstructionOcclusionValues : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public float occlusion
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float obstruction
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkObstructionOcclusionValues(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkObstructionOcclusionValuesArray), Member = "CloneIntoReferenceFromIntPtr")]
	internal static IntPtr getCPtr(AkObstructionOcclusionValues obj)
	{
		return default(IntPtr);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkObstructionOcclusionValues()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_Clear")]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_GetSizeOf")]
	[CallerCount(Count = 0)]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_Clone")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Clone(AkObstructionOcclusionValues other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkObstructionOcclusionValues()
	{
	}
}
