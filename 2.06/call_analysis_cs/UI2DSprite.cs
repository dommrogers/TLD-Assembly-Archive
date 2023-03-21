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
		[CalledBy(Type = typeof(UIButton), Member = "SetSprite")]
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override Shader shader
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Shader), Member = "Find")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override Texture mainTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public override bool premultipliedAlpha
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public override float pixelSize
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public override Vector4 drawingDimensions
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_hasBorder")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	public UI2DSprite()
	{
	}
}
