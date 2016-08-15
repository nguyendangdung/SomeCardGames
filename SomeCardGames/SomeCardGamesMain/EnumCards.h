#pragma once

/// <summary>
/// This class is used to hold the Cards enum.
/// </summary>
class PROJECTAPI EnumCards
{
public:

	/// <summary>
	/// The constructor for the EnumCards class.
	/// </summary>
	EnumCards();

	/// <summary>
	/// The deconstructor for the EnumCards class.
	/// </summary>
	~EnumCards();

	/// <summary>
	/// This enum holds values used to compare each card in a standard deck of cards
	/// </summary>
	enum Cards
	{
		TwoOfHearts, ThreeOfHearts, FourOfHearts, FiveOfHearts, SixOfHearts, SevenOfHearts, EightOfHearts, NineOfHearts, TenOfHearts, JackOfHearts, QueenOfHearts, KingOfHearts, AceOfHearts
		, TwoOfDiamonds, ThreeOfDiamonds, FourOfDiamonds, FiveOfDiamonds, SixOfDiamonds, SevenOfDiamonds, EightOfDiamonds, NineOfDiamonds, TenOfDiamonds, JackOfDiamonds, QueenOfDiamonds, KingOfDiamonds, AceOfDiamonds
		, TwoOfSpades, ThreeOfSpades, FourOfSpades, FiveOfSpades, SixOfSpades, SevenOfSpades, EightOfSpades, NineOfSpades, TenOfSpades, JackOfSpades, QueenOfSpades, KingOfSpades, AceOfSpades
		, TwoOfClubs, ThreeOfClubs, FourOfClubs, FiveOfClubs, SixOfClubs, SevenOfClubs, EightOfClubs, NineOfClubs, TenOfClubs, JackOfClubs, QueenOfClubs, KingOfClubs, AceOfClubs
	};
};

