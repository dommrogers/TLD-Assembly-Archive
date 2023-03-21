using System;
using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid;

	public const int elementId_stickX = 0;

	public const int elementId_stickY = 1;

	public const int elementId_stickRotate = 2;

	public const int elementId_stickMiniStick1X = 78;

	public const int elementId_stickMiniStick1Y = 79;

	public const int elementId_stickMiniStick1Press = 80;

	public const int elementId_stickMiniStick2X = 81;

	public const int elementId_stickMiniStick2Y = 82;

	public const int elementId_stickMiniStick2Press = 83;

	public const int elementId_stickTrigger = 3;

	public const int elementId_stickTriggerStage2 = 4;

	public const int elementId_stickPinkyButton = 5;

	public const int elementId_stickPinkyTrigger = 154;

	public const int elementId_stickButton1 = 6;

	public const int elementId_stickButton2 = 7;

	public const int elementId_stickButton3 = 8;

	public const int elementId_stickButton4 = 9;

	public const int elementId_stickButton5 = 10;

	public const int elementId_stickButton6 = 11;

	public const int elementId_stickButton7 = 12;

	public const int elementId_stickButton8 = 13;

	public const int elementId_stickButton9 = 14;

	public const int elementId_stickButton10 = 15;

	public const int elementId_stickBaseButton1 = 18;

	public const int elementId_stickBaseButton2 = 19;

	public const int elementId_stickBaseButton3 = 20;

	public const int elementId_stickBaseButton4 = 21;

	public const int elementId_stickBaseButton5 = 22;

	public const int elementId_stickBaseButton6 = 23;

	public const int elementId_stickBaseButton7 = 24;

	public const int elementId_stickBaseButton8 = 25;

	public const int elementId_stickBaseButton9 = 26;

	public const int elementId_stickBaseButton10 = 27;

	public const int elementId_stickBaseButton11 = 161;

	public const int elementId_stickBaseButton12 = 162;

	public const int elementId_stickHat1Up = 28;

	public const int elementId_stickHat1UpRight = 29;

	public const int elementId_stickHat1Right = 30;

	public const int elementId_stickHat1DownRight = 31;

	public const int elementId_stickHat1Down = 32;

	public const int elementId_stickHat1DownLeft = 33;

	public const int elementId_stickHat1Left = 34;

	public const int elementId_stickHat1Up_Left = 35;

	public const int elementId_stickHat2Up = 36;

	public const int elementId_stickHat2Up_right = 37;

	public const int elementId_stickHat2Right = 38;

	public const int elementId_stickHat2Down_Right = 39;

	public const int elementId_stickHat2Down = 40;

	public const int elementId_stickHat2Down_Left = 41;

	public const int elementId_stickHat2Left = 42;

	public const int elementId_stickHat2Up_Left = 43;

	public const int elementId_stickHat3Up = 84;

	public const int elementId_stickHat3Up_Right = 85;

	public const int elementId_stickHat3Right = 86;

	public const int elementId_stickHat3Down_Right = 87;

	public const int elementId_stickHat3Down = 88;

	public const int elementId_stickHat3Down_Left = 89;

	public const int elementId_stickHat3Left = 90;

	public const int elementId_stickHat3Up_Left = 91;

	public const int elementId_stickHat4Up = 92;

	public const int elementId_stickHat4Up_Right = 93;

	public const int elementId_stickHat4Right = 94;

	public const int elementId_stickHat4Down_Right = 95;

	public const int elementId_stickHat4Down = 96;

	public const int elementId_stickHat4Down_Left = 97;

	public const int elementId_stickHat4Left = 98;

	public const int elementId_stickHat4Up_Left = 99;

	public const int elementId_mode1 = 44;

	public const int elementId_mode2 = 45;

	public const int elementId_mode3 = 46;

	public const int elementId_throttle1Axis = 49;

	public const int elementId_throttle2Axis = 155;

	public const int elementId_throttle1MinDetent = 166;

	public const int elementId_throttle2MinDetent = 167;

	public const int elementId_throttleButton1 = 50;

	public const int elementId_throttleButton2 = 51;

	public const int elementId_throttleButton3 = 52;

	public const int elementId_throttleButton4 = 53;

	public const int elementId_throttleButton5 = 54;

	public const int elementId_throttleButton6 = 55;

	public const int elementId_throttleButton7 = 56;

	public const int elementId_throttleButton8 = 57;

	public const int elementId_throttleButton9 = 58;

	public const int elementId_throttleButton10 = 59;

	public const int elementId_throttleBaseButton1 = 60;

	public const int elementId_throttleBaseButton2 = 61;

	public const int elementId_throttleBaseButton3 = 62;

	public const int elementId_throttleBaseButton4 = 63;

	public const int elementId_throttleBaseButton5 = 64;

	public const int elementId_throttleBaseButton6 = 65;

	public const int elementId_throttleBaseButton7 = 66;

	public const int elementId_throttleBaseButton8 = 67;

	public const int elementId_throttleBaseButton9 = 68;

	public const int elementId_throttleBaseButton10 = 69;

	public const int elementId_throttleBaseButton11 = 132;

	public const int elementId_throttleBaseButton12 = 133;

	public const int elementId_throttleBaseButton13 = 134;

	public const int elementId_throttleBaseButton14 = 135;

	public const int elementId_throttleBaseButton15 = 136;

	public const int elementId_throttleSlider1 = 70;

	public const int elementId_throttleSlider2 = 71;

	public const int elementId_throttleSlider3 = 72;

	public const int elementId_throttleSlider4 = 73;

	public const int elementId_throttleDial1 = 74;

	public const int elementId_throttleDial2 = 142;

	public const int elementId_throttleDial3 = 143;

	public const int elementId_throttleDial4 = 144;

	public const int elementId_throttleMiniStickX = 75;

	public const int elementId_throttleMiniStickY = 76;

	public const int elementId_throttleMiniStickPress = 77;

	public const int elementId_throttleWheel1Forward = 145;

	public const int elementId_throttleWheel1Back = 146;

	public const int elementId_throttleWheel1Press = 147;

	public const int elementId_throttleWheel2Forward = 148;

	public const int elementId_throttleWheel2Back = 149;

	public const int elementId_throttleWheel2Press = 150;

	public const int elementId_throttleWheel3Forward = 151;

	public const int elementId_throttleWheel3Back = 152;

	public const int elementId_throttleWheel3Press = 153;

	public const int elementId_throttleHat1Up = 100;

	public const int elementId_throttleHat1Up_Right = 101;

	public const int elementId_throttleHat1Right = 102;

	public const int elementId_throttleHat1Down_Right = 103;

	public const int elementId_throttleHat1Down = 104;

	public const int elementId_throttleHat1Down_Left = 105;

	public const int elementId_throttleHat1Left = 106;

	public const int elementId_throttleHat1Up_Left = 107;

	public const int elementId_throttleHat2Up = 108;

	public const int elementId_throttleHat2Up_Right = 109;

	public const int elementId_throttleHat2Right = 110;

	public const int elementId_throttleHat2Down_Right = 111;

	public const int elementId_throttleHat2Down = 112;

	public const int elementId_throttleHat2Down_Left = 113;

	public const int elementId_throttleHat2Left = 114;

	public const int elementId_throttleHat2Up_Left = 115;

	public const int elementId_throttleHat3Up = 116;

	public const int elementId_throttleHat3Up_Right = 117;

	public const int elementId_throttleHat3Right = 118;

	public const int elementId_throttleHat3Down_Right = 119;

	public const int elementId_throttleHat3Down = 120;

	public const int elementId_throttleHat3Down_Left = 121;

	public const int elementId_throttleHat3Left = 122;

	public const int elementId_throttleHat3Up_Left = 123;

	public const int elementId_throttleHat4Up = 124;

	public const int elementId_throttleHat4Up_Right = 125;

	public const int elementId_throttleHat4Right = 126;

	public const int elementId_throttleHat4Down_Right = 127;

	public const int elementId_throttleHat4Down = 128;

	public const int elementId_throttleHat4Down_Left = 129;

	public const int elementId_throttleHat4Left = 130;

	public const int elementId_throttleHat4Up_Left = 131;

	public const int elementId_leftPedal = 168;

	public const int elementId_rightPedal = 169;

	public const int elementId_slidePedals = 170;

	public const int elementId_stick = 171;

	public const int elementId_stickMiniStick1 = 172;

	public const int elementId_stickMiniStick2 = 173;

	public const int elementId_stickHat1 = 174;

	public const int elementId_stickHat2 = 175;

	public const int elementId_stickHat3 = 176;

	public const int elementId_stickHat4 = 177;

	public const int elementId_throttle1 = 178;

	public const int elementId_throttle2 = 179;

	public const int elementId_throttleMiniStick = 180;

	public const int elementId_throttleHat1 = 181;

	public const int elementId_throttleHat2 = 182;

	public const int elementId_throttleHat3 = 183;

	public const int elementId_throttleHat4 = 184;

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickTrigger
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickTriggerStage2
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickPinkyButton
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickPinkyTrigger
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton5
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton7
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton8
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton9
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton10
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton2
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton3
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton7
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton8
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton9
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton10
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton11
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton12
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton2
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton7
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton8
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton9
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton10
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton5
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton7
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton8
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton9
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton10
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton11
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton12
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton13
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton14
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton15
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial3
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Forward
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Back
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Press
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Forward
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Back
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Press
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Forward
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Back
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Press
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EleftPedal
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002ErightPedal
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EslidePedals
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateStick Rewired_002EIHOTASTemplate_002Estick
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EstickMiniStick1
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EstickMiniStick2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EIHOTASTemplate_002Ethrottle1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EIHOTASTemplate_002Ethrottle2
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EthrottleMiniStick
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerTemplate), Member = ".ctor")]
	public HOTASTemplate(object payload)
		: base(null)
	{
	}
}
