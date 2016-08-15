#pragma once

/// <summary>
/// This class holds the Suit enum.
/// </summary>
class PROJECTAPI EnumSuit
{
public:
	/// <summary>
	/// The constructor for the EnumSuit class.
	/// </summary>
	EnumSuit();

	/// <summary>
	/// The deconstructor for the EnumSuit class.
	/// </summary>
	~EnumSuit();

	/// <summary>
	/// This enum holds values that describe which suit this card is part of.
	/// </summary>
	enum Suit
	{
		Spades, Clubs, Hearts, Diamonds
	};
};

