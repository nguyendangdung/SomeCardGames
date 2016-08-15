#pragma once

/// <summary>
/// This class is used to compare various attributes of a card, and which card a card is.
/// </summary>
class CompareCards
{
public:

	/// <summary>
	/// The constructor for the CompareCards class.
	/// </summary>
	CompareCards();

	/// <summary>
	/// The deconstructor for the CompareCards class.
	/// </summary>
	~CompareCards();

	/// <summary>
	/// This enum holds values that describe which way the card is facing, or if it is out of the game.
	/// </summary>
	enum State
	{
		FaceUp, FaceDown, OutOfGame
	};

	/// <summary>
	/// This enum holds values that describe which suit this card is part of.
	/// </summary>
	enum Suit
	{
		Spades, Clubs, Hearts, Diamonds
	};
};

