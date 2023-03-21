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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UIButton), Member = "SetSprite")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
		set
		{
		}
	}

	public override Material material
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		set
		{
		}
	}

	public override Shader shader
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Shader), Member = "Find")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	public override Texture mainTexture
	{
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public override bool premultipliedAlpha
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	[Calls(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	protected override void OnUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_hasBorder")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public override void MakePixelPerfect()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UI2DSprite()
	{
	}
}
