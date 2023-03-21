using System;
using Cpp2ILInjected.CallAnalysis;

public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_GetSizeOf")]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkAcousticSurfaceArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkAcousticSurface), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAcousticSurface_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other)
	{
	}
}
