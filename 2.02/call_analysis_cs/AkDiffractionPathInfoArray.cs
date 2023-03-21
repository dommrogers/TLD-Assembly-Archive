using System;
using Cpp2ILInjected.CallAnalysis;

public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo>
{
	protected override int StructureSize
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDiffractionPathInfo_GetSizeOf")]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkDiffractionPathInfoArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkDiffractionPathInfo), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDiffractionPathInfo_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other)
	{
	}
}
