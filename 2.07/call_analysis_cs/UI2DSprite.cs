using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UI2DSprite : UIBasicSprite
{
	private Sprite mSprite;

	private Material mMat;

	private Shader mShader;

	private Vector4 mBorder;

	private bool mFixedAspect;

	private float mPixelSize;

	public Sprite nextSprite;

	[NonSerialized]
	private int mPMA;

	public Sprite sprite2D
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
		[CalledBy(Type = typeof(UIButton), Member = "SetSprite")]
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public override Shader shader
	{
		[Calls(Type = typeof(Shader), Member = "Find")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Texture mainTexture
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override bool premultipliedAlpha
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Contains")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public override float pixelSize
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public override Vector4 drawingDimensions
	{
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[CallsUnknownMethods(Count = 11)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 6)]
		get
		{
			return default(Vector4);
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

	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	[Calls(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_hasBorder")]
	public override void MakePixelPerfect()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	public UI2DSprite()
	{
	}
}
