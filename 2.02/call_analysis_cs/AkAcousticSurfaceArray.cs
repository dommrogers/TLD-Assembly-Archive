using System;
using Cpp2ILInjected.CallAnalysis;

public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_GetSizeOf")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBaseArray<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkAcousticSurfaceArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(0);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkAcousticSurface), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clone")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other)
	{
	}
}
