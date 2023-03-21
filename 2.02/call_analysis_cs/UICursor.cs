using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICursor : MonoBehaviour
{
	public static UICursor instance;

	public Camera uiCamera;

	private Transform mTrans;

	private UISprite mSprite;

	private UIAtlas mAtlas;

	private string mSpriteName;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UICursor), Member = "Set")]
	[CallsUnknownMethods(Count = 21)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Clear()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UICursor), Member = "Update")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	public static void Set(UIAtlas atlas, string sprite)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UICursor()
	{
	}
}
