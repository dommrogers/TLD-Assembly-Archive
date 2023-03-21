using System;
using Cpp2ILInjected.CallAnalysis;

public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_GetSizeOf")]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkObstructionOcclusionValuesArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkObstructionOcclusionValues), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkObstructionOcclusionValues_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other)
	{
	}
}
