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
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UIButton), Member = "SetSprite")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Shader shader
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Texture mainTexture
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
	}

	public override bool premultipliedAlpha
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[CallsUnknownMethods(Count = 2)]
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
		[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsUnknownMethods(Count = 14)]
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
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Vector4), Member = "op_Inequality")]
		set
		{
		}
	}

	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRectOffset")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_hasBorder")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 2)]
	public override void MakePixelPerfect()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(OnPostFillCallback), Member = "Invoke")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public UI2DSprite()
	{
	}
}
