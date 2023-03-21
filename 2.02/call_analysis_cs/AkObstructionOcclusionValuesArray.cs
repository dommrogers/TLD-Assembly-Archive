using System;
using Cpp2ILInjected.CallAnalysis;

public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_GetSizeOf")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBaseArray<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkObstructionOcclusionValuesArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(0);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkObstructionOcclusionValues), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_Clone")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other)
	{
	}
}
