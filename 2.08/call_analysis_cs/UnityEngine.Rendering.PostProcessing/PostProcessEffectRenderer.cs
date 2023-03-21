using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class PostProcessEffectRenderer
{
	protected bool m_ResetHistory;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Init()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void ResetHistory()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Release()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected PostProcessEffectRenderer()
	{
	}
}
public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
{
	private T _003Csettings_003Ek__BackingField;

	public T settings
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 79)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal override void SetSettings(PostProcessEffectSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected PostProcessEffectRenderer()
	{
	}
}
