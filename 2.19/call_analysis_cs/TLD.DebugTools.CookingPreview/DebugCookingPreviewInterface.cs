using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Cooking;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace TLD.DebugTools.CookingPreview;

public class DebugCookingPreviewInterface : MonoBehaviour
{
	public class RecipeButton
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public UnityEvent<RecipeData> onClickCallback;

			public RecipeData recipe;

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
			[CallsUnknownMethods(Count = 1)]
			internal void _003CUpdateFromRecipe_003Eb__0()
			{
			}
		}

		private Button m_Button;

		private TMP_Text m_Label;

		private RawImage m_Icon;

		[CalledBy(Type = typeof(RecipeButton), Member = "Clone")]
		[CalledBy(Type = typeof(DebugCookingPreviewInterface), Member = "Start")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
		[CallsUnknownMethods(Count = 1)]
		public RecipeButton(Button button)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "Instantiate")]
		[Calls(Type = typeof(RecipeButton), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		public RecipeButton Clone(Transform parent)
		{
			return null;
		}

		[CalledBy(Type = typeof(DebugCookingPreviewInterface), Member = "Start")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
		[Calls(Type = typeof(RawImage), Member = "set_texture")]
		[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 6)]
		public void UpdateFromRecipe(RecipeData recipe, UnityEvent<RecipeData> onClickCallback)
		{
		}
	}

	private AssetLabelReference m_RecipeAssetLabel;

	private Button m_RecipeButtonTemplateReference;

	private Transform m_RecipeButtonRoot;

	private Transform m_CameraPivot;

	private Camera m_Camera;

	private Vector2 m_OrbitSpeed;

	private float m_ZoomSpeed;

	private Slider m_BgSliderRed;

	private Slider m_BgSliderGreen;

	private Slider m_BgSliderBlue;

	public UnityEvent<RecipeData> m_RecipeChanged;

	public UnityEvent<CookingPotItem.CookingState> m_CookingStateChanged;

	private RecipeButton m_RecipeButtonTemplate;

	private Vector3 m_LastMousePos;

	private static readonly int s_AmbientLightColorShaderID;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RecipeButton), Member = ".ctor")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(RecipeButton), Member = "UpdateFromRecipe")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 14)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent<>), Member = "Invoke")]
	[CallsUnknownMethods(Count = 1)]
	public void ChangeCookingStateByIndex(int cookingStateIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DebugCookingPreviewInterface()
	{
	}
}
