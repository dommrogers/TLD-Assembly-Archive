using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessBundle
{
	private PostProcessAttribute _003Cattribute_003Ek__BackingField;

	private PostProcessEffectSettings _003Csettings_003Ek__BackingField;

	private PostProcessEffectRenderer m_Renderer;

	public PostProcessAttribute attribute
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
		[CallerCount(Count = 281)]
		private set
		{
		}
	}

	public PostProcessEffectSettings settings
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

	internal PostProcessEffectRenderer renderer
	{
		[CalledBy(Type = typeof(PostProcessBundle), Member = "CastRenderer")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal PostProcessBundle(PostProcessEffectSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void ResetHistory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal T CastSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	[CallsUnknownMethods(Count = 3)]
	internal T CastRenderer<T>() where T : PostProcessEffectRenderer
	{
		return null;
	}
}
