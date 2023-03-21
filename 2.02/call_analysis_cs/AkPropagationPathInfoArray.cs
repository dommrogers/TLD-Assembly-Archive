using System;
using Cpp2ILInjected.CallAnalysis;

public class AkPropagationPathInfoArray : AkBaseArray<AkPropagationPathInfo>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkPropagationPathInfo_GetSizeOf")]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkPropagationPathInfoArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkPropagationPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkPropagationPathInfo_Clone")]
	[Calls(Type = typeof(AkPropagationPathInfo), Member = "getCPtr")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkPropagationPathInfo other)
	{
	}
}
