#pragma once

/// <summary>
/// This class holds the State enum.
/// </summary>
class PROJECTAPI EnumCardState
{
public:

	/// <summary>
	/// The constructor for the EnumCardState class.
	/// </summary>
	EnumCardState();

	/// <summary>
	/// The deconstructor for the EnumCardState class.
	/// </summary>
	~EnumCardState();

	/// <summary>
	/// This enum holds values that describe which way the card is facing, or if it is out of the game.
	/// </summary>
	enum State
	{
		FaceUp, FaceDown, OutOfGame
	};
};

