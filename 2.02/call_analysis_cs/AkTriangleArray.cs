using System;
using Cpp2ILInjected.CallAnalysis;

public class AkTriangleArray : AkBaseArray<AkTriangle>
{
	protected override int StructureSize
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkTriangle_GetSizeOf")]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkTriangleArray(int count)
	{
		((AkBaseArray<>)(object)this)._002Ector(default(int));
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkTriangle_Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkTriangle), Member = "getCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkTriangle_Clone")]
	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other)
	{
	}
}
