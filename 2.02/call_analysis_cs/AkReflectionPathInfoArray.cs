using System;
using Cpp2ILInjected.CallAnalysis;

public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo>
{
	protected override int StructureSize
	{
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkReflectionPathInfo_GetSizeOf")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkReflectionPathInfoArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkReflectionPathInfo), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkReflectionPathInfo_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other)
	{
	}
}
