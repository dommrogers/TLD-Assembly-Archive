using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	protected int framerate;

	public bool ignoreTimeScale;

	public bool loop;

	public Sprite[] frames;

	private SpriteRenderer mUnitySprite;

	private UI2DSprite mNguiSprite;

	private int mIndex;

	private float mUpdate;

	public bool isPlaying
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 164)]
		get
		{
			return default(bool);
		}
	}

	public int framesPerSecond
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Play()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	public void ResetToBeginning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Start")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "ResetToBeginning")]
	private void UpdateSprite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UI2DSpriteAnimation()
	{
	}
}
