using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheet
{
	private MaterialPropertyBlock _003Cproperties_003Ek__BackingField;

	private Material _003Cmaterial_003Ek__BackingField;

	public MaterialPropertyBlock properties
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 92)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 283)]
		private set
		{
		}
	}

	internal Material material
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal PropertySheet(Material material)
	{
	}

	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ClearKeywords()
	{
	}

	[CallerCount(Count = 42)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableKeyword(string keyword)
	{
	}

	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_FisheyeRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_FisheyeRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLProUltimateVignetteRenderer), Member = "Render")]
	[CallerCount(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableKeyword(string keyword)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal void Release()
	{
	}
}
