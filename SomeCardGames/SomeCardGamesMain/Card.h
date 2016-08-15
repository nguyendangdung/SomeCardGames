#pragma once

/// <summary>
/// Represents a card in game.
/// </summary>
class Card
{
public:
	/// <summary>
	/// Used to figure out what card this is.
	/// </summary>
	EnumCards *WhatCard;

	/// <summary>
	/// Used to figure out if the card is face up, face down, or out of the game.
	/// </summary>
	EnumCardState *WhatCardState;

	/// <summary>
	/// Used to figure out what suit this card is.
	/// </summary>
	EnumSuit *WhatSuit;

	/// <summary>
	/// The constructor for the Card class.
	/// </summary>
	Card(int WhatCard);

	/// <summary>
	/// The deconstructor for the Card class.
	/// </summary>
	~Card();

private:


};