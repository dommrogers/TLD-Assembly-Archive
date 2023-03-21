using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UITexture : UIBasicSprite
{
	private Rect mRect;

	private Texture mTexture;

	private Material mMat;

	private Shader mShader;

	private Vector4 mBorder;

	private bool mFixedAspect;

	[NonSerialized]
	private int mPMA;

	public override Texture mainTexture
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIDrawCall), Member = "set_mainTexture")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		set
		{
		}
	}

	public override Material material
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Shader shader
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Shader), Member = "Find")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override bool premultipliedAlpha
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Contains")]
		get
		{
			return default(bool);
		}
	}

	public override Vector4 border
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Rect uvRect
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Rect);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override Vector4 drawingDimensions
	{
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return default(Vector4);
		}
	}

	public bool fixedAspect
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_hasBorder")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UITexture()
	{
	}
}
