using System;
using Cpp2ILInjected.CallAnalysis;

public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkReflectionPathInfo_GetSizeOf")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBaseArray<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkReflectionPathInfoArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(0);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkReflectionPathInfo), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkReflectionPathInfo_Clone")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other)
	{
	}
}
